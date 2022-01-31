using System;
using System.Collections.Generic;
using VbaLib;
using Serilog;



namespace v0449_shared
{

  public class IO
  { 
    public PASSO passoCorrente;
    public VERSBANCO myBanco;

    public int ptrPh1Frig;
    public int ptrPhRiscCe;
    public int ptrPhRaffrCe;
    public int ptrPhCompCe;


    public BitInt[] We = new BitInt[4]; //Word di ingresso PLC
    public BitInt[] Wu = new BitInt[4]; //Word di uscita PLC
    public BitInt[] Wa = new BitInt[5]; //Word di 
    public double[] analog = new double[31];
    public BitInt[] Fp = new BitInt[4];
    public BitInt[] FpApp = new BitInt[4];

    public int flRefRiemp = 0;

    #region Siemens
    public BitInt[] d_i;
    public BitInt[] d_o;

    public double VPoRAFFMAIN;
    public double VPoRAFFINTE;
    public double MPoALIMENTO;
    public double MPoCIRCPROV;
    public double MPoRAFFINTE;
    public double spWp120;
    public double spWp200;
    public double spWp530;
    public double spPCarico;
    public double spQRicirc;
    public double spTemp;
    public double pidPwrRiscCe;
    public double pidPwrRaffCe;
    public double pidPwrRiscFl;
    public double pidPwrRaffFl;
    public DateTime tmSync;
    public int ptrFrigo;
    public int ptrRiscCella;
    public int ptrRaffrCella;
    public int ptrComprCella;
    public int ptrPhTest;
    public int ptrPhPulsa;
    public int idOnPlc = -1;

    public BitInt flagPlc0 = new BitInt();
    public BitInt flagPlc1 = new BitInt();
    public int ptrStep;
    public int cntRip;
    public double spTCeAut;
    public double spTFlAut;
    public double spHCeAut;

    public double spPresFl;

    public int cntTmStep;
    public int cntCicStep;
    public int cntTmStepTot;
    public int cntCicStepTot;
    public int tappo;

    public double scanCycle;

    public BitInt[] statiBanco = new BitInt[1];
    //public BitInt[] alSistema = new BitInt[3];
    public BitInt[] alarms = new BitInt[5];
    public BitInt[] flSt;
    public BitInt[] diCmd;
    public BitInt[] doCmd;
    static int cmdNo = 1;
    public BitInt[] cmdBancoRequest = new BitInt[cmdNo];
    public BitInt[] cmdBancoStatus = new BitInt[cmdNo];
    public BitInt[] cmdBancoStatusAut = new BitInt[cmdNo];
    public BitInt[] cmdBancoStatusMan = new BitInt[cmdNo];



    //variabili in scrittura

    #endregion
  }

  public class NO_XML
  {

   public v0449CellaClient clientCella;

    public string strNameDb = "";


    public bool testDone = true;
    public bool recData = false;
    public BitInt cmdToPlc = new();
    

    public bool dbDtFromPlc = false;

    public bool frStateOpen = false;

    public bool closing = false;
    public bool commClosed = false;
    public bool running = false;
    public bool flCCW = false; //verso rotazione trascinamento opposto a pompe mandata e refrigerante
    public int scrReq;
    public bool sendRecipe = false;
    public int testNoSend = 0;


    public ushort statusIO;
    public ushort statusIO_100;
    public bool pcPlcCommWr;
    public ushort pcPlcComm;
    public ushort plcPcComm;
    public BitInt gestBool;

    public int mbErrWr;
    public int mbErrWrCtr;
    public int mbErrRd;
    public int mbErrRd_110;
    public int mbErrRdCtr;
    public int mbErrRdCtr_110;

    public int tipoProvaVariab = 0;
    //public frmDiagnAnal pDiagnAnal;
    public bool pDiagnAnalOpen;


    public bool flEv1095Man;
    public bool flEv790Man;


    public setPoint oilPropPos;
    public setPoint oilPropPosAut;
    public setPoint oilPropDp;
    public setPoint oilPropDpAut;
    public setPoint h2oPropPos;
    public setPoint h2oPropPosAut;
    public setPoint h2oPropDp;
    public setPoint h2oPropDpAut;

    public bool fineRicercaLavoro;
    public bool lanciaForm;

    public bool systemAlarms;


    #region DVP
    public int sysTime;

    #endregion


  }

  public class DATA_APPL
  {
    public ParametriComuni comPar;
    public analIo aio;
    public int userNdx;
  }

  public class DATA_WORK
  {
    public spManual lSpManual = new spManual();
    public parametriMacchina pMacchina = new parametriMacchina();

    public setPoint spTFluido;
    public setPoint spPValle;
    public setPoint spPMonte;
    public setPoint spQCirc;
    public setPoint spTCella;
    public double dpMonte;

    public DATA_WORK()
    {
      spTFluido = new setPoint();
      spPValle = new setPoint();
      spPMonte = new setPoint();
      spQCirc = new setPoint();
      spTCella = new setPoint();
    }
  }

  public class DATA_TEST
  {
  }

  public class DATA_CONF_TEST
  {
    public int testId;
    public string testName;
    public string testNote;
    public int loops;
    public List<PASSO> passiProva;
    public string numeroDisegno;
    

    //Ore mancanti
    private int durataTotale;
    public int DurataTotale { get => getDurataTot();}


    private int cicliTotale;
    public int CicliTotale { get => getCicliTot();}


    public DATA_CONF_TEST()
    {
    }


    public int getCicliTotOld()
    {
      for (int n = 0; n < passiProva.Count; n++)
        cicliTotale += int.Parse(passiProva[n].numePuls.ValOut.ToString());

      return cicliTotale;
    }

    public int getCicliTot()
    {
      for (int n = 0; n < passiProva.Count; n++)
      {
        if ((bool)passiProva[n].abilPuls.ValOut)
          cicliTotale += int.Parse(passiProva[n].numePuls.ValOut.ToString());
      }
      cicliTotale *= (loops + 1);
      return cicliTotale;
    }

    public int getDurataTotOld()
    {
      int appDurata = 0;

      for (int n = 0; n < passiProva.Count; n++)
      {
        int tmCicloDura = 0;
        int tmCicEqDura = 0;
        double tmCicloPulsa = 0;
        bool chkFineCiclo = (bool)passiProva[n].blFineCiclo.ValOut;
        bool chkFinePulsa = (bool)passiProva[n].blFinePulsa.ValOut;

        if (chkFineCiclo)
          tmCicloDura = int.Parse(passiProva[n].durataPasso.ValOut.ToString());
        
        if (chkFinePulsa)
        {
          double app = double.Parse(passiProva[n].tmSalita.ValOut.ToString());
          tmCicloPulsa = app;
          app = double.Parse(passiProva[n].tmAltaSt.ValOut.ToString());
          tmCicloPulsa += app;
          app = double.Parse(passiProva[n].tmDisces.ValOut.ToString());
          tmCicloPulsa += app;
          app = double.Parse(passiProva[n].tmBassaS.ValOut.ToString());
          tmCicloPulsa += app;
        }

        if (tmCicloDura > tmCicloPulsa) 
        {
          appDurata += tmCicloDura;
        } 
        else 
        {
          appDurata += (int)tmCicloPulsa;
        }
      }
      durataTotale = appDurata * (loops + 1);
      return durataTotale;
    }

    public int getDurataTot()
    {
      int appDurata = 0;

      for (int n = 0; n < passiProva.Count; n++)
      {
        //durata passo impostata
        int tmCicloDura = 0;
        //durata equivalente n.cicli*durata ciclo
        //nel caso debba aspettare fine pulsazione
        int tmCicEqDura = 0;

        double tmCicloPulsa = 0;
        bool chkFineCiclo = (bool)passiProva[n].blFineCiclo.ValOut;
        bool chkFinePulsa = (bool)passiProva[n].blFinePulsa.ValOut;

        //se richiesta attesa fine tempo, inizializzo appoggio
        if (chkFineCiclo)
          tmCicloDura = int.Parse(passiProva[n].durataPasso.ValOut.ToString());

        //se richiesta attesa fine cicli pulsazione, calcolo durata ciclo pulsazione
        if (chkFinePulsa)
        {
          double app = double.Parse(passiProva[n].tmSalita.ValOut.ToString());
          tmCicloPulsa = app;
          app = double.Parse(passiProva[n].tmAltaSt.ValOut.ToString());
          tmCicloPulsa += app;
          app = double.Parse(passiProva[n].tmDisces.ValOut.ToString());
          tmCicloPulsa += app;
          app = double.Parse(passiProva[n].tmBassaS.ValOut.ToString());
          tmCicloPulsa += app;
        }

        //scelgo il più lungo tra i due
        if (tmCicloDura > tmCicloPulsa)
        {
          appDurata += tmCicloDura;
        }
        else
        {
          appDurata += (int)tmCicloPulsa;
        }
      }
      durataTotale = appDurata * (loops + 1);
      return durataTotale;
    }


  }

  public class DATA_USR
  {
  }

  public class ENV
  {
  }

  public class ParametriComuni
  {
    private static bool _XlsDebug;
    public bool XlsDebug
    {
      get { return _XlsDebug; }
      set { _XlsDebug = value; }
    }

    private static string _basePath;
    public string BasePath
    {
      get { return _basePath; }
      set { _basePath = value; }
    }

    private static int _nRegistriIn = 14;
    public int NRegistriIn
    {
      get { return ParametriComuni._nRegistriIn; }
      set { ParametriComuni._nRegistriIn = value; }
    }

    private static int _nRegistriOut = 4;
    public int NRegistriOut
    {
      get { return ParametriComuni._nRegistriOut; }
      set { ParametriComuni._nRegistriOut = value; }
    }

    private static bool _AttivaPolling;

    public bool AttivaPolling
    {
      get { return ParametriComuni._AttivaPolling; }
      set { ParametriComuni._AttivaPolling = value; }
    }

    private static string _IPAddress;

    public string IPAddress
    {
      get { return ParametriComuni._IPAddress; }
      set { ParametriComuni._IPAddress = value; }
    }

    private static int _PortNumber;

    public int PortNumber
    {
      get { return ParametriComuni._PortNumber; }
      set { ParametriComuni._PortNumber = value; }
    }

    private static int _CycleRate;

    public int CycleRate
    {
      get { return ParametriComuni._CycleRate; }
      set { ParametriComuni._CycleRate = value; }
    }

    private static int _nRegRead;
    public int NRegRead
    {
      get { return _nRegRead; }
      set { _nRegRead = value; }
    }

    private static int _nRegWrite;
    public int NRegWrite
    {
      get { return _nRegWrite; }
      set { _nRegWrite = value; }
    }

    private static string _strCOM = "";

    public string StrCOM
    {
      get { return _strCOM; }
      set { _strCOM = value; }
    }

    public ParametriComuni()
    {
    }
  }
}
