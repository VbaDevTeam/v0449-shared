﻿using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{
    public partial class Reportheader
    {
        public int RhId { get; set; }
        public int RhCdId { get; set; }
        public int RhCodiceUtente { get; set; }
        public string RhNomeUtente { get; set; }
        public int RhSerialeProva { get; set; }
        public string RhNomeProva { get; set; }
        public string RhSerialeMezzo { get; set; }
        public DateTime RhDate { get; set; }
    }
}
