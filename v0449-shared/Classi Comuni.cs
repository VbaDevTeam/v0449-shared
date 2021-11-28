using System;
using System.Collections.Generic;
using VbaLib;
using System.Text;
using Grpc.Core;
using V0449GRpc;
using V0449GRpcMicroS;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Linq;
using Newtonsoft.Json;

namespace v0449_shared
{
  public delegate void syncDb();

  //prova commit
  [Serializable()]



  public class PROVA
  {
    private ContextMini lCMini;

    public DATA_CONF_TEST myConfTest;
    public Reportheader rHeader;

    //
    /// <summary>
    /// Struttura ReportHeader
    /// </summary>
    /// 
    ///rHeader.RhId --> Identificativo Prova
    ///rHeader.RhCodiceUtente --> Identificativo Utente
    ///rHeader.RhCdId --> Identificativo Codice Disegno
    ///rHeader.RhNomeProva --> Nome esteso della prova
    ///rHeader.RhSerialiItems --> Json contenente le stringe dei seriali prova
    ///rHeader.RhCdCaSetNo --> identificativo record confapp per dataconftest
    ///rHeader.RhState --> stato della prova


    public int idProva;
    public int versioneRicetta;
    public string nomeRicetta;
    public string nomeProva;
   
    public List<string> serialiProva = new List<string>();
    public DateTime dataCreazione;
    public DateTime dataInizio;

 

    private int durataTotale;
    public int DurataTotale {
      get => durataTotale; 
      set 
      {
        durataTotale = value;
        GgTotali = ((durataTotale / 3600) / 24);
        OreTotali = (durataTotale / 3600) % 24;
        int appOreTrascorse = (durataTotale / 3600);
        MmTotali = (durataTotale - (appOreTrascorse * 3600)) / 60;
      }
    }

    private int cicliTotali;
    public int CicliTotali { get => cicliTotali; set => cicliTotali = value; }

    private int cicliFatti;
    public int CicliFatti { get => cicliFatti; set => cicliFatti = value; }


    private int cicliRimanti;
    public int CicliRimanti { get => cicliRimanti; set => cicliRimanti = value; }


    //Dati da PLC
    public int passoCorrente;

    private int nCiclo;
    public int NCiclo
    {
      get => nCiclo;
      set
      {
        nCiclo = value;
        CicliFatti = nCiclo;
        CicliRimanti = CicliTotali - CicliFatti;
      }
    }




    private int nRipetizione;
    public int NRipetizione { get => nRipetizione; set => nRipetizione = value; }


    private int tempoTrascorso;
    public int TempoTrascorso { 
      get => tempoTrascorso; 
      set { 
        tempoTrascorso = value;

        //Inizializzazione Trascorsi
        GgTrascorsi =  ((tempoTrascorso / 3600) / 24);
        OreTrascorse = (tempoTrascorso / 3600) % 24;
        int appOreTrascorse = (tempoTrascorso / 3600);
        MmTrascorsi = (tempoTrascorso - (appOreTrascorse * 3600)) / 60;

        //Inizializzazione mancanti
        int tempoMancante = durataTotale - tempoTrascorso;

        GgMancanti = ((tempoMancante / 3600) / 24);
        OreMancanti = (tempoMancante / 3600) % 24;
        int appOreMancante = (tempoMancante / 3600);
        MmMancanti = (tempoMancante - (appOreMancante * 3600)) / 60;
      }
    }


    //Giorni totali
    private int ggTotali;
    public int GgTotali { get => ggTotali; set => ggTotali = value; }
    //Ore totali
    private int oreTotali;
    public int OreTotali { get => oreTotali; set => oreTotali = value; }

    //Minuti totali
    private int mmTotali;
    public int MmTotali { get => mmTotali; set => mmTotali = value; }


    //Giorni trascorsi

    private int ggTrascorsi;
    public int GgTrascorsi { get => ggTrascorsi; set => ggTrascorsi = value; }

    //Ore trascorse
    private int oreTrascorse;
    public int OreTrascorse { get => oreTrascorse; set => oreTrascorse = value; }

    //Minuti trascorsi
    private int mmTrascorsi;
    public int MmTrascorsi { get => mmTrascorsi; set => mmTrascorsi = value; }


    //Giorni mancanti
    private int ggMancanti;
    public int GgMancanti { get => ggMancanti; set => ggMancanti = value; }

    //Ore mancanti
    private int oreMancanti;
    public int OreMancanti { get => oreMancanti; set => oreMancanti = value; }
    
    //minuti mancanti
    private int mmMancanti;
    public int MmMancanti { get => mmMancanti; set => mmMancanti = value; }

    public PROVA(Reportheader lrHeader)
    {
      lCMini = new ContextMini(mainAppParam.strConnDb);
      creaHeaderTest(lrHeader);
      initInternal(lrHeader);
    }

    public PROVA(int idProvaC)
    {
      lCMini = new ContextMini(mainAppParam.strConnDb);
      ContextMini appMini = new ContextMini(mainAppParam.strConnDb);
      Context appContext = new Context();
      idProva = idProvaC;
      rHeader = lCMini.Reportheaders.Find(idProvaC);
      if (rHeader!=null)
      {
        initInternal(rHeader);

      }
    }

    public void gestSeriali()
    {
      string[] result = JsonConvert.DeserializeObject<string[]>(rHeader.RhSerialiItems);
      foreach (string a in result)
      {
        serialiProva.Add(a);
      }
    }

    public void initInternal(Reportheader lrHeader)
    {

      rHeader = lrHeader;
      string reader;
      try
      {
        reader = lCMini.Confapps.Find(rHeader.RhCdCaSetNo).CaConfigData;
      }
      catch (Exception ex)
      {
        reader = lCMini.Confapps.ToList().Where(a => a.CaType == "TestConf").Max().ToString();
      }
      var serializer = new XmlSerializer(typeof(DATA_CONF_TEST));
      using (TextReader ddsreader = new StringReader(reader))
      {
        myConfTest = (DATA_CONF_TEST)serializer.Deserialize(ddsreader);
      }

      nomeProva = rHeader.RhNomeProva;
      nomeRicetta = lCMini.Tblcodicidisegnis.ToList().Where(e => e.CdId == rHeader.RhCdId).First().CdName;
      DurataTotale = myConfTest.durataTotale;
      CicliTotali = myConfTest.cicliTotale;

    }

    public bool creaHeaderTest(Reportheader lrHeader)
    {
      try
      {
        lCMini.Reportheaders.Add(lrHeader);
        return true;
      }
      catch(Exception ex)
      {
        return false;
      }
    }


    public void saveContext()
    {
      lCMini.SaveChanges();
    }
  }


  public class PASSO
  {
    public int stepNum;
    public string stepDescr;

    public setPoint spTempCircuit = new setPoint();
    public setPoint spTempCella = new setPoint();
    public setPoint spHumidityCella = new setPoint();
    public setPoint spPressLow = new setPoint();
    public setPoint spPressHigh = new setPoint();
    public setPoint spPort = new setPoint();
    public setPoint spTsRUp = new setPoint();
    public setPoint spTsUp = new setPoint();
    public setPoint spTsRDn = new setPoint();
    public setPoint spTsDn = new setPoint();
    public setPoint frequency = new setPoint();

    private List<ParametroVba> tmp1 = new List<ParametroVba>();
    private List<ParametroVba> tmp2 = new List<ParametroVba>();
    private List<ParametroVba> tmp3 = new List<ParametroVba>();



    //Generali
    public ParametroVba durataPasso = new ParametroVba(1, 60, "Durata passo [s]");
    public ParametroVba blFineCiclo = new ParametroVba(1, true, "Attendi fine tempo");
    public ParametroVba blFinePulsa = new ParametroVba(1, true, "Attendi fine N° pulsazione");
    public ParametroVba abilVibrazi = new ParametroVba(1, true, "Abilitazione vibrazione");
    public ParametroVba blEsclRisc = new ParametroVba(1, true, "Esclusione circolazione nel riscaldatore");
    public ParametroVba setPortata = new ParametroVba(1, 0, "Setpoint portata circolazione [Lt/Min]");

    //Pulsazione
    public ParametroVba abilPuls = new ParametroVba(1, true, "Abilitazione pulsazione");
    public ParametroVba numePuls = new ParametroVba(1, 60, "N° cicli pulsazione");
    public ParametroVba abilSinu = new ParametroVba(2, true, "Abilitazione sinusoide");
    public ParametroVba frPulsaS = new ParametroVba(3, 2, "Frequenza pulsazione [Hz]");
    public ParametroVba tmSalita = new ParametroVba(4, 60.0, "Durata salita [s]");
    public ParametroVba tmAltaSt = new ParametroVba(5, 60.0, "Durata alta [s]");
    public ParametroVba tmDisces = new ParametroVba(6, 60.0, "Durata discesa [s]");
    public ParametroVba tmBassaS = new ParametroVba(7, 60.0, "Durata bassa [s]");

    //Acquisizione
    public ParametroVba abilAcqu = new ParametroVba(1, true, "Abilitazione acquisizione");
    public ParametroVba frAcqBas = new ParametroVba(2, 5.0, "Bassa Freq. (Hz)");
    public ParametroVba frAcqAlt = new ParametroVba(2, 30.0, "Alta  Freq. (Hz)");
    public ParametroVba prAcqAlt = new ParametroVba(2, 500, "Perioro alta freq. [s]");
    public ParametroVba tmAcqAlt = new ParametroVba(2, 500, "Tempo   alta freq. [s]");

    public BitInt bitCmd = new BitInt();


    public object Clone()
    {
      return new PASSO
      {
        stepNum = this.stepNum + 1,
        stepDescr = this.stepDescr,
        spTempCircuit = this.spTempCircuit,
        spTempCella = this.spTempCella,
        spHumidityCella = this.spHumidityCella,
        spPressHigh = this.spPressHigh,
        spPressLow = this.spPressLow,
        frequency = this.frequency,

        durataPasso = this.durataPasso,
        blFineCiclo = this.blFineCiclo,
        blFinePulsa = this.blFinePulsa,
        blEsclRisc = this.blEsclRisc,
        abilVibrazi = this.abilVibrazi,
        setPortata = this.setPortata,

        abilPuls = this.abilPuls,
        numePuls = this.numePuls,
        abilSinu = this.abilSinu,
        frPulsaS = this.frPulsaS,
        tmSalita = this.tmSalita,
        tmAltaSt = this.tmAltaSt,
        tmDisces = this.tmDisces,
        tmBassaS = this.tmBassaS,

        abilAcqu = this.abilAcqu,
        frAcqBas = this.frAcqBas,
        frAcqAlt = this.frAcqAlt,
        prAcqAlt = this.prAcqAlt,
        tmAcqAlt = this.tmAcqAlt,
      };
    }



    public List<ParametroVba> getGenericParam()
    {
      tmp1.Clear();
      tmp1.Add(durataPasso);
      tmp1.Add(blFineCiclo);
      tmp1.Add(blFinePulsa);
      tmp1.Add(blEsclRisc);
      tmp1.Add(abilVibrazi);
      tmp1.Add(setPortata);
      return tmp1;
    }

    public List<ParametroVba> getPulsaParam()
    {
      tmp2.Clear();
      tmp2.Add(abilPuls);
      tmp2.Add(numePuls);
      tmp2.Add(abilSinu);
      tmp2.Add(frPulsaS);
      tmp2.Add(tmSalita);
      tmp2.Add(tmAltaSt);
      tmp2.Add(tmDisces);
      tmp2.Add(tmBassaS);
      return tmp2;
    }
    public List<ParametroVba> getAcqParam()
    {
      tmp3.Clear();
      tmp3.Add(abilAcqu);
      tmp3.Add(frAcqBas);
      tmp3.Add(frAcqAlt);
      tmp3.Add(prAcqAlt);
      tmp3.Add(tmAcqAlt);
      return tmp3;
    }
  }

  public class spManual
  {
    public setPoint spTVasca = new setPoint();
    public setPoint spTCeMan = new setPoint();
    public setPoint spTFlMan = new setPoint();
    public setPoint spPLavoroMan = new setPoint();
    public setPoint spPRiposoMan = new setPoint();
    public setPoint spTRUp = new setPoint();
    public setPoint spTUp = new setPoint();
    public setPoint spTRDn = new setPoint();
    public setPoint spTDn = new setPoint();
    public setPoint spQFlMan = new setPoint();
  }
  
  public class parametriMacchina
  {
    public int spOverPerc = 0;
  }

  public class intestazioneProva
  {
    public int idOperatore;
    public string nomeOperatore;
    public string serialeProva;
    public string nomeProva;
    public int tipoProva;
    public string serialeMezzo;
  }

  public class parControls
  {
    public System.Drawing.Point myLoc;
    public System.Drawing.Size mySize;
    public bool myVisible = true;
    public string myName = "";
    public string myText = "";
    public Type mytype;
  }
  
  [Serializable()]
  public class ParametroVba
  {
    private int orderVis;
    public int OrderVis { get { return orderVis; } set { orderVis = value; } }

    private int valInt;
    public int ValInt { get { return valInt; } set { valInt = value; } }

    private double valDouble;
    public double ValDouble { get { return valDouble; } set { valDouble = value; } }
    private DateTime valDatetime;
    public DateTime ValDatetime { get { return valDatetime; } set { valDatetime = value; } }
    private bool valBool;
    public bool ValBool { get { return valBool; } set { valBool = value; } }
    private bool active;
    public bool Active { get { return active; } set { active = value; } }
    private string descrizione;
    public string Descrizione { get { return descrizione; } set { descrizione = value; } }

    private object valOut;
    public object ValOut { get { return valOut; } set { valOut = value; } }

    private string typeNameOut;
    public string TypeNameOut { get { return typeNameOut; } set { typeNameOut = value; } }

    private Type typeOut;
    public Type TypeOut { get { return typeOut; } set { typeOut = value; } }

    public ParametroVba()
    {
    }
    public ParametroVba(int ord, object value, string descr)
    {
      orderVis = ord;
      descrizione = descr;
      //typeOut = value.GetType();
      //typeNameOut = typeOut.Name;
      valOut = value;

      //switch (typeOut.Name)
      //{
      //  case "int":
      //    valInt = (int)value;
      //    break;
      //  case "double":
      //    valDouble = (double)value;
      //    break;
      //  case "bool":
      //    valBool = (bool)value;
      //    break;
      //  case "Datetime":
      //    valDatetime = (DateTime)value;
      //    break;
      //}
    }
  }

  [Serializable()]
  public class setPoint
  {
    /// <summary>
    /// Nome del set point.
    /// Stringa utilizzata per la nomenclatura del controllo cntSetPoint
    /// </summary>
    public string Name = "Sp";

    double sp;
    /// <summary>
    /// Set point della variabile controllata
    /// </summary>
    public double Sp
    {
      get
      {
        return sp;
      }
      set
      {
        sp = value;
        lcs = sp + tollSup;
        lci = sp - tollInf;
      }
    }

    private double spMax = 100;
    public double SpMax
    {
      get
      {
        return spMax;
      }
      set
      {
        spMax = value;
      }
    }

    private double spMin = 0;
    public double SpMin
    {
      get
      {
        return spMin;
      }
      set
      {
        spMin = value;
      }
    }

    double lcs;
    /// <summary>
    /// Limite calcolato superiore 
    /// Valore assoluto di soglia alta di allarme del valore
    /// In lettura viene restituito come calcolato rispetto al setpoint
    /// in scrittura, determina il calcolo di tollSup
    /// </summary>
    public double Lcs
    {
      get
      {
        return sp + tollSup;
      }
      set
      {
        lcs = value;
        tollSup = lcs - sp;
        if ((lcs + lci) / 2 == sp)
        {
          Tolleranza = tollSup;
        }
      }
    }

    double lci;
    /// <summary>
    /// Limite calcolato inferiore
    /// Valore assoluto di soglia bassa di allarme del valore
    /// In lettura viene restituito come calcolato rispetto al setpoint
    /// in scrittura, determina il calcolo di tollInf
    /// </summary>
    public double Lci
    {
      get
      {
        return sp - tollInf;
      }
      set
      {
        lci = value;
        tollInf = sp - lci;
        if ((lcs + lci) / 2 == sp)
        {
          Tolleranza = tollInf;
        }
      }
    }

    double tollSup = 1500;
    /// <summary>
    /// Tolleranza superiore
    /// Errore relativo ammissibile oltre il setpoint
    /// </summary>
    public double TollSup
    {
      get
      {
        return tollSup;
      }
      set
      {
        tollSup = value;
        if (tollSup == tollInf) Tolleranza = value;
      }
    }

    double tollInf = 1500;
    /// <summary>
    /// Tolleranza Inferiore
    /// Errore relativo ammissibile sotto il setpoint
    /// </summary>
    public double TollInf
    {
      get
      {
        return tollInf;
      }
      set
      {
        tollInf = value;
        if (tollSup == tollInf) Tolleranza = value;
      }
    }

    double tolleranza;
    /// <summary>
    /// Tolleranza simmetrica
    /// Errore relativo ammissibile di distanza dal setpoint
    /// Impostando questo valore, vengono automaticamente impostati
    /// i limiti superiore ed inferiore
    /// </summary>
    public double Tolleranza
    {
      get
      {
        if (tollInf == tollSup)
          return tolleranza;
        else
          return -1;
      }
      set
      {
        tolleranza = value;
        tollSup = tollInf = value;
      }
    }

    //public setPoint(double Min, double Max)
    //{
    //  spMax = Max;
    //  spMin = Min;
    //}
  }

  class v0449gRpcSvcImpl : v0449gRpcSvc.v0449gRpcSvcBase
  {
    V v = new();
    public override Task<dataAnswer> getRtData(dataRequest request, ServerCallContext context)
    {
      return Task.FromResult(new dataAnswer { Message = "Adesso puoi andare affanculo, " + request.Name });
    }

    public override Task<data2Hmi> xchRtData(data2Plc request, ServerCallContext context)
    {
      TextReader reader = new StringReader(request.XmlSer);
      XmlSerializer ser = new XmlSerializer(typeof(ComRt2Plc));
      v.comRt2Plc = (ComRt2Plc)ser.Deserialize(reader);


      StringWriter outApp = new StringWriter(new StringBuilder());
      XmlSerializer serApp = new XmlSerializer(typeof(ComRt2Hmi));
      serApp.Serialize(outApp, v.comRt2Hmi);
      string appData = outApp.ToString();

      return Task.FromResult(new data2Hmi { XmlSer = appData });
    }

    public override Task<data2HmiJs> xchRtDataJs(data2PlcJs request, ServerCallContext context)
    {
      v.comRt2Plc = System.Text.Json.JsonSerializer.Deserialize<ComRt2Plc>(request.JsSer);

      //Utilizzo libreria Newtonsoft.Json
      var options = new JsonSerializerOptions { WriteIndented = true };
      
      string jsonString = System.Text.Json.JsonSerializer.Serialize(v.comRt2Hmi, options);
      return Task.FromResult(new data2HmiJs { JsSer = jsonString });
    }
  }

  class v0449MicroSClient
  {
    public event getProgressRepo gProgressRepo;
    public event getEndGenerRepo gEndGenerRepo;

    readonly v0449gRpcMicroS.v0449gRpcMicroSClient client;

    public v0449MicroSClient(v0449gRpcMicroS.v0449gRpcMicroSClient client)
    {
      this.client = client;
    }



    //public async Task reqGen(string initDate, string endDate, int reportId, int userId, string path)
    public svcReportResponse reqGen(string initDate, string endDate, int reportId, int userId, string path)
    {
      try
      {
        //Log("*** ListFeatures: lowLat={0} lowLon={1} hiLat={2} hiLon={3}", lowLat, lowLon, hiLat,
        //    hiLon);

        svcReportRequest request = new svcReportRequest
        { 
          InitRepo = initDate,
          EndRepo = endDate,
          IdReport = reportId, 
          IdUser = userId,
          PathToSave = path
        };

        svcReportResponse response = client.reqGen(request);

        return response;
      }
      catch (RpcException e)
      {
        //Log("RPC failed " + e);
        throw;
      }
    }


    public svcReportResponse reqStatus(int cmdReq)
    {
      try
      {
        //Log("*** ListFeatures: lowLat={0} lowLon={1} hiLat={2} hiLon={3}", lowLat, lowLon, hiLat,
        //    hiLon);

        svcStatusRequest request = new svcStatusRequest
        {
          MyRequest = cmdReq,
        };

        svcReportResponse response = client.reqStatus(request);

        return response;
      }
      catch (RpcException e)
      {
        //Log("RPC failed " + e);
        throw;
      }
    }





  }

  public class configData
  {
    public string ipServer { get; set; }
    public string portServer { get; set; }
    public string ipServerDb { get; set; }
    public string strDbName { get; set; }
    public string userDb { get; set; }
    public string passDb { get; set; }
    public string nameApp { get; set; }

  }



#if v0449
  public class ComRt2Plc
  {
    public ComRt2Plc()
    {
      diFs = new UInt16[4];
      diFv = new UInt16[4];
      doFs = new UInt16[4];
      doFv = new UInt16[4];
      c1 = new();
//      c2 = new();
    }
    public UInt16[] diFs { get; set; }
    public UInt16[] diFv { get; set; }
    public UInt16[] doFs { get; set; }
    public UInt16[] doFv { get; set; }
    public Int16 selCircB { get; set; }
    public Int16 wDogSrv { get; set; }
    public Int16 wDogCli { get; set; }

    public C2Plc c1 { get; set; }
    //public C2Plc c2 { get; set; }
  }
  public class C2Plc
  {
    public C2Plc()
    {
      cmdReq = new UInt16[1];
    }
    public UInt16[] cmdReq { get; set; }

    public Int16 spTVasca_d { get; set; }
    public Int16 spTCeMan_d { get; set; }
    public Int16 spTFlMan_d { get; set; }
    public Int16 spPRipMan_d { get; set; }
    public Int16 spPLavMan_d { get; set; }
    public Int16 spTRUpMan_c{ get; set; }
    public Int16 spTUpMan_c { get; set; }
    public Int16 spTRDnMan_c{ get; set; }
    public Int16 spTDnMan_c { get; set; }
    public Int16 spFreq_m   { get; set; }
    public Int16 spQFlMan_c { get; set; }
    public Int16 spTCarico_c { get; set; }
    public Int16 spTScarco_c { get; set; }
    public Int16 spOverpPerc { get; set; }
    public Int16 comStatus { get; set; }
    public int cmdReqCli { get; set; }
    public int testNoToSend { get; set; }
  }

public class ComRt2Hmi
{
  public ComRt2Hmi()
  {
    AI = new short[22];
    alarms = new ushort[5];
    c1 = new CXHmi();
    c2 = new CXHmi();
  }
  public UInt16 di0 { get; set; }
  public UInt16 di1 { get; set; }//;
  public UInt16 di2 { get; set; }//;
  public UInt16 di3 { get; set; }//;
  public UInt16 do0 { get; set; }//;
  public UInt16 do1 { get; set; }//;
  public UInt16 do2 { get; set; }//;
  public UInt16 do3 { get; set; }//;
  public Int16[] AI { get; set; }//;
  public UInt16[] alarms { get; set; }//;
  public DateTime tmSync { get; set; }//;
  public int cmdRespSrv { get; set; }//;
  public bool recDataOn { get; set; }//;
  public bool comunicOn { get; set; }//;
  public CXHmi c1 { get; set; }
  public CXHmi c2 { get; set; }
}
public class CXHmi
{
  public CXHmi()
  {
  }
  public Int16 comStatus { get; set; }//;
  public Int16 runStatus { get; set; }//;
  public Int16 spTCeMan_d { get; set; }//;
  public UInt16 cmdStAut { get; set; }//;
  public UInt16 cmdStMan { get; set; }//;
  public UInt16 cmdSt { get; set; }//;
  public Int16 flVari { get; set; }//;
  public Int16 ptrPhTest { get; set; }//;
  public Int16 ptrPhPulsa { get; set; }//;
  public Int16 ptrPh1Frig { get; set; }//;
  public Int16 ptrPhRiscCe { get; set; }//;
  public Int16 ptrPhRaffrCe { get; set; }//;
  public Int16 ptrPhCompCe { get; set; }//;

  public Int16 idNo { get; set; }//;
  public Int16 ptrStep { get; set; }//;
  public Int16 cntRip { get; set; }//;
  public Int16 spTCeAut_d { get; set; }//;
  public Int16 spTFlAut_d { get; set; }//;
  public Int16 spPresFl_d { get; set; }//;
  public Int16 pidPwRisCe_d { get; set; }//;
  public Int16 pidPwRafCe_d { get; set; }//;
  public Int16 pidPwRisFl_d { get; set; }//;
  public Int16 pidPwRafFl_d { get; set; }//;
  public int cntTmStep { get; set; }//;
  public int cntCicStep { get; set; }//;
  public int cntTmTest { get; set; }//;
  public int cntCicTest { get; set; }//;
  public int cmdRespSrv { get; set; }//;
  public bool recDataOn { get; set; }//;

 } 

#elif v0470

  public class ComRt2Plc
  {
    public ComRt2Plc()
    {
      diFs = new UInt16[3];
      diFv = new UInt16[3];
      doFs = new UInt16[3];
      doFv = new UInt16[3];
      c1 = new();
      c2 = new();
    }
    public UInt16[] diFs { get; set; }
    public UInt16[] diFv { get; set; }
    public UInt16[] doFs { get; set; }
    public UInt16[] doFv { get; set; }
    public Int16 selCircB { get; set; }
    public Int16 wDogSrv { get; set; }
    public Int16 wDogCli { get; set; }

    public C2Plc c1 { get; set; }
    public C2Plc c2 { get; set; }
  }
  public class C2Plc
  {
    public C2Plc()
    {
      cmdReq = new UInt16[1];
    }
    public UInt16[] cmdReq { get; set; }

    public Int16 spTVasca_d { get; set; }
    public Int16 spTCeMan_d { get; set; }
    public Int16 spTFlMan_d { get; set; }
    public Int16 spPLavMan_d { get; set; }
    public Int16 spPRipMan_d { get; set; }
    public Int16 spTRampaPMan_c { get; set; }
    public Int16 spQFlMan_c { get; set; }
    public Int16 spTCarico_c { get; set; }
    public Int16 spTScarco_c { get; set; }
    public Int16 spOverpPerc { get; set; }
    public Int16 comStatus { get; set; }
    public int cmdReqCli { get; set; }
    public int ricNoToSend { get; set; }

  }

  public class ComRt2Hmi
  {
    public ComRt2Hmi()
    {
      AI = new short[18];
      alarms = new ushort[5];
      c1 = new C2Hmi();
      c2 = new C2Hmi();
    }
    public UInt16 di0 { get; set; }
    public UInt16 di1 { get; set; }//;
    public UInt16 di2 { get; set; }//;
    public UInt16 di3 { get; set; }//;
    public UInt16 do0 { get; set; }//;
    public UInt16 do1 { get; set; }//;
    public UInt16 do2 { get; set; }//;
    public UInt16 do3 { get; set; }//;
    public Int16[] AI { get; set; }//;
    public UInt16[] alarms { get; set; }//;
    public DateTime tmSync { get; set; }//;
    public int cmdRespSrv { get; set; }//;
    public bool recDataOn { get; set; }//;
    public C2Hmi c1 { get; set; }
    public C2Hmi c2 { get; set; }
  }
  public class C2Hmi
  {
    public C2Hmi()
    {
    }
    public Int16 comStatus { get; set; }//;
    public Int16 runStatus { get; set; }//;
    public Int16 spTCeMan_d { get; set; }//;
    public UInt16 cmdStAut { get; set; }//;
    public UInt16 cmdStMan { get; set; }//;
    public UInt16 cmdSt { get; set; }//;
    public Int16 flVari { get; set; }//;
    public Int16 ptrPhTest { get; set; }//;
    public Int16 ptrPhPulsa { get; set; }//;
    public Int16 ptrPh1Frig { get; set; }//;
    public Int16 ptrPhRiscCe { get; set; }//;
    public Int16 ptrPhRaffrCe { get; set; }//;
    public Int16 ptrPhCompCe { get; set; }//;

    public Int16 idNo { get; set; }//;
    public Int16 ptrStep { get; set; }//;
    public Int16 cntRip { get; set; }//;
    public Int16 spTCeAut_d { get; set; }//;
    public Int16 spTFlAut_d { get; set; }//;
    public Int16 spPresFl_d { get; set; }//;
    public Int16 pidPwRisFl_d { get; set; }//;
    public Int16 pidPwRafFl_d { get; set; }//;
    public Int16 cntTmStep { get; set; }//;
    public int cntCicStep { get; set; }//;
    public int cntTmTest { get; set; }//;
    public int cntCicTest { get; set; }//;
    public int cmdRespSrv { get; set; }//;
    public bool recDataOn { get; set; }//;
  }
#endif
}


