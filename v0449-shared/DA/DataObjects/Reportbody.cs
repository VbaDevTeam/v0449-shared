using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{
    public partial class Reportbody
    {
        public int RbId { get; set; }
        public int RbRhId { get; set; }
        public int RbFase { get; set; }
        public double RbGiriMotore { get; set; }
        public double RbGiriPompaMin { get; set; }
        public double RbGiriPompa { get; set; }
        public double RbGiriPompaMax { get; set; }
        public double RbTempFluidoMin { get; set; }
        public double RbTempFluido { get; set; }
        public double RbTempFluidoMax { get; set; }
        public double RbDurata { get; set; }
        public double RbPressAsp { get; set; }
        public double RbPressMan { get; set; }
        public double RbPressDiffMin { get; set; }
        public double RbPressDiff { get; set; }
        public double RbPressDiffMax { get; set; }
        public double RbPortataMin { get; set; }
        public double RbPortata { get; set; }
        public double RbPortataMax { get; set; }
        public double RbAngoloMin { get; set; }
        public double RbAngolo { get; set; }
        public double RbAngoloMax { get; set; }
        public string RbEsito { get; set; }
    }
}
