using System;
using System.Collections.Generic;
using System.Text;

namespace v0449_shared.CL.DEF
{
  internal class rights
  {
    #region DIRITTI

    public static string[] dirittiLabel =
    {
      "login      "
      ,"logoff  "
      ,"esci          "
      ,"gest. utenti  "
      ,"report        "
      ,"manutenzione  "
      ,"test"
    };

    public enum dirittiVal
    {
      Login = 0x0001,
      Logoff = 0x0002,
      Esci = 0x0004,
      GesUtenti = 0x0008,
      Report = 0x0010,
      Manutenzione = 0x0020,
      Test = 0x0040,
    }
    #endregion

  }
}
