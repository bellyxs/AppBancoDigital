using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class ChavePix
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string chave { get; set; }
        public int id_conta { get; set; }
    }
}
