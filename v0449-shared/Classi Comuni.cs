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

  public class dLogRecHs
  {
    public double spPr { get; set; }
    public double pvPUp { get; set; }
    public double pvPDn { get; set; }
    public double pvvEs { get; set; }
    public double pvvAc { get; set; }
    public int ctNPu { get; set; }
    public int ctTmS { get; set; }
  }

  public class dLogRecLs
  {
    public int cntCicliStep { get; set; }
    public int cntCicliTot { get; set; }
    public int cntSecStep { get; set; }
    public int cntSecTot { get; set; }
    public int ptrStep { get; set; }
    public int ptrRip { get; set; }
    public double spTFl { get; set; }
    public double pvTUp { get; set; }
    public double pvTDn { get; set; }
    public double spTCe { get; set; }
    public double pvTCe { get; set; }
    public double spQFl { get; set; }
    public double pvqFl { get; set; }
    public double spR1 { get; set; }
    public double pvtR1 { get; set; }
    public double pvtR2 { get; set; }
    public double pvtCi { get; set; }
  }


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


  public class PROVA
  {
    private Context lCMini;

    //Configurazione della prova (passi)
    //Qua dentro ci sono i metodi per estrarre durata totale e cicli totali
    public DATA_CONF_TEST myConfTest;

    //Identificativo della prova sul database 
    public Reportheader rHeader;

    public int idProva;
    public int versioneRicetta;
    public string nomeRicetta;
    public string nomeProva;

    public List<string> serialiProva = new List<string>();
    public DateTime dataCreazione;
    public DateTime dataInizio;


    //Da valorizzare con metodo myConfTest .getDurataTot
    private int durataTotale;
    public int DurataTotale
    {
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

    //Da valorizzare con metodo myConfTest .getCicliTot
    private int cicliTotali;
    public int CicliTotali { get => cicliTotali; set => cicliTotali = value; }

    private int cicliFatti;
    public int CicliFatti { get => cicliFatti; set => cicliFatti = value; }

    private int cicliRimanenti;
    public int CicliRimanenti { get => cicliRimanenti; set => cicliRimanenti = value; }


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
        CicliRimanenti = CicliTotali - CicliFatti;
      }
    }


    private int nRipetizione;
    public int NRipetizione { get => nRipetizione; set => nRipetizione = value; }


    private int tempoTrascorso;
    public int TempoTrascorso
    {
      get => tempoTrascorso;
      set
      {
        tempoTrascorso = value;

        //Inizializzazione Trascorsi
        GgTrascorsi = ((tempoTrascorso / 3600) / 24);
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
      lCMini = new Context(mainAppParam.strConnDb);
      creaHeaderTest(lrHeader);
      initInternal(lrHeader);
    }

    public PROVA(int idProvaC)
    {
      lCMini = new Context(mainAppParam.strConnDb);
      idProva = idProvaC;
      rHeader = lCMini.Reportheaders.Find(idProvaC);
      if (rHeader != null)
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

    public string[] recapTest(PROVA myProva)
    {
      string[] result = new string[2];
      result[0] = myProva.idProva + " " + myProva.nomeProva + " " + DateTime.Now.ToString();
      result[1] = "<b>Riepilogo avanzamento test " + myProva.idProva + " " + myProva.nomeProva +
                  "</b><br>" +
                  "<b>CICLI TOTALI  : </b>" + myProva.CicliTotali.ToString() + " " +
                  "<b>CICLI FATTI   : </b>" + myProva.CicliFatti.ToString() + " " +
                  "<b>CICLI MANCANTI: </b>" + myProva.CicliRimanenti.ToString() + " " +
                  "<br><hr><br>" +
                  "<b>TEMPO TOTALE   : </b>" +
                  myProva.GgTotali.ToString() + " gg - " +
                  myProva.OreTotali.ToString() + " hh - " +
                  myProva.MmTotali.ToString() + " mm" +
                  "<b>TEMPO MANCANTE   : </b>" +
                  myProva.GgMancanti.ToString() + " gg - " +
                  myProva.OreMancanti.ToString() + " hh - " +
                  myProva.MmMancanti.ToString() + " mm" +
                  "<b>TEMPO TRASCORSO   : </b>" +
                  myProva.GgTrascorsi.ToString() + " gg - " +
                  myProva.OreTrascorse.ToString() + " hh - " +
                  myProva.MmTrascorsi.ToString() + " mm" +
                  "<br><hr><br>" +
                  "";
      return result;
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
        V.evtLog.Error("ClassiComuni.cs, 231 - {@ex}", ex);
        reader = lCMini.Confapps.ToList().Where(a => a.CaType == "TestConf").Max().ToString();
      }
      var serializer = new XmlSerializer(typeof(DATA_CONF_TEST));
      using (TextReader ddsreader = new StringReader(reader))
      {
        myConfTest = (DATA_CONF_TEST)serializer.Deserialize(ddsreader);
      }
      //myConfTest.getDurataTot();
      //myConfTest.getCicliTot();
      nomeProva = rHeader.RhNomeProva;
      nomeRicetta = lCMini.Tblcodicidisegnis.ToList().Where(e => e.CdId == rHeader.RhCdId).First().CdName;
      DurataTotale = myConfTest.getDurataTot();
      myConfTest.DurataTotale = DurataTotale;
      CicliTotali = myConfTest.getCicliTot();
      myConfTest.CicliTotale = CicliTotali;

    }

    public bool creaHeaderTest(Reportheader lrHeader)
    {
      try
      {
        lCMini.Reportheaders.Add(lrHeader);
        return true;
      }
      catch (Exception ex)
      {
        V.evtLog.Error("ClassiComuni.cs, 257 - {@ex}", ex);
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
    public string id { get; set; }
    public int stepNum { get; set; }
    public string stepDescr { get; set; }

    public setPoint spTempCircuit { get; set; }
    public setPoint spTempCella { get; set; }
    public setPoint spHumidityCella { get; set; }
    //variante Hutch, sp risc. infrarosso
    public setPoint spTIr { get; set; }
    public setPoint spPressLow { get; set; }
    public setPoint spPressHigh { get; set; }
    public bool abilSpHumidityCella { get; set; }
    public bool abilSpTempCircuit { get; set; }
    public bool abilSpTempCella { get; set; }
    public bool abilSpPressLow { get; set; }
    public bool abilSpPressHigh { get; set; }
    public bool abilSpTempIRed { get; set; }

    public setPoint spPort { get; set; }
    public setPoint spTsRUp { get; set; }
    public setPoint spTsUp { get; set; }
    public setPoint spTsRDn { get; set; }
    public setPoint spTsDn { get; set; }
    public setPoint frequency { get; set; }

    private List<ParametroVba> tmp1 { get; set; }
    private List<ParametroVba> tmp2 { get; set; }
    private List<ParametroVba> tmp3 { get; set; }



    //Generali
    public ParametroVba durataPasso { get; set; }
    public ParametroVba blFineCiclo { get; set; }
    public ParametroVba blFinePulsa { get; set; }
    public ParametroVba abilVibrazi { get; set; }
    public ParametroVba blEsclRisc { get; set; }
    public ParametroVba setPortata { get; set; }

    //Pulsazione
    public ParametroVba abilPuls { get; set; }
    public ParametroVba numePuls { get; set; }
    public ParametroVba abilSinu { get; set; }
    public ParametroVba frPulsaS { get; set; }
    public ParametroVba tmSalita { get; set; }
    public ParametroVba tmAltaSt { get; set; }
    public ParametroVba tmDisces { get; set; }
    public ParametroVba tmBassaS { get; set; }

    //Acquisizione
    public ParametroVba abilAcqu { get; set; }
    public ParametroVba frAcqBas { get; set; }
    public ParametroVba frAcqAlt { get; set; }
    public ParametroVba prAcqAlt { get; set; }
    public ParametroVba tmAcqAlt { get; set; }

    public BitInt bitCmd { get; set; }




    public PASSO()
    {
      spTempCircuit = new setPoint();
      spTempCella = new setPoint();
      spHumidityCella = new setPoint();
      spTIr = new setPoint();
      spPressLow = new setPoint();
      spPressHigh = new setPoint();
      abilSpHumidityCella = true;
      abilSpTempCircuit = true;
      abilSpTempCella = true;
      abilSpPressLow = true;
      abilSpPressHigh = true;

      spPort = new setPoint();
      spTsRUp = new setPoint();
      spTsUp = new setPoint();
      spTsRDn = new setPoint();
      spTsDn = new setPoint();
      frequency = new setPoint();

      tmp1 = new List<ParametroVba>();
      tmp2 = new List<ParametroVba>();
      tmp3 = new List<ParametroVba>();



      //Generali
      durataPasso = new ParametroVba(1, 60.0, "Durata passo [s]", typeof(Double).ToString());
      blFineCiclo = new ParametroVba(1, 1, "Attendi fine tempo", typeof(Boolean).ToString());
      blFinePulsa = new ParametroVba(1, 1, "Attendi fine N° pulsazione", typeof(Boolean).ToString());
      abilVibrazi = new ParametroVba(1, 1, "Abilitazione vibrazione", typeof(Boolean).ToString());
      blEsclRisc = new ParametroVba(1, 1, "Esclusione circolazione nel riscaldatore", typeof(Boolean).ToString());
      setPortata = new ParametroVba(1, 0.0, "Setpoint portata circolazione [Lt/Min]", typeof(Double).ToString());

      //Pulsazione
      abilPuls = new ParametroVba(1, 1, "Abilitazione pulsazione", typeof(Boolean).ToString());
      numePuls = new ParametroVba(1, 60.0, "N° cicli pulsazione", typeof(Double).ToString());
      abilSinu = new ParametroVba(2, 1, "Abilitazione sinusoide", typeof(Boolean).ToString());
      frPulsaS = new ParametroVba(3, 2, "Frequenza pulsazione [Hz]", typeof(Int32).ToString());
      tmSalita = new ParametroVba(4, 60.0, "Durata salita [s]", typeof(Double).ToString());
      tmAltaSt = new ParametroVba(5, 60.0, "Durata alta [s]", typeof(Double).ToString());
      tmDisces = new ParametroVba(6, 60.0, "Durata discesa [s]", typeof(Double).ToString());
      tmBassaS = new ParametroVba(7, 60.0, "Durata bassa [s]", typeof(Double).ToString());

      //Acquisizione
      abilAcqu = new ParametroVba(1, 1, "Abilitazione acquisizione", typeof(Boolean).ToString());
      frAcqBas = new ParametroVba(2, 5.0, "Bassa Freq. (Hz)", typeof(Double).ToString());
      frAcqAlt = new ParametroVba(2, 30.0, "Alta  Freq. (Hz)", typeof(Double).ToString());
      prAcqAlt = new ParametroVba(2, 500.0, "Perioro alta freq. [s]", typeof(Double).ToString());
      tmAcqAlt = new ParametroVba(2, 500.0, "Tempo   alta freq. [s]", typeof(Double).ToString());

      bitCmd = new BitInt();


    }






    public object Clone()
    {
      return new PASSO
      {
        id = this.stepNum.ToString(),
        stepNum = this.stepNum + 1,
        stepDescr = this.stepDescr,
        spTempCircuit = this.spTempCircuit,
        spTempCella = this.spTempCella,
        spHumidityCella = this.spHumidityCella,
        spTIr = this.spTIr,
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
    public setPoint spTIrMan = new setPoint();
    public setPoint spPLavoroMan = new setPoint();
    public setPoint spPRiposoMan = new setPoint();
    public setPoint spTRUp = new setPoint();        //Setpoint tempo rampa salita
    public setPoint spTUp = new setPoint();         //Setpoint tempo mantenimento alto
    public setPoint spTRDn = new setPoint();        //Setpoint tempo rampa discesa
    public setPoint spTDn = new setPoint();         //Setpoint tempo mantenimento basso
    public setPoint spFreq_M = new setPoint();      // Setpoint frequenza pulsazione
    public setPoint spQFlMan = new setPoint();
    public setPoint spCntNumErr = new setPoint();      //Setpoint ripetizioni errori per scoppio tubo
    public setPoint spKCalcLimRott = new setPoint();    //Setpoint limite controllo scoppio tubo
    public setPoint spEnScTubo = new setPoint();    //Setpoint Enable controllo scoppio tubo
    public setPoint spTOpValScaDis = new setPoint();         //Setpoint Tempo apertura valvola scarico rampa discesa
    public setPoint spTOpValScaBas = new setPoint();    //Setpoint Tempo apertura valvola scarico mantenimento basso
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
    public string tipoCella;
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

    private double private_value;
    public double Value { get { return private_value; } set { private_value = value; } }

    private string private_type;
    public string string_Type { get { return private_type; } set { private_type = value; } }

    private bool active;
    public bool Active { get { return active; } set { active = value; } }
    private string descrizione;
    public string Descrizione { get { return descrizione; } set { descrizione = value; } }




    private double valDouble;
    public double ValDouble { get { return valDouble; } set { valDouble = value; } }
    private DateTime valDatetime;
    public DateTime ValDatetime { get { return valDatetime; } set { valDatetime = value; } }
    private bool valBool;
    public bool ValBool { get { return valBool; } set { valBool = value; } }



    // private object? valOut;
    // public object? ValOut
    // {
    //get
    //{
    //	//  JsonElement tmp = new JsonElement();
    //	//  try
    //	//  {
    //	//    tmp = (JsonElement) valOut;
    //	//    JsonValueKind appType = tmp.ValueKind;

    //	//    switch (appType)
    //	//    {
    //	//      case JsonValueKind.String:
    //	//        string? appiccica = tmp.GetString();
    //	//        try
    //	//        {
    //	//          valOut = double.Parse(appiccica);
    //	//        }
    //	//        catch (Exception e)
    //	//        {
    //	//          Console.WriteLine(e);
    //	//          valOut = appiccica;
    //	//        }
    //	//        break;
    //	//      case JsonValueKind.Number:
    //	//        valOut = tmp.GetDouble();
    //	//        break;
    //	//      case JsonValueKind.False:
    //	//      case JsonValueKind.True:
    //	//        valOut = tmp.GetBoolean();
    //	//        break;
    //	//    }
    //	//  }
    //	//  catch (Exception e)
    //	//  {
    //	//    Console.WriteLine(e);
    //	//  }
    //	return valOut;
    //   }
    //   set
    //   {
    //     valOut = value;
    //   }
    //}

    private string typeNameOut;
    public string TypeNameOut { get { return typeNameOut; } set { typeNameOut = value; } }



    public ParametroVba()
    {
    }
    public ParametroVba(int ord, double value, string descr, string typeString)
    {
      orderVis = ord;
      descrizione = descr;
      private_value = value;
      private_type = typeString;
    }
  }





  [Serializable()]
  public class setPoint
  {
    /// <summary>
    /// Nome del set point.
    /// Stringa utilizzata per la nomenclatura del controllo cntSetPoint
    /// </summary>
    ///


    public string Name
    {
      get;
      set;
    }


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


  public class configData
  {
    public string ipServerPlc { get; set; }
    public string ipServerGRpc { get; set; }
    public string portGrpc { get; set; }
    public string ipServerDb { get; set; }
    public string portServerDb { get; set; }
    public string ipServerCella { get; set; }
    public string portServerCella { get; set; }

    public string strDbName { get; set; }
    public string userDb { get; set; }
    public string passDb { get; set; }
    public string nameApp { get; set; }

    public bool versSwMaster { get; set; }
    public string typeSw { get; set; }

  }

  public class configDataRepo
  {
    public string portServer { get; set; }
    public string ipServerDb { get; set; }
    public string strDbName { get; set; }
    public string userDb { get; set; }
    public string passDb { get; set; }
    public string nameApp { get; set; }
    public string revSw { get; set; }
    public string modelBasePath { get; set; }
    public string modelName { get; set; }
    public string basePathReport { get; set; }
    public string defaultPathExport { get; set; }
  }

  public class VERSBANCO
  {
    public bool flTestRdy;
    public bool auModAut;
    public bool auModMan;
    public bool auModAutOk;
    public bool auManRun;
    public bool auAutRun;
    public bool auAutSosp;
    public bool flTestAlive;
    public bool flTestDone;
    public bool flAutRunning;
    public bool flTestAlarm;
    public bool stSelAuto;
    public bool auxOn;
    public bool lsAllarmi;
    public bool lsAllBlink;
    public bool lsPiupiu;
    public bool lsPuRun;
    public bool lsPuStop;
    public bool auxComaAvan;
    public bool auxComaIndi;
    public bool auxStarAuto;
    public bool auxStopAuto;
    public bool auxPortChiuso;
  }



  //Definizione delle classi di interscambio dati 
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
    //inizio buffer PLC comune
    public UInt16[] diFs { get; set; }
    public UInt16[] diFv { get; set; }
    public UInt16[] doFs { get; set; }
    public UInt16[] doFv { get; set; }
    public Int16 selCircB { get; set; }
    public Int16 wDogSrv { get; set; }
    public Int16 wDogCli { get; set; }
    //inizio buffer PLC

    public C2Plc c1 { get; set; }
    //fine buffer PLC

    public string interCom { get; set; }

    //public C2Plc c2 { get; set; }
  }

  public class C2Plc
  {
    public C2Plc()
    {
      cmdReq = new UInt16[1];
      auxPar = new Int16[10];
    }

    //inizio buffer circuito
    public UInt16[] cmdReq { get; set; }
    public UInt16 flVari { get; set; }
    public Int16 spTVasca_d { get; set; }
    public Int16 spTCeMan_d { get; set; }
    public Int16 spTFlMan_d { get; set; }
    public Int16 spTIrMan_d { get; set; }
    public Int16 spPRipMan_d { get; set; }
    public Int16 spPLavMan_d { get; set; }
    public Int16 spTRUpMan_c { get; set; }
    public Int16 spTUpMan_c { get; set; }
    public Int16 spTRDnMan_c { get; set; }
    public Int16 spTDnMan_c { get; set; }
    public Int16 spFreq_m { get; set; }
    public Int16 spQFlMan_c { get; set; }
    public Int16 spTCarico_c { get; set; }
    public Int16 spTScarco_c { get; set; }
    public Int16 spOverpPerc { get; set; }
    public Int16 comStatus { get; set; }
    public Int16 spCntNumErr { get; set; }
    public Int16 spKCalcLimRott { get; set; }
    public Int16 spLimSumErr { get; set; }
    public Int16[] auxPar { get; set; }
    //fine buffer circuito, segue ricetta (test header e steps)

    public int cmdReqCli { get; set; }
    public int testNoToSend { get; set; }
  }

  public class ComRt2Hmi
  {
    public ComRt2Hmi()
    {
      AI = new short[32];
      alarms = new ushort[5];
      c1 = new CXHmi();
      c2 = new CXHmi();
    }

    //membri accessori
    public int cmdRespSrv { get; set; }//;
    public bool recDataOn { get; set; }//;
    public bool comunicOn { get; set; }//;
    public Int16 wDogCli { get; set; }

    //membri mappa comunicazione PLC
    public UInt16 di0 { get; set; }
    public UInt16 di1 { get; set; }//;
    public UInt16 di2 { get; set; }//;
    public UInt16 di3 { get; set; }//;
    public UInt16 do0 { get; set; }//;
    public UInt16 do1 { get; set; }//;
    public UInt16 do2 { get; set; }//;
    public UInt16 do3 { get; set; }//;
    public UInt16[] alarms { get; set; }//;
    public Int16[] AI { get; set; }// buffer per TUTTI i canali, comuni e di circuito;
    public DateTime tmSync { get; set; }//;
    public CXHmi c1 { get; set; }
    public CXHmi c2 { get; set; }

    public string interCom { get; set; }
  }
  public class CXHmi
  {
    //costruttore (inizializza solo i compar)
    public CXHmi()
    {
      auxPar = new short[10];
    }

    //public Int16[] AI { get; set; }// buffer per TUTTI i canali, comuni e di circuito (qui ripreso come segnaposto);
    public UInt16 cmdStAut { get; set; }//;
    public UInt16 cmdStMan { get; set; }//;
    public UInt16 cmdSt { get; set; }//;
    public Int16 flVari0 { get; set; }//;
    public Int16 flVari1 { get; set; }//;
    public Int16 comStatus { get; set; }//;
    public Int16 runStatus { get; set; }//;
    public Int16 spTCeMan_d { get; set; }//;
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
    public Int16 spHCeAut_d { get; set; }//;
    public Int16 spPresFl_d { get; set; }//;
    public Int16 pidPwRisCe_d { get; set; }//;
    public Int16 pidPwRafCe_d { get; set; }//;
    public Int16 pidPwRisFl_d { get; set; }//;
    public Int16 pidPwRafFl_d { get; set; }//;
    public int cntTmStep { get; set; }//;
    public int cntCicStep { get; set; }//;
    public int cntTmTest { get; set; }//;
    public int cntCicTest { get; set; }//;
    public Int16[] auxPar { get; set; }



    // Parametri inutilizzati (da sopprimere?)
    public Int16 pvTempCella { get; set; }
    public Int16 pvRhCella { get; set; }
    //public Int16 stsCella { get; set; }
    //public Int16 spQFlAut_d { get; set; }//;
    public int cmdRespSrv { get; set; }//;
    public bool recDataOn { get; set; }//;

  }

  #region Acs 
  public class ComHmi2Acs
  {
    public ComHmi2Acs()
    {
    }

  }

  public class ComAcs2Hmi
  {
    public ComAcs2Hmi()
    {
    }
    public double pvt_TempDb { get; set; }
    public double pvt_TempWb { get; set; }
    public double pvt_PtUsr0 { get; set; }
    public double pvt_PtUsr1 { get; set; }
    public double pvt_PtUsr2 { get; set; }
    public double pvt_PtUsr3 { get; set; }
    public double pvp_LsLp { get; set; }
    public double pvp_LsHp { get; set; }
    public double pvp_HsLp { get; set; }
    public double pvp_HsHp { get; set; }
    public double pvx_AiUsr0 { get; set; }
    public double pvx_AiUsr1 { get; set; }
    public double pvx_AiUsr2 { get; set; }
    public double pvx_AiUsr3 { get; set; }
    public double pvx_AiUsr4 { get; set; }
    public double pvx_AiUsr5 { get; set; }
    public double pvTempCh { get; set; }
    public double pvhRh { get; set; }
    public double pvhAh { get; set; }
  }
  #endregion

#if v0470zzz

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
    
    public string interCom { get; set; }

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
    public Int16 flVari0 { get; set; }//;
    public Int16 flVari1 { get; set; }//;
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
    public Int16 cntTmStep { get; set; }//;
    public int cntCicStep { get; set; }//;
    public int cntTmTest { get; set; }//;
    public int cntCicTest { get; set; }//;
    public int cmdRespSrv { get; set; }//;
    public bool recDataOn { get; set; }//;
  }
  
  
  #region Acs 
  public class ComHmi2Acs
  {
    public ComHmi2Acs()
    {
    }

  }

  public class ComAcs2Hmi
  {
    public ComAcs2Hmi()
    {
    }
    public double pvt_TempDb { get; set; }
    public double pvt_TempWb { get; set; }
    public double pvt_PtUsr0 { get; set; }
    public double pvt_PtUsr1 { get; set; }
    public double pvt_PtUsr2 { get; set; }
    public double pvt_PtUsr3 { get; set; }
    public double pvp_LsLp { get; set; }
    public double pvp_LsHp { get; set; }
    public double pvp_HsLp { get; set; }
    public double pvp_HsHp { get; set; }
    public double pvx_AiUsr0 { get; set; }
    public double pvx_AiUsr1 { get; set; }
    public double pvx_AiUsr2 { get; set; }
    public double pvx_AiUsr3 { get; set; }
    public double pvx_AiUsr4 { get; set; }
    public double pvx_AiUsr5 { get; set; }
    public double pvTempCh { get; set; }
    public double pvhRh { get; set; }
    public double pvhAh { get; set; }
  }
  #endregion
  
  
#endif
}



