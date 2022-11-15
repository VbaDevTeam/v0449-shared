using System;
using System.Collections.Generic;
using System.Text;

namespace v0449_shared.CL.DEF
{
  public class wBitInt
  {
    //tipi ammissibili di word
    public enum types
    {
      We,
      Wu,
      Wa,
      fl
    }

    //tipo specifico a runtime
    public int type;

    //numero identificativo word
    public int no;

    //nome word
    public string name;

    //descrizione word
    public string descr;

    public lBitInt[] fields;

    public wBitInt(int type, int no, string name, string descr, lBitInt[] fields)
    {
      this.type = type;
      this.no = no;
      this.name = name;
      this.descr = descr;
      this.fields = fields;
    }

  }

  public class lBitInt
  {
    public int ndx;
    public string nick;
    public string sDescr;
    public string lDescr = "";
    public string plcDescr = "";
    public string compDescr = "";

    public lBitInt(int ndx, string nick, string sDescr, string lDescr, string plcDescr, string compDescr)
    {
      this.ndx = ndx;
      this.nick = nick;
      this.sDescr = sDescr;
      this.lDescr = lDescr;
      this.plcDescr = plcDescr;
      this.compDescr = compDescr;

    }

    public lBitInt(int ndx, string nick, string sDescr)
    {
      this.ndx = ndx;
      this.nick = nick;
      this.sDescr = sDescr;
    }

  }
}
