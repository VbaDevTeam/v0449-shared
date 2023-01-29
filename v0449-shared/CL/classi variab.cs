using System;
using System.Collections.Generic;
using VbaLib;
using Serilog;
//using v0449_shared.CL.DEF.benches;


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

    //public _0496dio _0496Dio = new _0496dio();

    public BitInt[] We = new BitInt[4]; //Word di ingresso PLC
    public BitInt[] Wu = new BitInt[4]; //Word di uscita PLC
    public BitInt[] Wa = new BitInt[5]; //Word di 
    public double[] analog = new double[32];
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
    //public DATA_CONF_TEST myDataConfTest;
   public v0449CellaClient clientCella;

    public string strNameDb = "";

    public int testIdNo = 0;
    public string testLogName = "";

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
    public bool cliSrvComm;
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

    public bool abilSaveRecipe = false;

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

    public List<cdSerieDati> cdSDs = new List<cdSerieDati>();
    public List<cdYAxis> cdYAs = new List<cdYAxis>();

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
    public int testId { get; set; }
    public string testName { get; set; }
    public string testNote { get; set; }
    public int loops { get; set; }
    public List<PASSO> passiProva { get; set; }
    public string numeroDisegno { get; set; }
    

    //Ore mancanti
    private int durataTotale;
    // public int DurataTotale { get => getDurataTot();}
    public int DurataTotale { get; set; }

    private int cicliTotale;
    // public int CicliTotale { get => getCicliTot();}
    public int CicliTotale { get; set; }

    public DATA_CONF_TEST()
    {
    }


    public int getCicliTotOld()
    {
      for (int n = 0; n < passiProva.Count; n++)
        cicliTotale += int.Parse(passiProva[n].numePuls.Value.ToString());

      return cicliTotale;
    }

    public int getCicliTot()
    {
      for (int n = 0; n < passiProva.Count; n++)
      {
        if (Convert.ToBoolean(passiProva[n].abilPuls.Value))
          cicliTotale += int.Parse(passiProva[n].numePuls.Value.ToString());
      }
      cicliTotale *= (loops > 0) ? loops : 1; ;
      return cicliTotale;
    }

    public int getDurataTotOld()
    {
      int appDurata = 0;

      for (int n = 0; n < passiProva.Count; n++)
      {
        int tmCicloDura = 0;
        //int tmCicEqDura = 0;
        double tmCicloPulsa = 0;
        bool chkFineCiclo = Convert.ToBoolean(passiProva[n].blFineCiclo.Value);
        bool chkFinePulsa = Convert.ToBoolean(passiProva[n].blFinePulsa.Value);

        if (chkFineCiclo)
          tmCicloDura = (int)passiProva[n].durataPasso.Value;
        
        if (chkFinePulsa)
        {
          double app = (double)passiProva[n].tmSalita.Value / 100.0;
          tmCicloPulsa = app;
          app = (double)passiProva[n].tmAltaSt.Value / 100.0;
          tmCicloPulsa += app;
          app = (double)passiProva[n].tmDisces.Value / 100.0;
          tmCicloPulsa += app;
          app = (double)passiProva[n].tmBassaS.Value / 100.0;
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

      try
      {
        for (int n = 0; n < passiProva.Count; n++)
        {
          //durata passo impostata
          int tmCicloDura = 0;
          //durata equivalente n.cicli*durata ciclo
          //nel caso debba aspettare fine pulsazione
          //int tmCicEqDura = 0;

        double tmCicloPulsa = 0;
        

        
        bool chkFineCiclo = Convert.ToBoolean(passiProva[n].blFineCiclo.Value);
        bool chkFinePulsa = Convert.ToBoolean(passiProva[n].blFinePulsa.Value);

        //se richiesta attesa fine tempo, inizializzo appoggio
        if (chkFineCiclo)
          tmCicloDura = (int)passiProva[n].durataPasso.Value;

        //se richiesta attesa fine cicli pulsazione, calcolo durata ciclo pulsazione
        if (chkFinePulsa)
        {
            double app = (double)passiProva[n].tmSalita.Value ;
            tmCicloPulsa = app;
            app = (double)passiProva[n].tmAltaSt.Value ;
            tmCicloPulsa += app;
            app = (double)passiProva[n].tmDisces.Value ;
            tmCicloPulsa += app;
            app = (double)passiProva[n].tmBassaS.Value ;
            tmCicloPulsa += app;
            //double app = (double)passiProva[n].tmSalita.Value / 100.0;
            //tmCicloPulsa = app;
            //app = (double)passiProva[n].tmAltaSt.Value / 100.0;
            //tmCicloPulsa += app;
            //app = (double)passiProva[n].tmDisces.Value / 100.0;
            //tmCicloPulsa += app;
            //app = (double)passiProva[n].tmBassaS.Value / 100.0;
            //tmCicloPulsa += app;
            tmCicloPulsa *= (double)passiProva[n].numePuls.Value;
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
        durataTotale = appDurata * ((loops > 0) ? loops : 1);
        return durataTotale;
      }
      catch (Exception ex)
      {
        return -1;
      }
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
