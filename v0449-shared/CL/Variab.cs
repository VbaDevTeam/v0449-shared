using System;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using VbaLib;
using Serilog;
using System.Threading;

namespace v0449_shared
{

  public class argSyncStep
  {
    public int dummy;
  }

  public class V
  {
    public static string targetSel;

    public static DEF Def = new DEF();
    public System.Globalization.CultureInfo ci;
    public static System.Globalization.NumberFormatInfo ni = null;
    public event Loaded myLoad;

    public static Serilog.ILogger ioLog;
    public static Serilog.ILogger evtLog;
    public static Serilog.ILogger dataLogLs;
    public static Serilog.ILogger dataLogHs;

    public static string cfgBenchId = "";
    public static string cfgNameBase = "";
    public static string logNameBase = "";
    public static string logDataTest = "";
    public static configData srvConfPar;
    public static List<Thread> dialogo;


    public static bool end7;
    public static bool endCella;

    public V()
    {
      if (!initDone)
      {
        ci = System.Globalization.CultureInfo.InstalledUICulture;
        ni = (System.Globalization.NumberFormatInfo)ci.NumberFormat.Clone();
        ni.NumberDecimalSeparator = ".";
        ni.NumberGroupSeparator = "'";
        ni.NumberDecimalDigits = 3;


        initDone = true;

        this.init();
        this.initDbAppl();
        this.initDbConfTest();

      }
      //...
    }

    #region VARIABILI

    public static string serialeMezzo;

    #endregion



    //costanti gestione "ini"
    public enum saveType { Application = 1, User, Recipe, TestConf, Test, Working, TestConf_act };

    public static event Loaded loaded;

    private static NO_XML noXml = new NO_XML();
    public NO_XML NoXml
    {
      get { return V.noXml; }
      set { V.noXml = value; }
    }

    private static DATA_APPL _dataAppl = new DATA_APPL();
    public DATA_APPL DataAppl
    {
      get { return _dataAppl; }
      set { _dataAppl = value; }
    }

    private static IO _io = new IO();
    public IO Io
    {
      get { return V._io; }
      set { V._io = value; }
    }

    private static DATA_CONF_TEST data_conf_test = new DATA_CONF_TEST();
    public DATA_CONF_TEST dataConfTest
    {
      get {
        return data_conf_test;
      }
      set {
        data_conf_test = value;
      }
    }

    private static DATA_CONF_TEST data_conf_test_act = new DATA_CONF_TEST();
    public DATA_CONF_TEST dataConfTest_act
    {
      get {
        return data_conf_test_act;
      }
      set {
        data_conf_test_act = value;
      }
    }

    private static DATA_TEST data_test = new DATA_TEST();
    public DATA_TEST dataTest
    {
      get { return data_test; }
      set { data_test = value; }
    }

    private static DATA_WORK data_work = new DATA_WORK();
    public DATA_WORK dataWork
    {
      get { return data_work; }
      set { data_work = value; }
    }

    private static ENV _Env = new ENV();
    public ENV Env
    {
      get { return _Env; }
      set { _Env = value; }
    }

    private static ComRt2Hmi _comRt2Hmi = new ComRt2Hmi();
    public ComRt2Hmi comRt2Hmi
    {
      get {
        return V._comRt2Hmi;
      }
      set {
        V._comRt2Hmi = value;
      }
    }

    private static ComRt2Plc _comRt2Plc = new ComRt2Plc();
    public ComRt2Plc comRt2Plc
    {
      get {
        return V._comRt2Plc;
      }
      set {
        V._comRt2Plc = value;
      }
    }

    private static ComAcs2Hmi _comAcs2Hmi = new ComAcs2Hmi();
    public ComAcs2Hmi comAcs2Hmi
    {
      get
      {
        return V._comAcs2Hmi;
      }
      set
      {
        V._comAcs2Hmi = value;
      }
    }

    private static ComHmi2Acs _comHmi2Acs = new ComHmi2Acs();
    public ComHmi2Acs comHmi2Acs
    {
      get
      {
        return V._comHmi2Acs;
      }
      set
      {
        V._comHmi2Acs = value;
      }
    }

    public static string user;
    public static string mezzo;
    public static bool initDone = false;

    private enum confCheck
    {
      aiQuantita = 1,
      aiNomi,
      aoQuantita,
      aoNomi,
      pidNullQuant,
      pidNomi,
      comPar
    };

    public void init()
    {
      int t;

      for (t = 0; t < Io.We.Length; t++)
      {
        Io.We[t] = new BitInt();
        Io.We[t].W = "io.we" + t;
      }

      Io.We[0].BitNick = DEF.we0Nick;
      Io.We[1].BitNick = DEF.we1Nick;
      Io.We[2].BitNick = DEF.we2Nick;
      Io.We[3].BitNick = DEF.we3Nick;

      Io.We[0].BitDescr = DEF.we0Descr;
      Io.We[1].BitDescr = DEF.we1Descr;
      Io.We[2].BitDescr = DEF.we2Descr;
      Io.We[3].BitDescr = DEF.we3Descr;

      Io.We[0].BitComp = DEF.we0Comp;
      Io.We[1].BitComp = DEF.we1Comp;
      Io.We[2].BitComp = DEF.we2Comp;
      Io.We[3].BitComp = DEF.we3Comp;

      Io.We[0].BitPlc = DEF.we0Plc;
      Io.We[1].BitPlc = DEF.we1Plc;
      Io.We[2].BitPlc = DEF.we2Plc;
      Io.We[3].BitPlc = DEF.we3Plc;



      for (t = 0; t < Io.Wu.Length; t++)
      {
        Io.Wu[t] = new BitInt();
        Io.Wu[t].W = "io.wu" + t;
      }
      Io.Wu[0].BitNick = DEF.wu0Nick;
      Io.Wu[1].BitNick = DEF.wu1Nick;
      Io.Wu[2].BitNick = DEF.wu2Nick;
      Io.Wu[3].BitNick = DEF.wu3Nick;

      Io.Wu[0].BitDescr = DEF.wu0Descr;
      Io.Wu[1].BitDescr = DEF.wu1Descr;
      Io.Wu[2].BitDescr = DEF.wu2Descr;
      Io.Wu[3].BitDescr = DEF.wu3Descr;

      Io.Wu[0].BitComp = DEF.wu0Comp;
      Io.Wu[1].BitComp = DEF.wu1Comp;
      Io.Wu[2].BitComp = DEF.wu2Comp;
      Io.Wu[3].BitComp = DEF.wu3Comp;

      Io.Wu[0].BitPlc = DEF.wu0Plc;
      Io.Wu[1].BitPlc = DEF.wu1Plc;
      Io.Wu[2].BitPlc = DEF.wu2Plc;
      Io.Wu[3].BitPlc = DEF.wu3Plc;

      for (t = 0; t < Io.alarms.Length; t++)
      {
        Io.alarms[t] = new BitInt();
        Io.alarms[t].W = "v.io.wa" + t;
        Io.alarms[t].W = "v.io.alSistema" + t;
      }
      Io.alarms[0].BitNick = DEF.wa0Nick;
      Io.alarms[1].BitNick = DEF.wa1Nick;
      Io.alarms[2].BitNick = DEF.wa2Nick;

      Io.alarms[0].BitDescr = DEF.wa0Descr;
      Io.alarms[1].BitDescr = DEF.wa1Descr;
      Io.alarms[2].BitDescr = DEF.wa2Descr;

      Io.alarms[0].BitComp = DEF.wa0Comp;
      Io.alarms[1].BitComp = DEF.wa1Comp;
      Io.alarms[2].BitComp = DEF.wa2Comp;

      Io.alarms[0].BitPlc = DEF.wa0Plc;
      Io.alarms[1].BitPlc = DEF.wa1Plc;
      Io.alarms[2].BitPlc = DEF.wa2Plc;



      for (t = 0; t < Io.cmdBancoRequest.Length; t++)
      {
        Io.cmdBancoRequest[t] = new BitInt();
        Io.cmdBancoStatus[t] = new BitInt();
        Io.cmdBancoStatusAut[t] = new BitInt();
        Io.cmdBancoStatusMan[t] = new BitInt();
      }

      for (t = 0; t < Io.statiBanco.Length; t++)
      {
        Io.statiBanco[t] = new BitInt();
        Io.statiBanco[t].W = "v.io.statiBanco" + t;
      }


      NoXml.gestBool = new BitInt();
      NoXml.gestBool.W = "gestBool";

      presetSpPid(ref NoXml.h2oPropDp, 0, 5);
      presetSpPid(ref NoXml.h2oPropDpAut, 0, 5);
      presetSpPid(ref NoXml.h2oPropPos, 0, 100);
      presetSpPid(ref NoXml.h2oPropPosAut, 0, 100);

      presetSpPid(ref NoXml.oilPropDp, 0, 5);
      presetSpPid(ref NoXml.oilPropDpAut, 0, 5);
      presetSpPid(ref NoXml.oilPropPos, 0, 100);
      presetSpPid(ref NoXml.oilPropPosAut, 0, 100);
    }
    
    public void presetSpPid(ref setPoint sp, double spMin, double spMax)
    {
      sp = new setPoint();
      sp.SpMax = spMax;
      sp.SpMin = spMin;
    }

    public void initDbAppl()
    {
      int salva = 0;

      // l'operazione di deserializzazione sostituisce gli oggetti inizializzati.
      // dovendo aggiungere oggetti durante lo sviluppo, vanno aggiunti dopo il loadData, va fatto un giro con salvataggio e
      // quindi spostato il loadData alla fine del costruttore, in modo che resti la traccia ma non sovrascriva.
      // 20100614 - le analogiche e i pid godono della propriet� di autorigenerazione. La definizione di un nuovo oggetto
      // o il riordino ne causa la rigenerazione. ATTENZIONE: si perdono tutte le impostazioni
      this.DataAppl.aio = new analIo();
      this.DataAppl.aio.Ai = new List<AnCh>();
      this.DataAppl.aio.Ao = new List<AnChOut>();

      this.loadData((int)V.saveType.Application, 0);
      this.loadData((int)V.saveType.Working, 0);
      this.myLoad?.Invoke((int)V.saveType.Working);


#region controllo AI

              AnCh tempAi;

              if (DataAppl.aio.Ai.Count < DEF.aiChNamesS7.Length)
              {
                salva = (int)confCheck.aiQuantita;
                DataAppl.aio.Ai.Clear();
                for (int n = 0; n < DEF.aiChNamesS7.Length; n++)
                {
                  tempAi = new AnCh();
                  tempAi.Name = DEF.aiChNamesS7[n];
                  tempAi.LabelLong = DEF.aiLabelShortS7[n];
                  tempAi.LabelShort = DEF.aiLabelLongS7[n];
                  tempAi.ChNo = n;
                  tempAi.Tmist = 0;
                  tempAi.Tmast = 100;
                  tempAi.Itmist = 0;
                  tempAi.Itmast = 100;
                  DataAppl.aio.Ai.Add(tempAi);
                }
              }

              //se il canale ha nome diverso, lo riassegno
              for (int p = 0; p < DEF.aiChNamesS7.Length; p++)
              {
                if (DataAppl.aio.Ai[p].Name != DEF.aiChNamesS7[p])
                {
                  salva = (int)confCheck.aiNomi;
                  DataAppl.aio.Ai.Clear();
                  for (int n = 0; n < DEF.aiChNamesS7.Length; n++)
                  {
                    tempAi = new AnCh();
                    tempAi.Name = DEF.aiChNamesS7[n];
                    tempAi.LabelLong = DEF.aiLabelShortS7[n];
                    tempAi.LabelShort = DEF.aiLabelLongS7[n];
                    tempAi.ChNo = n;
                    tempAi.Tmist = 0;
                    tempAi.Tmast = 100;
                    tempAi.Itmist = 0;
                    tempAi.Itmast = 100;
                    DataAppl.aio.Ai.Add(tempAi);
                  }
                  break;
                }
              }

#endregion
//DataAppl.aio.Ao.Clear();

#region controllo AO
      AnChOut tempAo;

      if (DataAppl.aio.Ao.Count < DEF.aoChNamesS7.Length)
      {
        DataAppl.aio.Ao.Clear();
        salva = (int)confCheck.aoQuantita;
        //salva = true;
        for (int n = 0; n < DEF.aoChNamesS7.Length; n++)
        {
          tempAo = new AnChOut();
          tempAo.Name = DEF.aoChNamesS7[n];
          tempAo.LabelLong = DEF.aoLabelShortS7[n];
          tempAo.LabelShort = DEF.aoLabelLongS7[n];
          tempAo.ChNo = n;
          tempAo.Minua = 0;
          tempAo.Maxua = 100;
          tempAo.Isua = 0;
          tempAo.Fsua = 100;
          DataAppl.aio.Ao.Add(tempAo);
        }
      }

      for (int n = 0; n < DEF.aoChNamesS7.Length; n++)
      {
        if (DataAppl.aio.Ao[n].Name != DEF.aoChNamesS7[n])
        {
          DataAppl.aio.Ao.Clear();
          salva = (int)confCheck.aoNomi;
          for (int p = 0; p < DEF.aoChNamesS7.Length; p++)
          {
            tempAo = new AnChOut();
            tempAo.Name = DEF.aoChNamesS7[p];
            tempAo.LabelLong = DEF.aoLabelShortS7[p];
            tempAo.LabelShort = DEF.aoLabelLongS7[p];
            tempAo.ChNo = p;
            tempAo.Minua = 0;
            tempAo.Maxua = 100;
            tempAo.Isua = 0;
            tempAo.Fsua = 100;
            DataAppl.aio.Ao.Add(tempAo);
          }
          break;
        }
      }

#endregion


      //se qualcosa � stato rigenerato, salva il nuovo set di parametri
      if (salva != 0)
      {
        string msg = "Alterazione banco.applicazione - cod. " + salva;
#if CLIENT
          System.Windows.Forms.MessageBox.Show(msg, "VBA Automazioni");
#endif
        saveData((int)V.saveType.Application, 0, true);
      }
    }

    public void initDbConfTest()
    {
      //bool salva = false;

      // l'operazione di deserializzazione sostituisce gli oggetti inizializzati.
      // dovendo aggiungere oggetti durante lo sviluppo, vanno aggiunti dopo il loadData, va fatto un giro con salvataggio e
      // quindi spostato il loadData alla fine del costruttore, in modo che resti la traccia ma non sovrascriva.
      // 20100614 - le analogiche e i pid godono della propriet� di autorigenerazione. La definizione di un nuovo oggetto
      // o il riordino ne causa la rigenerazione. ATTENZIONE: si perdono tutte le impostazioni
      this.dataConfTest.passiProva = new List<PASSO>();

      //okkio: sostituire qui per caricamento ricetta
      this.loadData((int)V.saveType.TestConf, 0);
    }

    public void saveData(object whatSave, int set, bool msgOn)
    {
      int what = (int)whatSave;
      //preparazione e scrittura su database
      MySqlConnection connessioneDB = new MySqlConnection(mainAppParam.strConnDb);

      string comandoSQL = "";
      Type[] tipi = new Type[1];
      tipi[0] = typeof(analIo);


      //salvataggio banco.applicazione
      //=============================
      if (what == (int)V.saveType.Application)
      {
        StringWriter outApp = new StringWriter(new StringBuilder());
        XmlSerializer serApp = new XmlSerializer(typeof(DATA_APPL), tipi);

        serApp.Serialize(outApp, this.DataAppl);
        string appData = outApp.ToString();
        appData = appData.Replace("\"", "\"\"");
        appData = appData.Replace("'", "''");

        comandoSQL = "INSERT INTO confapp " +
          "(caId, caDate, caSetNo, caType, caConfigData, caAuth) VALUES " +
          "(null, NOW(), " + set + ", \"Application\", \"" + appData + "\", \"" + V.user + "\")";
      }

      if (what == (int)V.saveType.User)
      {
        //comandoSQL = "INSERT INTO confapp " +
        //  "(caId, caDate, caSetNo, caType, caConfigData, caAuth) VALUES " +
        //  "(null, NOW(), " + set + ", \"User\", \"" + gbxData + "\", \"" + V.user + "\")";
      }

      //salvataggio banco.applicazione
      //=============================
      if (what == (int)V.saveType.Recipe)
      {
      }

      //salvataggio banco.configurazione prova
      //=============================
      if (what == (int)V.saveType.TestConf)
      {
        Type[] tipiLoc = new Type[3];
        tipiLoc[0] = typeof(ParametroVba);
        tipiLoc[1] = typeof(setPoint);
        tipiLoc[2] = typeof(System.Text.Json.JsonElement);
        
        StringWriter strWriter = new StringWriter(new StringBuilder());
        XmlSerializer xSerizer = new XmlSerializer(typeof(DATA_CONF_TEST), tipiLoc);
        xSerizer.Serialize(strWriter, this.dataConfTest);
        string strData = strWriter.ToString();
        strData = strData.Replace("\"", "\"\"");
        strData = strData.Replace("'", "''");

        comandoSQL = "INSERT INTO confapp " +
          "(caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth) VALUES " +
          "(null, NOW(), " + set +
          ", \"TestConf\",  \"" + strData + "\", \"" + V.user + "\")";
      }

      //salvataggio banco.prova
      //=============================
      if (what == (int)V.saveType.Test)
      {
        StringWriter strWriter = new StringWriter(new StringBuilder());
        XmlSerializer xSerizer = new XmlSerializer(typeof(DATA_TEST));
        xSerizer.Serialize(strWriter, this.dataTest);
        string strData = strWriter.ToString();
        strData = strData.Replace("\"", "\"\"");
        strData = strData.Replace("'", "''");

        comandoSQL = "INSERT INTO confapp " +
          "(caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth) VALUES " +
          "(null, NOW(), " + set +
          ", \"Test\",  \"" + strData + "\", \"" + V.user + "\")";
      }

      //salvataggio variabili di lavoro
      //===============================
      if (what == (int)V.saveType.Working)
      {
        StringWriter strWriter = new StringWriter(new StringBuilder());
        XmlSerializer xSerizer = new XmlSerializer(typeof(DATA_WORK));
        xSerizer.Serialize(strWriter, this.dataWork);
        string strData = strWriter.ToString();
        strData = strData.Replace("\"", "\"\"");
        strData = strData.Replace("'", "''");

        comandoSQL = "INSERT INTO confapp " +
          "(caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth) VALUES " +
          "(null, NOW(), " + set +
          ", \"Work\",  \"" + strData + "\", \"" + V.user + "\")";
      }

      try
      {
        connessioneDB.Open();

        MySqlCommand comandoDB = new MySqlCommand();

        comandoDB.CommandText = comandoSQL;
        comandoDB.Connection = connessioneDB;

        comandoDB.ExecuteNonQuery();

        connessioneDB.Close();
        connessioneDB = null;
#if CLIENT
        if (msgOn) System.Windows.Forms.MessageBox.Show("Salvataggio banco.applicazione", "Salvataggio");
#endif
      }
      catch
      {
#if CLIENT
        System.Windows.Forms.MessageBox.Show("Errore durante il salvataggio configurazione");
#endif
      }
    }

    public int loadData(object what, int set)
    {
      int _what = (int)what;
      V v = new V();
      string settings = "";
      string comandoSQL = "";

      MySqlConnection connessioneDB = new MySqlConnection(mainAppParam.strConnDb);


      if (_what == (int)V.saveType.Application)
      {
        comandoSQL = "SELECT caId, caDate, caSetNo, caType, caEngine, " +
          "caGbx, caConfigData, caAuth FROM confapp " +
          "WHERE caType LIKE \"Application\" and caSetNo = " + set + " ORDER BY caId DESC;";
      }

      if (_what == (int)V.saveType.User)
      {
        comandoSQL = "SELECT caId, caDate, caSetNo, caType, caEngine, " +
          "caGbx, caConfigData, caAuth FROM confapp " +
          "WHERE caType LIKE \"User\" and caSetNo = " + set + " ORDER BY caId DESC;";
      }

      //if (what == (int)V.saveType.Recipe)
      //{
      //  comandoSQL = "SELECT caId, caDate, caSetNo, caType, caEngine, " +
      //    "caGbx, caConfigData, caAuth FROM confapp " +
      //    "WHERE caType LIKE \"Recipe\" and caSetNo = " + set +
      //    " and caEngine like \"" + V.gbxMotore +
      //    "\" and caGbx like \"" + V.gbxTipo + "\" ORDER BY caId DESC;";
      //}

      if (_what == (int)V.saveType.TestConf || _what == (int)V.saveType.TestConf_act)
      {
        comandoSQL = "SELECT " +
          "caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth " +
          "FROM confapp " +
          "WHERE caType LIKE \"TestConf\" and caSetNo = " + set +
          " ORDER BY caId DESC;";
      }

      if (_what == (int)V.saveType.Test)
      {
        comandoSQL = "SELECT " +
          "caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth " +
          "FROM confapp " +
          "WHERE caType LIKE \"Test\" and caSetNo = " + set +
          " ORDER BY caId DESC;";
      }

      //salvataggio variabili di lavoro
      //===============================
      if (_what == (int)V.saveType.Working)
      {
        comandoSQL = "SELECT " +
          "caId, caDate, caSetNo, " +
          "caType, " + //caEngine, caGbx, " +
          "caConfigData, caAuth " +
          "FROM confapp " +
          "WHERE caType LIKE \"Work\" and caSetNo = " + set +
          " ORDER BY caId DESC;";
      }

      connessioneDB.Open();

      MySqlCommand comandoDB = new MySqlCommand();

      comandoDB.CommandText = comandoSQL;
      comandoDB.Connection = connessioneDB;

      MySqlDataReader readerDB = comandoDB.ExecuteReader();

      if (readerDB.Read())
      {
        //if (what == (int)V.saveType.Recipe)
        //{
        //  V.gbxMotore = (string)readerDB["caEngine"];
        //  V.gbxTipo = (string)readerDB["caGbx"];
        //}
        settings = (string)readerDB["caConfigData"];
      }
      readerDB.Close();
      readerDB = null;
      connessioneDB.Close();
      connessioneDB = null;

      TextReader reader = new StringReader(settings);
      try
      {
        if (_what == (int)V.saveType.Application)
        {

          Type[] tipi = new Type[1];
          tipi[0] = typeof(analIo);
          XmlSerializer ser = new XmlSerializer(typeof(DATA_APPL), tipi);
          v.DataAppl = (DATA_APPL)ser.Deserialize(reader);
          if (loaded != null)
            loaded((int)V.saveType.Application);
        }

        if (_what == (int)V.saveType.User)
        {
          //XmlSerializer ser = new XmlSerializer(typeof(GbxData));
          //v.GbD = (GbxData)ser.Deserialize(reader);
          if (loaded != null)
            loaded((int)V.saveType.User);
        }

        if (_what == (int)V.saveType.Recipe)
        {
          //XmlSerializer ser = new XmlSerializer(typeof(GbxData));
          //v.GbD = (GbxData)ser.Deserialize(reader);
          //if (loaded != null)
          //  loaded((int)V.saveType.Recipe);
        }

        if (_what == (int)V.saveType.Test)
        {
          XmlSerializer ser = new XmlSerializer(typeof(DATA_TEST));
          v.dataTest = (DATA_TEST)ser.Deserialize(reader);
          if (loaded != null)
            loaded((int)V.saveType.Test);
        }

        if (_what == (int)V.saveType.TestConf)
        {
          try
          {
            XmlSerializer ser = new XmlSerializer(typeof(DATA_CONF_TEST));
             v.dataConfTest = (DATA_CONF_TEST)ser.Deserialize(reader);
            if (loaded != null)
              loaded((int)V.saveType.TestConf);
          }
          catch (System.InvalidOperationException ex)
          {
            Log.Logger.Error("Variab.cs, 720 - {@ex}", ex);

          }
        }

        //if (_what == (int)V.saveType.TestConf_act)
        //{
        //  XmlSerializer ser = new XmlSerializer(typeof(DATA_CONF_TEST));
        //  v.dataConfTest_act = (DATA_CONF_TEST)ser.Deserialize(reader);
        //  if (loaded != null)
        //    loaded((int)V.saveType.TestConf_act);
        //}

        if (_what == (int)V.saveType.Working)
        {
          XmlSerializer ser = new XmlSerializer(typeof(DATA_WORK));
          v.dataWork = (DATA_WORK)ser.Deserialize(reader);
          if (loaded != null)
            loaded((int)V.saveType.Working);
          //loaded?.Invoke((int)V.saveType.Working);
        }


        v = null;
        reader.Close();
        reader = null;
      }
      catch (Exception ex)
      {
        //resetDataGbx();
        Exception mex = ex;
        if (loaded != null)
          loaded((int)V.saveType.Recipe);
        return -1;
      }
      return 0;
    }
  }


  

}
