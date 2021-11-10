using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using VbaLib;
using v0449_shared;


namespace v0449_shared
{
  public abstract class comSharp7
  {
    public event syncCom onTick;

    #region constructor
    //public comSharp7()
    //{
    //  //throw new ExecutionEngineException();
    //}
    //public comSharp7(string ipAddress)
    //{
    //  this.ipAddress = ipAddress;

    //  Client = new S7Client();
    //}

    protected void init()
    {
      Client = new S7Client();
    }
    #endregion

    #region local_variables
    protected S7Client Client;
    protected V v = new();



    protected byte[] bufRd = new byte[65536];
    protected byte[] bufWr = new byte[65536];
    protected byte[] bufRtSent = new byte[65536];
    protected byte[] bufRcpSent = new byte[65536];


    protected long[] timestamp = new long[6];
    protected double[] durata = new double[6];

    protected int DBNoRd = 7;
    protected int DBNoWr = 8;

    protected int bufWrLen;
    protected int bufWrStartPos;

    private Thread dialogo;

    public enum s7Stat
    {
      pingo,
      nonAperto,
      apertura,
      aperto,
      chiusura,
      chiuso
    };

    protected int mbStatus = 0;
    protected int cntErr = 0;

    private int wait = 1000;

    protected bool closing = false;
    protected bool commClosed = false;



    private long appScanTime = DateTime.Now.Ticks;


    #endregion

    #region onAir
    private bool onAir = false;
    /// <summary>
    /// Comunicazione con il remoto attiva
    /// </summary>
    public bool OnAir
    {
      get
      {
        onAir = !(realScanTime > wait + onAirTimeOut);
        return onAir;
      }
    }
    #endregion

    #region onAirTimeOut
    private double onAirTimeOut = 1;
    /// <summary>
    /// Tempo di inattività dopo il quale commutare a false OnAir
    /// Calcolato automaticamente all'impostazione di scanFreqHz
    /// </summary>
    public double OnAirTimeOut
    {
      get
      {
        return onAirTimeOut / 1000;
      }
      set
      {
        onAirTimeOut = value * 1000;
      }
    }
    #endregion

    #region programClosing 
    private bool programClosing = false;
    /// <summary>
    /// da alzare quando si vuol terminare il programma. 
    /// Arresta il thread di comunicazione
    /// </summary>
    public bool ProgramClosing
    {
      get { return programClosing; }
      set { programClosing = value; }
    }
    #endregion

    #region programLocalSym 
    private bool programLocalSym = false;
    /// <summary>
    /// Selezione modo simulazione dati
    /// </summary>
    public bool ProgramLocalSym
    {
      get { return programLocalSym; }
      set { programLocalSym = value; }
    }
    #endregion

    #region ipAddress
    private string ipAddress;
    /// <summary>
    /// indirizzo IPV4 dello slave remoto a cui connettersi
    /// </summary>
    public string IpAddress
    {

      get { return ipAddress; }
      set { ipAddress = value; }
    }
    #endregion

    #region datiRemoto
    private datiRemoto drTerminale;
    public datiRemoto DrTerminale
    {
      get { return drTerminale; }
      set { drTerminale = value; }
    }
    #endregion


    #region realScanTime
    private double realScanTime;
    /// <summary>
    /// Tempo in secondi di intervallo tra due comunicazioni
    /// </summary>
    public double RealScanTime
    {
      get
      {
        return realScanTime / 1000;
      }
    }
    #endregion

    public void runServer()
    {
      int cntTout = 0;

      if (!programLocalSym) //se il dialogo è attivo
      {
        do
        {
          Thread.Sleep(9);
          realScanTime = (DateTime.Now.Ticks - appScanTime) / 1e4;

          switch (mbStatus)
          {
            case (int)s7Stat.pingo:
              wait = 2000;
              // if (drTerminale.ping())
              if (true)
              {
                wait = 50;
                mbStatus = (int)s7Stat.nonAperto;
                cntTout = 0;
              }
              break;

            case (int)s7Stat.nonAperto:
              //Connettiti
              
              mbStatus = (int)s7Stat.apertura;
              break;

            case (int)s7Stat.apertura:
              cntTout++;
              if (connect()==0)//Verifica che sia connesso
                mbStatus = (int)s7Stat.aperto;
              break;

            case (int)s7Stat.aperto:
              //Esecuzione lettura
              if (read() != 0)
                cntErr++;
              else
              {
                cntErr = 0;
                appScanTime = DateTime.Now.Ticks;
              }

              unPackRead();
              //v.NoXml.cDiagnAnal.cycle("call");
              //elaborazione logica, aggiornamento calcoli
              //plc.Cycle();


              polling();

              //gestione allarmi
              //gesAll();

              pack2write();

              write();


              if (cntErr > 5)
              {
                mbStatus = (int)s7Stat.chiusura;
              }

              break;

            case (int)s7Stat.chiusura:
              cntTout++;
             
              if (Client.Disconnect() == 0) //Attende chiusura connessione
              {
                mbStatus = (int)s7Stat.chiuso;
              }
              break;

            case (int)s7Stat.chiuso:
              mbStatus = (int)s7Stat.pingo;
              break;
          }
          if (cntTout > 5)
            mbStatus = (int)s7Stat.pingo;

          onTick?.Invoke("call");

        } while (!programClosing);

      }
      else
      {
        do
        {
          //codice per simulazione senza comunicazione
          Thread.Sleep(wait);
          realScanTime = (DateTime.Now.Ticks - appScanTime) / 1e4;

          cntErr = 0;
          appScanTime = DateTime.Now.Ticks;

          symRead();
          //symPolling();
          //symWrite();
          wait = 50;
        } while (!closing);
      }
    }

    private int connect()
    {
      int Result;
      int Rack = 0;
      int Slot = 0;
      Result = Client.ConnectTo(ipAddress, Rack, Slot);
      ShowResult(Result);
      return Result;
    }



    private int WriteRecipe()
    {
      // Declaration separated from the code for readability
      int Amount=10;
      int SizeWrB = 0;
      int ResultB = 5310089;
      int ptrErr = 0;

      int ptr = 0;

      short[] tmpSh;

      ResultB = Client.WriteArea(S7Consts.S7AreaDB, DBNoWr, 70, Amount, S7Consts.S7WLByte, bufWr, ref SizeWrB);

      if (v.NoXml.mbErrRd != 0)
      {
        ptrErr++;
      }
      else
      {
        //Richiedo azzeramento comando
        v.comRt2Hmi.cmdRespSrv = 2;
        v.NoXml.sendRecipe = false;
      }
      ShowResult(ResultB);
      return ResultB;
    }


    private void recData()
    {
      Datalog dLog = new Datalog();

      //dLog.DlOrd = numPassi++;
      //dLog.DlPrIn = v.Io.analog[(int)DEF.chNoS7ai.AIpFLUIPROV];
      //dLog.DlPrOut = 0;
      //dLog.DlTflIn = v.Io.analog[(int)DEF.chNoS7ai.AItFLUIPROV];
      //dLog.DlTflOut = DateTime.Now.Millisecond;
      //dLog.DlTcella = v.Io.analog[(int)DEF.chNoS7ai.AItCELLCLIM];
      //dLog.DlRhCella = 0;
      //dLog.DlQfl = 0;
      //dLog.DlTimeSt = DateTime.Now;
      ////dataContext.Datalogs.Add(dLog);
      //dataContext.Datalogs.Add(dLog);
      ////dataContext.Datalogs.Append(dLog);
      ////if (numPassi > 5000)
      ////  numPassi = 0;
      
      
      
    }

    protected void ShowResult(int Result)
    {
      // This function returns a textual explaination of the error code
      string result = Client.ErrorText(Result);
      if (Result == 0)
        result = result + " (" + Client.ExecutionTime.ToString() + " ms)";
    }

    public void Start()
    {
      if (ipAddress == null)
      {
        throw new Exception("Indirizzo remoto non impostato");
      }
      else
      {
        drTerminale = new datiRemoto(ipAddress);
        dialogo = new Thread(new ThreadStart(runServer));
        dialogo.Start();
        Console.WriteLine(ipAddress.ToString());
        Console.WriteLine(drTerminale.ToString());
      }
    }

    public void Abort()
    {
      dialogo.Interrupt();
    }

    protected virtual void polling()
    {
    }

    protected virtual int symRead()
    {
      return -1;
    }

    protected virtual int read()
    {
      return 0;
    }
    
    protected virtual void unPackRead()
    {

    }

    protected virtual void pack2write()
    { 
    
    }

    protected virtual int write()
    {
      int ResultB = 5310089;
      int ptrErr = 0;

      //trasmissione solo se qualche dato è cambiato
      bool changed = false;
      for (int n = 0; n < bufWrLen; n++)
      {
        changed |= (bufWr[n] != bufRtSent[n]);
      }

      durata[3] = (double)(System.DateTime.Now.Ticks - timestamp[1]) / 10000.0;
      timestamp[1] = System.DateTime.Now.Ticks;
      if (changed)
      {
        ResultB = Client.DBWrite(DBNoWr, bufWrStartPos, bufWrLen, bufWr);
        if (v.NoXml.mbErrRd == 0)
        {
          //se qualcosa è cambiato e la trasmissione è andata a buon fine,
          //copio il buffer corrente sull'immagine dei dati nel plc
          for (int n = 0; n < bufWrLen; n++)
          {
            bufRtSent[n] = bufWr[n];
          }
        }
        durata[2] = (double)(System.DateTime.Now.Ticks - timestamp[1]) / 10000.0;
      }

      if (v.NoXml.mbErrRd != 0)
      {
        ptrErr++;
      }

      ShowResult(ResultB);
      return ResultB;

    }

    #region modData
    private int bufShortToByte(short[] bSh, int nSh, Byte[] bBy)
    {
      for (int n = 0; n < nSh; n++)
      {
        bBy[n * 2 + 1] = (byte)(bSh[n] >> 8); //MSB -- Parte alta
        bBy[n * 2] = (byte)(bSh[n] & 0x00ff); //LSB -- Parte Bassa
      }
      return nSh;
    }
    private int bufByteToShort(ref short[] bSh, int nSh, Byte[] bBy)
    {
      for (int n = 0; n < nSh; n++)
      {
        bSh[n] = (short)(bBy[n * 2 + 1] + (short)(bBy[n * 2] << 8));
      }
      return nSh;
    }
    private short swapShort(short arg)
    {
      byte h, l;
      h = (byte)(arg >> 8);
      l = (byte)(arg & 0x00ff);
      return (short)(h + (short)(l << 8));
    }
    private short[] intToShorts(int value)
    {
      short[] result = new short[2];

      result[0] = (short)(value & 0xffff);  //LSB -- Parte Bassa
      result[1] = (short)(value >> 16);     //MSB -- Parte alta
      return result;
    }
    private int shortsToInt(short[] value)
    {
      int result = 0;
      result = (int)(value[0] + (value[1] << 16));
      return result;
    }

    private uint shortsToUint(short[] value)
    {
      uint result = 0;
      result = (uint)(value[0] + (value[1] << 16));
      return result;
    }

    private void changeBitIntState(ref BitInt bInt, int ndxBit, bool status)
    {
      if (status)
        bInt.Set(ndxBit);
      else
        bInt.Rst(ndxBit);
    }
    #endregion

  }
}
