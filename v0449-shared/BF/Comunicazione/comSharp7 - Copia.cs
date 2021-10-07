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


namespace servVba
{
  public class comSharp7
  {
    public event syncCom onTick;
   
    #region constructor
    public comSharp7(string ipAddress)
    {
      this.ipAddress = ipAddress;

      Client = new S7Client();
    }
    #endregion

    #region local_variables
    private S7Client Client;
    private v0449_shared.V v = new v0449_shared.V();
    Context dataContext = new Context();


    private byte[] bufRd = new byte[65536];
    private byte[] bufWr = new byte[65536];
    private byte[] bufWrRcp = new byte[65536];

    short[] buffShort = new short[1024];
    short[] buffShortRcp = new short[2048];
    short[] bufSent = new short[1024];

    long[] timestamp = new long[6];
    double[] durata = new double[6];

    private int DBNoRd = 7;
    private int DBNoWr = 8;

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

    private int countCycleProg = 0;
    private int countCycleSave = 120;
    private int numPassi = 0;
    private int numScritture = 0;

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
          Thread.Sleep(1);
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

              //v.NoXml.cDiagnAnal.cycle("call");
              //elaborazione logica, aggiornamento calcoli
              //plc.Cycle();


              polling();

              //gestione allarmi
              //gesAll();

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

    
    private int ReadArea()
    {
      // Declaration separated from the code for readability
      int Amount;
      int SizeReadB = 0;
      int ResultB;

      Amount = 122;
      ResultB = Client.ReadArea(S7Consts.S7AreaDB, DBNoRd, 0, Amount, S7Consts.S7WLByte, bufRd, ref SizeReadB);
      bufByteToShort(ref buffShort, Amount, bufRd);
      unPackRead();
      ShowResult(ResultB);
      return ResultB;
    }

    private int WriteArea()
    {
      // Declaration separated from the code for readability
      int Amount;
      int SizeWrB = 0;
      int ResultB = 5310089;
      int ptrErr = 0;

      int ptrSend = 0;
      int ptrAux = 0;

      #region comandi al PLC
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFs[ptrAux++];
      
      ptrAux = 0;
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFv[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFv[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFv[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.diFv[ptrAux++];

      ptrAux = 0;
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      
      ptrAux = 0;
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];
      buffShort[ptrSend++] = (short)v.comRt2Plc.doFs[ptrAux++];

      for (int n = 0; n <v.comRt2Plc.cmdReq.Length; n++)
      {
        buffShort[ptrSend++] = (short)v.comRt2Plc.cmdReq[n];
      }
      #endregion

      #region setpoint manuali

      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTVasca_d      );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTCeMan_d      );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTFlMan_d      );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spPLavMan_d     );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spPRipMan_d     );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTRampaPMan_c  );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spQFlMan_c      );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTCarico_c     );
      buffShort[ptrSend++] = swapShort((short)v.comRt2Plc.spTScarco_c     );
      buffShort[ptrSend] = swapShort((short)v.comRt2Plc.spOverpPerc     );
      #endregion


      switch (v.comRt2Plc.cmdReqCli)
      {
        case 0:
          v.comRt2Hmi.cmdRespSrv = 0;
          break;

        case 1:
          v.comRt2Hmi.cmdRespSrv = 1;
          v.loadData((int)V.saveType.TestConf_act, v.comRt2Plc.ricNoToSend);
          v.NoXml.sendRecipe = true;
          break;
        case 3:
          v.comRt2Hmi.cmdRespSrv = 3;
          v.NoXml.recData = !v.NoXml.recData;
          v.comRt2Hmi.recDataOn = v.NoXml.recData;
          break;


      }



      //trasmissione solo se qualche dato è cambiato
      bool changed = false;
      for (int n = 0; n < ptrSend; n++)
      {
        changed |= (buffShort[n] != bufSent[n]);
      }

      durata[3] = (double)(System.DateTime.Now.Ticks - timestamp[1]) / 10000.0;
      timestamp[1] = System.DateTime.Now.Ticks;
      if (changed)
      {
        //v.banco.comBit[0].UpdOldVal();
        Amount = ptrSend * 2;
        bufShortToByte(buffShort, Amount, bufWr);
        //ResultB = Client.ReadArea(S7Consts.S7AreaDB, DBNoWr, 0, Amount, S7Consts.S7WLByte, bufRd, ref SizeWrB);
        ResultB = Client.WriteArea(S7Consts.S7AreaDB, DBNoWr, 0, Amount, S7Consts.S7WLByte, bufWr, ref SizeWrB);
        if (v.NoXml.mbErrRd == 0)
        {
          //se qualcosa è cambiato e la trasmissione è andata a buon fine,
          //copio il buffer corrente sull'immagine dei dati nel plc
          for (int n = 0; n < ptrSend; n++)
          {
            bufSent[n] = buffShort[n];
          }
        }
        durata[2] = (double)(System.DateTime.Now.Ticks - timestamp[1]) / 10000.0;
      }

      if (v.NoXml.mbErrRd != 0)
      {
        //int errore_1 = BusProtocolErrors.getBusProtocolErrorText(v.NoXml.mbErrRd);
        ptrErr++;
      }

      ShowResult(ResultB);
      return ResultB;
    }

    private int WriteRecipe()
    {
      // Declaration separated from the code for readability
      int Amount;
      int SizeWrB = 0;
      int ResultB = 5310089;
      int ptrErr = 0;

      int ptr = 0;

      short[] tmpSh;

      #region Header
      buffShortRcp[ptr++] = swapShort((short)v.dataConfTest_act.testId);
      buffShortRcp[ptr++] = swapShort((short)v.dataConfTest_act.loops);
      buffShortRcp[ptr++] = swapShort(3);
      buffShortRcp[ptr++] = (short)ptr;
      buffShortRcp[ptr++] = (short)ptr;
      #endregion

      #region test
      for (int n = 0; n < v.dataConfTest_act.passiProva.Count; n++)
      {
        tmpSh = intToShorts(int.Parse(v.dataConfTest_act.passiProva[n].durataPasso.ValOut.ToString()));                                       // tempo totale in secondi
        buffShortRcp[ptr++] = swapShort(tmpSh[1]);
        buffShortRcp[ptr++] = swapShort(tmpSh[0]);

        tmpSh = intToShorts(int.Parse(v.dataConfTest_act.passiProva[n].numePuls.ValOut.ToString()));                         // numero cicli pulsazione
        buffShortRcp[ptr++] = swapShort(tmpSh[1]);
        buffShortRcp[ptr++] = swapShort(tmpSh[0]);
        
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spTempCircuit.Sp * 10.0));                                // temperatura fluido in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spTempCella.Sp * 10.0));                                  // temperatura cella in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spHumidityCella.Sp * 10.0));                              // umidità cella in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressLow.Sp * 10.0));                                   // pressione bassa pulsazione in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressHigh.Sp * 10.0));                                  // pressione alta pulsazione in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressHigh.Lcs * 10.0));                                 // Allarme pressione in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressHigh.SpMax * 10.0));                               // Soglia contr.press.prova in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressLow.SpMax * 10.0));                                // Set super.press.minima in decimi
        buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].spPressLow.SpMin * 10.0));                                // Set infer.press.minima in decimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].setPortata.ValOut.ToString()) * 100.0));                                     // Velocità fluido in centesimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].tmSalita.ValOut.ToString()) * 100.0));       // Tempo rampa salita in centesimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].tmAltaSt.ValOut.ToString()) * 100.0));       // Tempo permanenza alta in centesimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].tmDisces.ValOut.ToString()) * 100.0));       // Tempo rampa discesa in centesimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].tmBassaS.ValOut.ToString()) * 100.0));       // Tempo permanenza bassa in centesimi
        //buffShortRcp[ptr++] = swapShort((short)(v.dataConfTest_act.passiProva[n].frequency.Sp * 1000.0));                                  // Frequenza pulsazione sinusoidale in millesimi
        buffShortRcp[ptr++] = swapShort((short)(double.Parse(v.dataConfTest_act.passiProva[n].frPulsaS.ValOut.ToString()) * 1000.0));      // Frequenza pulsazione sinusoidale in millesimi

        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 0, true);                                                        // bit da riempire se cìè il passo
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 1, (bool)v.dataConfTest_act.passiProva[n].blFineCiclo.ValOut);      // Aspetta tempo step
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 2, (bool)v.dataConfTest_act.passiProva[n].blFinePulsa.ValOut);      // Aspetta i cicli richiesti
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 3, (bool)v.dataConfTest_act.passiProva[n].abilPuls.ValOut);      // Pulsa
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 4, (bool)v.dataConfTest_act.passiProva[n].abilSinu.ValOut);      // Pulsazione sinusoidale
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 5, (bool)v.dataConfTest_act.passiProva[n].blEsclRisc.ValOut);    // Esclusione circolazione nel riscaldatore
        changeBitIntState(ref v.dataConfTest_act.passiProva[n].bitCmd, 6, (bool)v.dataConfTest_act.passiProva[n].abilVibrazi.ValOut);      // Inclusione vibrazione

        //okkio: ho rancato lo swap... scriveva tutto a 0
        //da verificare, ora scrive tutto a true. La scrittura è corretta, perchè mettendo a false
        //il flStepOk in plc vedo la configurazione corretta.
        buffShortRcp[ptr++] = ((short)v.dataConfTest_act.passiProva[n].bitCmd.Value);
      }
      #endregion

      for(int n =0; n<=20; n++)
        buffShortRcp[ptr++] = swapShort((short)(0));



      Amount = ptr * 2;
      bufShortToByte(buffShortRcp, Amount, bufWrRcp);
      ResultB = Client.WriteArea(S7Consts.S7AreaDB, DBNoWr, 70, Amount, S7Consts.S7WLByte, bufWrRcp, ref SizeWrB);

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

    private void unPackRead()
    {

      int ptrBuf = 0;
      int ptrDest = 0;

      #region gestione Digitali 0

      ushort[] tmpDi = new ushort[4];
      for (int n = 0; n < tmpDi.Length; n++)
      {
        tmpDi[ptrDest++] = S7.GetWordAt(bufRd, ptrBuf++ * 2);     //da 0 a 3 (0..7)
      }
      v.comRt2Hmi.di0 = tmpDi[0];
      v.comRt2Hmi.di1 = tmpDi[1];
      v.comRt2Hmi.di2 = tmpDi[2];
      v.comRt2Hmi.di3 = tmpDi[3];


      ptrDest = 0;
      ushort[] tmpDo = new ushort[4];
      for (int n = 0; n < v.Io.Wu.Length; n++)
      {
        //v.Io.Wu[ptrDest++].Value = buffShort[ptrBuf++];
        tmpDo[ptrDest++] = S7.GetWordAt(bufRd, ptrBuf++ * 2);     //da 4..7 (8..15)
      }
      v.comRt2Hmi.do0 = tmpDo[0];
      v.comRt2Hmi.do1 = tmpDo[1];
      v.comRt2Hmi.do2 = tmpDo[2];
      v.comRt2Hmi.do3 = tmpDo[3];


      #endregion

      #region statusCmd 8(16)
      v.comRt2Hmi.cmdStAut = (ushort)S7.GetSwIntAt(bufRd, ptrBuf++ * 2);  //8 (16)
      v.comRt2Hmi.cmdStMan = (ushort)S7.GetSwIntAt(bufRd, ptrBuf++ * 2);  //9 (18)
      v.comRt2Hmi.cmdSt = (ushort)S7.GetSwIntAt(bufRd, ptrBuf++ * 2);     //10 (20)
      #endregion



      #region gestione canali analogici 22(44)
      ptrDest = 0;
      for (int n = 0; n < v.comRt2Hmi.AI.Length; n++)
      {
        v.comRt2Hmi.AI[ptrDest++] = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);
      }
      #endregion

      #region gestione allarmi 27(54)
      ptrDest = 0;
      for (int n = 0; n < v.comRt2Hmi.alarms.Length; n++)
      {
        //v.Io.alarms[ptrDest++].Value = buffShort[ptrBuf++];
        v.comRt2Hmi.alarms[ptrDest++] = S7.GetWordAt(bufRd, ptrBuf++ * 2);     //da 27..31 (54..63)
      }
      #endregion

      #region others
      //ptrbuf=28

      if (!v.NoXml.dbDtFromPlc)
      {

        v.comRt2Hmi.ptrPh1Frig    = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                     //32(64)
        v.comRt2Hmi.ptrPhRiscCe   = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                 //33(66)
        v.comRt2Hmi.ptrPhRaffrCe  = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);       
        v.comRt2Hmi.ptrPhCompCe   = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);       
        v.comRt2Hmi.ptrPhTest     = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);
        v.comRt2Hmi.ptrPhPulsa    = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                   //37(74)

        v.comRt2Hmi.idNo          = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                   //38(76)
        v.comRt2Hmi.flVari        = (short)S7.GetSwIntAt(bufRd, ptrBuf++ * 2);               //39(78)


        v.comRt2Hmi.ptrStep       = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                      //40(80)
        v.comRt2Hmi.cntRip        = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);
        v.comRt2Hmi.spTCeAut_d    = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);
        v.comRt2Hmi.spTFlAut_d    = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);      //43(86)
        v.comRt2Hmi.spPresFl_d    = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);      //44(88)

        v.comRt2Hmi.pidPwRisCe_d  = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);  //45(90)
        v.comRt2Hmi.pidPwRafCe_d  = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);  //46(92)
        v.comRt2Hmi.pidPwRisFl_d  = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);  //47(94)
        v.comRt2Hmi.pidPwRafFl_d  = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);  //48(96)

        v.comRt2Hmi.cntTmStep = (short)S7.GetDIntAt(bufRd, ptrBuf++ * 2);                   //50(100)
        ptrBuf++;
        v.comRt2Hmi.cntCicStep = S7.GetDIntAt(bufRd, ptrBuf++ * 2);                  //52(104)
        ptrBuf++;
        v.comRt2Hmi.cntTmTest = S7.GetDIntAt(bufRd, ptrBuf++ * 2);;               //54(108)
        ptrBuf++;
        v.comRt2Hmi.cntCicTest = S7.GetDIntAt(bufRd, ptrBuf++ * 2); ;             //56(112)
        ptrBuf++;
        v.comRt2Hmi.tmSync = S7.GetDateTimeAt(bufRd, ptrBuf++ * 2);                  //58(114)
        ptrBuf = 122;
        v.comRt2Hmi.tappo = (short)S7.GetIntAt(bufRd, ptrBuf++ * 2);                        //61(122)



        //v.Io.ptrFrigo = (int)buffShort[ptrBuf++];               //32(64)
        //v.Io.ptrRiscCella = (int)buffShort[ptrBuf++];           //33(66)
        //v.Io.ptrRaffrCella = (int)buffShort[ptrBuf++];
        //v.Io.ptrComprCella = (int)buffShort[ptrBuf++];
        //v.Io.ptrPhTest = (int)buffShort[ptrBuf++];
        //v.Io.ptrPhPulsa = (int)buffShort[ptrBuf++];             //37(74)

        //v.Io.idRicOnPlc = (int)buffShort[ptrBuf++];             //38(76)
        //v.Io.flagPlc.Value = swapShort(buffShort[ptrBuf++]);    //39(78)
        //v.Io.flTestAlive = v.Io.flagPlc.Get(0);
        //v.Io.flAutRunning = v.Io.flagPlc.Get(1);
        //v.Io.flTestDone = v.Io.flagPlc.Get(2);
        //v.Io.ptrStep = (int)buffShort[ptrBuf++];                //40(80)
        //v.Io.cntRip = (int)buffShort[ptrBuf++];
        //v.Io.spTCeAut = (double)buffShort[ptrBuf++] / 10.0;
        //v.Io.spTFlAut = (double)buffShort[ptrBuf++] / 10.0;             //43(86)

        //v.Io.pidPwrRiscCe = (int)buffShort[ptrBuf++] / 10;             //44(88)
        //v.Io.pidPwrRaffCe = (int)buffShort[ptrBuf++] / 10;             //45(90)
        //v.Io.pidPwrRiscFl = (int)buffShort[ptrBuf++] / 10;             //46(92)
        //v.Io.pidPwrRaffFl = (int)buffShort[ptrBuf++] / 10;             //47(94)

        //short[] tmpSch = new short[2];
        //tmpSch[1] = buffShort[ptrBuf++];
        //tmpSch[0] = buffShort[ptrBuf++];
        //v.Io.cntTmStep = shortsToInt(tmpSch);                     //48(96)
        //tmpSch = new short[2];
        //tmpSch[1] = buffShort[ptrBuf++];
        //tmpSch[0] = buffShort[ptrBuf++];
        //v.Io.cntCicStep = shortsToInt(tmpSch);                    //50(100)
        //tmpSch = new short[2];
        //tmpSch[1] = buffShort[ptrBuf++];
        //tmpSch[0] = buffShort[ptrBuf++];
        //v.Io.cntTmStepTot = shortsToInt(tmpSch);                  //52(104)
        //tmpSch = new short[2];
        //tmpSch[1] = buffShort[ptrBuf++];
        //tmpSch[0] = buffShort[ptrBuf++];
        //v.Io.cntCicStepTot = shortsToInt(tmpSch);                 //54(108)
        //tmpSch = new short[2];
        //tmpSch[1] = buffShort[ptrBuf++];
        //tmpSch[0] = buffShort[ptrBuf++];
        ////v.Io.tmSync = shortsToUint(tmpSch);                       //56(112)
        //v.Io.tmSync = S7.GetDateTimeAt(buffShort, ptrBuf++);
      }

      #endregion
      if (v.NoXml.recData)
      {
        //Salvataggio dati!
        recData();
      }


      if (countCycleSave < countCycleProg++)
      {
        numScritture = 0;
        countCycleProg = 0;
        dataContext.SaveChanges();
        dataContext = new Context();
        var obj = dataContext.Datalogs.Local.Select(x => x.DlOrd).Max();
        if (obj != null)
          numScritture = (int)obj;
      }
    }

    private void recData()
    {
      Datalog dLog = new Datalog();

      dLog.DlOrd = numPassi++;
      dLog.DlPrIn = v.Io.analog[(int)DEF.chNoS7ai.AIpFLUIPROV];
      dLog.DlPrOut = 0;
      dLog.DlTflIn = v.Io.analog[(int)DEF.chNoS7ai.AItFLUIPROV];
      dLog.DlTflOut = DateTime.Now.Millisecond;
      dLog.DlTcella = v.Io.analog[(int)DEF.chNoS7ai.AItCELLCLIM];
      dLog.DlRhCella = 0;
      dLog.DlQfl = 0;
      dLog.DlTimeSt = DateTime.Now;
      //dataContext.Datalogs.Add(dLog);
      dataContext.Datalogs.Add(dLog);
      //dataContext.Datalogs.Append(dLog);
      //if (numPassi > 5000)
      //  numPassi = 0;
      
      
      
    }

    private void ShowResult(int Result)
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

    protected virtual int read()
    {

      //return ReadArea();
      return -1;
    }

    protected virtual int symRead()
    {
      return -1;
    }

    protected virtual int write()
    {
      //WriteArea();
      //if(v.NoXml.sendRecipe)
      //  WriteRecipe();
      return -1;
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
