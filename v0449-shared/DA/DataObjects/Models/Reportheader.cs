using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{
    public partial class Reportheader
    {
        public int RhId { get; set; }
        public int RhCdId { get; set; }
        public int RhCdCaSetNo { get; set; }
        public int RhCodiceUtente { get; set; }
        public int RhState { get; set; }
        public string RhNomeProva { get; set; }
        public string RhSerialiItems { get; set; }
        public DateTime RhDate { get; set; }
    }
}
