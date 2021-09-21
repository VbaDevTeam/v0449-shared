using System;
using System.Collections.Generic;

#nullable disable

namespace v0449_shared
{
    public partial class Utenti
    {
        public int CodiceUtente { get; set; }
        public string UserName { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string EMail { get; set; }
        public int Amministratore { get; set; }
        public int Diritti { get; set; }
        public string Password { get; set; }
    }
}
