using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{ 

    public partial class Datalog
    {
        public int DlId { get; set; }
    public DateTime? DlTimeSt
    {
      get; set;
    }
    public DateTime? DlTimeStTk
    {
      get; set;
    }

    public int? DlOrd{get; set;}
        public double? DlPrIn { get; set; }
        public double? DlPrOut { get; set; }
        public double? DlTflIn { get; set; }
        public double? DlTflOut { get; set; }
        public double? DlTcella { get; set; }
        public double? DlRhCella { get; set; }
        public double? DlQfl { get; set; }
        public string DlNote { get; set; }
    }
}
