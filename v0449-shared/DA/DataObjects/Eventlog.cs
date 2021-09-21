using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{
    public partial class Eventlog
    {
        public int EventId { get; set; }
        public string TipoEvento { get; set; }
        public byte Attivazione { get; set; }
        public DateTime IstanteEvento { get; set; }
        public int CodiceEvento { get; set; }
        public string DescrEvento { get; set; }
        public string Info { get; set; }
    }
}
