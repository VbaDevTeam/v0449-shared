using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using v0449_shared;

namespace v0449_shared
{
  class dbGeneric
  {
    Context dataContext = new Context();
    public V v = new();

    public enum dbDlCn
    {
      dlId
      , dlTimeSt
      , dlPrIn
      , dlPrOut
      , dlTFlIn
      , dlTflOut
      , dlTcella
      , dlRhCella
      , dlQFl
      , dlNote
    };

    public List<Tblcodicidisegni> loadDisegni()
    {
      List<Tblcodicidisegni> pippo = dataContext.Tblcodicidisegnis.ToList().Where(en => en.CdValid == true).ToList();
      return pippo;
    }

    public List<Datalog> loadDataChTest()
    {
      DateTime start = DateTime.Now.AddHours(-3);
      return dataContext.Datalogs.ToList().Where(en => en.DlTimeSt > start).OrderBy(en => en.DlId).ToList();
    }

    public int deleteCodDisegno(int id)
    {
      (from p in dataContext.Tblcodicidisegnis
       where p.CdId == id
       select p).ToList().ForEach(x => x.CdValid = false);
      return dataContext.SaveChanges();
    }

    public int insertDisegno_old(string codice, string descrizione)
    {
      int result = 1;

      //preparazione e scrittura su database
      MySqlConnection connessioneDB = new MySqlConnection(DEF.strConnDb);

      string comandoSQL = "";
      comandoSQL = "INSERT INTO tblCodiciDisegni " +
         "(cdName, cdDescr) VALUES " +
         "('" + codice +
         "', '" + descrizione + "')";


      connessioneDB.Open();

      MySqlCommand comandoDB = new MySqlCommand();

      comandoDB.CommandText = comandoSQL;
      comandoDB.Connection = connessioneDB;
      comandoDB.ExecuteNonQuery();
      //if (comandoDB.ExecuteNonQuery() != 0)
      //  result = -1;

      connessioneDB.Close();
      connessioneDB = null;


      return result;
    }

    public int insertDisegno(string codice, string descrizione)
    {
      Tblcodicidisegni tDisegni = new Tblcodicidisegni();
      tDisegni.CdName = codice;
      tDisegni.CdDescr = descrizione;
      tDisegni.CdValid = true;
      dataContext.Add(tDisegni);
      return dataContext.SaveChanges();
    }

    public int duplicateDisegno(int whatGet)
    {
      int result = 1;
      //preparazione e scrittura su database
      MySqlConnection connessioneDB = new MySqlConnection(DEF.strConnDb);

      string comandoSQL = "call duplicateTestConf" +
         "(" + whatGet + ")";


      connessioneDB.Open();

      MySqlCommand comandoDB = new MySqlCommand();

      comandoDB.CommandText = comandoSQL;
      comandoDB.Connection = connessioneDB;
      comandoDB.ExecuteNonQuery();
      //if (comandoDB.ExecuteNonQuery() != 0)
      //  result = -1;

      connessioneDB.Close();
      connessioneDB = null;


      return result;
    }

    public int botLog(string chatId, string fName, string lName, string request)
    {
      int result = 1;
      //preparazione e scrittura su database
      MySqlConnection connessioneDB = new MySqlConnection(DEF.strConnDb);
      if (request.Length > 44) request = request.Substring(0, 44);
      string comandoSQL = "";
      comandoSQL = "INSERT INTO tblBotLog " +
         "(blChatId, blFirstName, blLastName, blRequest) VALUES " +
         "('" + chatId +
         "', '" + fName +
         "', '" + lName +
         "', '" + request + "')";

      connessioneDB.Open();

      MySqlCommand comandoDB = new MySqlCommand();

      comandoDB.CommandText = comandoSQL;
      comandoDB.Connection = connessioneDB;
      try
      {
        comandoDB.ExecuteNonQuery();
      }
      catch
      {

      }
      //if (comandoDB.ExecuteNonQuery() != 0)
      //  result = -1;

      connessioneDB.Close();
      connessioneDB = null;


      return result;
    }


  }
}
