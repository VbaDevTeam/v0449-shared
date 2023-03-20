using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace v0449_shared
{
  public class s7Obj // : IEquatable<s7Obj>
  {
    /*
    Nota operativa
    tre val:
      val: valore attualizzato
      val2Hmi: valore ricevuto da PLC
      val2Plc: valore settato da operatore/client

    In pratica:
      se operatore/client modifica un valore, imposta val2plc
        quando effettivamente val2plc viene scritto con successo nel PLC, val viene uguagliato a val2plc
      se plc ha un dato modificato (da pannello o debug o slm) setta val2hmi
        quando val2hmi viene effettivamente propagato al client, val viene uguagliato a val2Hmi

      il confronto val2hmi val setta updHmi che richiede un refresh
      il confronto val2plc val setta updPlc che richiede una trasmissione

      da capire quando uguagliare val e val2hmi per esser certi che sia stato preso in carico e visualizzato
    */

    private enum ptrPh
    { 
       start=0
      ,plcReading
      ,remoteUpg
      ,chngWait
      ,plcChanged
      ,remoteSend

      ,hmiChanged
      ,plcSending
      ,plcSent
    }

    private ptrPh ph;
    private ptrPh oldPh;
    double elapsed;
    long tmIn;

    private int[] size =
    {
        2   //s7int
      , 2   //s7uint
      , 4   //s7dint
      , 4   //s7udint
      , 2   //s7ushort
      , 4   //s7real
      , 12  //s7dtl
      , 2   //s7word
    };

    public enum types
    {
      s7int = 0
      , s7uint = 1
      , s7dint = 2
      , s7udint = 3
      , s7ushort = 4
      , s7real = 5
      , s7dtl = 6
      , s7word = 7
    }

    //variabili ausiliarie per scambio dati
    private int a1, a2;
    private int b1, b2;


    private int idx;
    private int oft;
    private static int firstWReg;
    private string name;
    private string desc;
    private types type;
    private dir f;
    private double val;
    private double val2hmi;
    private double val2plc;
    private static byte[] bufRd;
    private byte[] bufWr=new byte[16];
    private bool updPlc;
    private bool updHmi;
    private bool written;

    public enum dir
    {
      r = 1
      , rw = 2
      , w = 4
    }

    /// <summary>
    /// Indice dell'oggetto
    /// </summary>
    public int Idx { get => idx; set => idx = value; }
    /// <summary>
    /// Offset della variabile rispetto all'entrypoint. In bytes?
    /// </summary>
    public int Oft { get => oft + firstWReg; set => oft = value; }
    /// <summary>
    /// Entrypoint della scrittura nel buffer di scambio
    /// </summary>
    public int FirstWReg { get => firstWReg; set => firstWReg = value; }
    /// <summary>
    /// Mnemonico per definire l'oggetto
    /// </summary>
    public string Name { get => name; set => name = value; }
    /// <summary>
    /// Descrizione dell'oggetto
    /// </summary>
    public string Desc { get => desc; set => desc = value; }
    /// <summary>
    /// Tipo dato del PLC (determina il modo di trattamento)
    /// </summary>
    public types Type { get => type; set => type = value; }
    /// <summary>
    /// Direzione dell'oggetto (r, w, rw)
    /// </summary>
    public dir F { get => f; set => f = value; }
    /// <summary>
    /// Copia valore aggiornato nel PLC
    /// </summary>
    public double Val2hmi 
    {
      get => val2hmi;
    }
    /// <summary>
    /// Copia valore aggiornato da operatore (o hmi vph) per il PLC
    /// </summary>
    public double Val2plc 
    { 
      get => val2plc; 
      set => val2plc = value; 
    }


    /// <summary>
    /// Determina la necessità di trasmissione a PLC
    /// </summary>
    public bool UpdPlc
    {
      get
      {
        return updPlc;
      }
    }

    /// <summary>
    /// Determina la necessità di aggiornamento nell'HMI vph
    /// </summary>
    public bool UpdHmi
    {
      get
      {
        return updHmi;
      }
    }


    /// <summary>
    /// Buffer dati di scambio dal PLC
    /// </summary>
    public byte[] BufRd { get => bufRd; set => bufRd = value; }
    public int Size { get => size[(int)this.Type]; }
    public byte[] BufWr 
    { get
      {
        switch (this.type)
        {
          case types.s7dtl:

            break;
          case types.s7int:
            //S7.SetIntAt(bufWr, this.entryPoint + this.oft, (short)this.val2plc);
            S7.SetIntAt(bufWr, 0, (short)this.val2plc);
            break;
          case types.s7word:
            //S7.SetSwWordAt(bufWr, this.entryPoint + this.oft, (ushort)this.val2plc);
            S7.SetSwWordAt(bufWr, 0, (ushort)this.val2plc);
            break;
        }

        return bufWr;
      }
    }

    //riconosce la scrittura PLC avvenuta e uguaglia val e plc
    public bool Written
    {
      set
      {
        written = value;
      }
    }

    public s7Obj()
    {
      int a = 0;

    }
    public s7Obj(int idx)
    {
      this.idx = idx;
    }

    public s7Obj(int idx, int oft, string name, string desc, types type, dir f)
    {
      this.idx = idx;
      this.oft = oft;
      this.name = name;
      this.desc = desc;
      this.type = type;
      this.f = f;
    }

    //estrae valore oggetto da buffer dati ricevuto da S7
    public void get()
    {
      if (idx == 17)
        idx = idx;

      switch (type) 
      {
        case types.s7dtl:

          break;
        case types.s7int:
          a2 = a1;
          a1 = S7.GetIntAt(bufRd, firstWReg + oft);
          val2hmi = a1;
          if (a1!=a2) 
          {
            idx = idx;
          }
          break;

        case types.s7word:
          b2 = b1;
          b1 = S7.GetSwWordAt(bufRd, firstWReg + oft);
          if (b1 == 0 && idx == 0)
            b1 = b1;
          val2hmi = b1;
          if (b1 != b2)
          {
            idx = idx;
          }
          break;
      }

      process();
    }


    //elaborazione dati e loro propagazione
    //invocata dalla comunicazione, dopo get() che riceve i dati da PLC
    //in avvio software, attende la prima lettura da PLC e poi si mette in
    //ascolto, in attesa di cambiamenti da sopra o da sotto
    public void process()
    {
      int debNo = 17;
      if (idx == debNo)
        idx = idx;

      if (ph != oldPh)
      {
        oldPh = ph;
        tmIn = DateTime.Now.Ticks;
      }
      elapsed = (DateTime.Now.Ticks - tmIn) / 1e7;

      switch (ph)
      {
        //inizializzazione in avvio
        case ptrPh.start:
          ph = ptrPh.plcReading;
          break;

        case ptrPh.plcReading:
          //suppongo che se son qua sia disponibile una lettura valida
          val = val2plc = val2hmi;
          ph = ptrPh.remoteUpg;
          break;

        case ptrPh.remoteUpg:
          if (val == val2hmi && val == val2plc)
            ph = ptrPh.chngWait;
          //timeout, messo su per bug su wdServer, da verificare
          if (elapsed > 2)
            ph = ptrPh.chngWait;
          break;

        //------------------
        //attesa cambiamento
        case ptrPh.chngWait:
          if (val != val2hmi)
          {
            ph = ptrPh.plcChanged;
            if (idx == debNo)
              idx = idx;
          }
          if (val != val2plc)
          {
            ph = ptrPh.hmiChanged;
            if (idx == debNo)
              idx = idx;
          }
          break;

        //------------------
        //gest. cambiamento da PLC
        case ptrPh.plcChanged:
          if (idx == debNo)
            idx = idx;
          val = val2hmi;
          //val2plc = val2hmi;
          ph = ptrPh.remoteSend;
          break;

        case ptrPh.remoteSend:
          if (val2plc == val2hmi)
          {
            if (idx == debNo)
              idx = idx;
            ph = ptrPh.chngWait;
          }

          if (elapsed > 2)
            ph = ptrPh.chngWait;
          break;

        //------------------
        //gest. cambiamento da HMI (client)
        case ptrPh.hmiChanged:
          if (idx == debNo)
            idx = idx;
          val = val2plc;
          updPlc = true;
          ph = ptrPh.plcSending;
          break;

        case ptrPh.plcSending:
          if (written && val2hmi == val2plc)
          {
            if (idx == debNo)
              idx = idx;
            updPlc = false;
            ph = ptrPh.plcSent;
          }

          break;
        case ptrPh.plcSent:
          ph = ptrPh.chngWait;
          break;

      }
    }

    //public bool Equals(s7Obj other)
    //{
    //  throw new NotImplementedException();
    //}
  }

  public class s7com
  {
    public List<s7Obj> s7Objs = new List<s7Obj>()
    {
        new s7Obj() { Idx = 0, Oft=0, Name="diFs0", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 1, Oft=2, Name="diFs1", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 2, Oft=4, Name="diFs2", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 3, Oft=6, Name="diFs3", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 4, Oft=8,  Name="diFv0", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 5, Oft=10, Name="diFv1", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 6, Oft=12, Name="diFv2", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 7, Oft=14, Name="diFv3", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },


        new s7Obj() { Idx = 8,  Oft=16, Name="doFs0", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 9,  Oft=18, Name="doFs1", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 10, Oft=20, Name="doFs2", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 11, Oft=22, Name="doFs3", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 12, Oft=24,  Name="doFv0", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 13, Oft=26, Name="doFv1", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 14, Oft=28, Name="doFv2", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 15, Oft=30, Name="doFv3", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 16, Oft=32, Name="selCircB", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 17, Oft=34, Name="wDogServer", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 18, Oft=36, Name="wDogClient", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 19, Oft=38, Name="cmdReq", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 20, Oft=40, Name="flVari", Type=s7Obj.types.s7word, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 21, Oft=42, Name="spTVasca_d",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 22, Oft=44, Name="spTCeMan_d",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 23, Oft=46, Name="spTFlMan_d",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 24, Oft=48, Name="spTIrMan_d",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 25, Oft=50, Name="spPRipMan_d",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 26, Oft=52, Name="spPLavMan_d",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 27, Oft=54, Name="spTRUpMan_c",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 28, Oft=56, Name="spTUpMan_c",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 29, Oft=58, Name="spTRDnMan_c",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 30, Oft=60, Name="spTDnMan_c",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 31, Oft=62, Name="spFreq_m",        Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 32, Oft=64, Name="spQFlMan_c",      Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 33, Oft=66, Name="spTCarico_c",     Type=s7Obj.types.s7uint, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 34, Oft=68, Name="spTScarco_c",     Type=s7Obj.types.s7uint, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 35, Oft=70, Name="spOverpPerc",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 36, Oft=72, Name="comStatus",       Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 37, Oft=74, Name="spCntNumErr",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 38, Oft=76, Name="spKCalcLimRott",  Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 39, Oft=78, Name="spLimSumErr",     Type=s7Obj.types.s7int, F=s7Obj.dir.rw },

        new s7Obj() { Idx = 40, Oft=80, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 41, Oft=82, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 42, Oft=84, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 43, Oft=86, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 44, Oft=88, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 45, Oft=90, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 46, Oft=92, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 47, Oft=94, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 48, Oft=96, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
        new s7Obj() { Idx = 49, Oft=98, Name="auxPar0", Type=s7Obj.types.s7int, F=s7Obj.dir.rw },
    };
  }
}
