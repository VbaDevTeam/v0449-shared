﻿using System;
using System.Collections.Generic;
using VbaLib;
using System.Text;
using Grpc.Core;
using V0449GRpc;
using V0449GRpcMicroS;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace v0449_shared
{
  public delegate void syncDb();


  [Serializable()]
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
    public ParametroVba durataPasso = new ParametroVba(1, 60, "Durata passo");
    public ParametroVba blFineCiclo = new ParametroVba(1, true, "Attendi fine tempo");
    public ParametroVba blFinePulsa = new ParametroVba(1, true, "Attendi fine n pulsazione");
    public ParametroVba abilVibrazi = new ParametroVba(1, true, "Abilitazione vibrazione");
    public ParametroVba blEsclRisc = new ParametroVba(1, true, "Esclusione circolazione nel riscaldatore");
    public ParametroVba setPortata = new ParametroVba(1, 0, "Setpoint portata circolazione");

    //Pulsazione
    public ParametroVba abilPuls = new ParametroVba(1, true, "Abilitazione pulsazione");
    public ParametroVba numePuls = new ParametroVba(1, 60, "n cicli pulsazione");
    public ParametroVba abilSinu = new ParametroVba(2, true, "Abilitazione sinusoide");
    public ParametroVba frPulsaS = new ParametroVba(3, 2, "Frequenza pulsazione");
    public ParametroVba tmSalita = new ParametroVba(4, 60.0, "Durata salita");
    public ParametroVba tmAltaSt = new ParametroVba(5, 60.0, "Durata alta");
    public ParametroVba tmDisces = new ParametroVba(6, 60.0, "Durata discesa");
    public ParametroVba tmBassaS = new ParametroVba(7, 60.0, "Durata bassa");

    //Acquisizione
    public ParametroVba abilAcqu = new ParametroVba(1, true, "Abilitazione acquisizione");
    public ParametroVba frAcqBas = new ParametroVba(2, 5.0, "Bassa Freq. (Hz)");
    public ParametroVba frAcqAlt = new ParametroVba(2, 30.0, "Alta  Freq. (Hz)");
    public ParametroVba prAcqAlt = new ParametroVba(2, 500, "Perioro alta freq. (Sec)");
    public ParametroVba tmAcqAlt = new ParametroVba(2, 500, "Tempo   alta freq. (Sec)");




    ////Generali
    //public ParametroVba durataPasso = new ParametroVba();
    //public ParametroVba tmFineCiclo = new ParametroVba();
    //public ParametroVba tmFinePulsa = new ParametroVba();

    ////Pulsazione
    //public ParametroVba abilPuls = new ParametroVba();
    //public ParametroVba numePuls = new ParametroVba();
    //public ParametroVba abilSinu = new ParametroVba();
    //public ParametroVba frPulsaS = new ParametroVba();
    //public ParametroVba tmSalita = new ParametroVba();
    //public ParametroVba tmAltaSt = new ParametroVba();
    //public ParametroVba tmDisces = new ParametroVba();
    //public ParametroVba tmBassaS = new ParametroVba();


    ////Acquisizione                           
    //public ParametroVba abilAcqu = new ParametroVba();
    //public ParametroVba frAcqBas = new ParametroVba();
    //public ParametroVba frAcqAlt = new ParametroVba();
    //public ParametroVba prAcqAlt = new ParametroVba();
    //public ParametroVba tmAcqAlt = new ParametroVba();






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
      //durataPasso.Descrizione = "Durata passo";
      //tmFineCiclo.Descrizione = "Attendi fine tempo";
      //tmFinePulsa.Descrizione = "Attendi fine n pulsa";
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
    public setPoint spTRampaPMan = new setPoint();
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
    // Server side handler of the SayHello RPC
    //public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    //{
    //  return Task.FromResult(new HelloReply { Message = "Adesso puoi andare affanculo, " + request.Name });
    //}
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
  }

  class v0449MicroSClient
  {
    readonly v0449gRpcMicroS.v0449gRpcMicroSClient client;

    public v0449MicroSClient(v0449gRpcMicroS.v0449gRpcMicroSClient client)
    {
      this.client = client;
    }

    public async Task GenerateReport(string initDate, string endDate, int reportId, int userId, string path)
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
          IdUser = 1,
          PathToSave = path
        };

        using (var call = client.GenerateReport(request))
        {
          var responseStream = call.ResponseStream;
          StringBuilder responseLog = new StringBuilder("Result: ");

          while (await responseStream.MoveNext())
          {
            svcReportResponse response = responseStream.Current;
            responseLog.Append(response.ToString());
          }
          //Log(responseLog.ToString());
        }
      }
      catch (RpcException e)
      {
        //Log("RPC failed " + e);
        throw;
      }
    }

  }

  class v0449gRpcMicroSImpl : v0449gRpcMicroS.v0449gRpcMicroSBase
  {
    public override async Task GenerateReport(svcReportRequest request, IServerStreamWriter<svcReportResponse> responseStream, ServerCallContext context)
    {
      List<svcReportResponse> result = new List<svcReportResponse>();

      for (int n = 0; n < 100; n++)
      {
        Random rnd = new Random();
        result.Add(new svcReportResponse { StateSrv = rnd.Next(), PercWork = rnd.Next() });
      }

      foreach (var response in result)
      {
        await responseStream.WriteAsync(response);
      }
    }

  }





  public class ComRt2Plc
  {
    public UInt16[] diFs = new UInt16[4];
    public UInt16[] diFv = new UInt16[4];
    public UInt16[] doFs = new UInt16[4];
    public UInt16[] doFv = new UInt16[4];
    public UInt16[] cmdReq = new UInt16[1];

    public Int16 spTVasca_d;
    public Int16 spTCeMan_d;
    public Int16 spTFlMan_d;
    public Int16 spPLavMan_d;
    public Int16 spPRipMan_d;
    public Int16 spTRampaPMan_c;
    public Int16 spQFlMan_c;
    public Int16 spTCarico_c;
    public Int16 spTScarco_c;
    public Int16 spOverpPerc;
    public int cmdReqCli;
    public int ricNoToSend;

  }
  public class ComRt2Hmi
  {
    public UInt16 di0;
    public UInt16 di1;
    public UInt16 di2;
    public UInt16 di3;
    public UInt16 do0;
    public UInt16 do1;
    public UInt16 do2;
    public UInt16 do3;
    public UInt16 cmdStAut;
    public UInt16 cmdStMan;
    public UInt16 cmdSt;
    public Int16[] AI = new short[16];
    public UInt16[] alarms = new ushort[5];
    public Int16 ptrPh1Frig;
    public Int16 ptrPhRiscCe;
    public Int16 ptrPhRaffrCe;
    public Int16 ptrPhCompCe;
    public Int16 ptrPhTest;
    public Int16 ptrPhPulsa;
    public Int16 idNo;
    public Int16 flVari;
    public Int16 ptrStep;
    public Int16 cntRip;
    public Int16 spTCeAut_d;
    public Int16 spTFlAut_d;
    public Int16 spPresFl_d;
    public Int16 pidPwRisCe_d;
    public Int16 pidPwRafCe_d;
    public Int16 pidPwRisFl_d;
    public Int16 pidPwRafFl_d;
    public Int16 cntTmStep;
    public int cntCicStep;
    public int cntTmTest;
    public int cntCicTest;
    public DateTime tmSync;
    public Int16 tappo;
    public int cmdRespSrv;
    public bool recDataOn;


  }
}
