using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Vallade
{
    class Vendeur
    {
        public string nom { get; set; }
        public string telephone { get; set; }
        private static List<string> Champs = new List<string>() { "Nom", "telephone" };

    }
}
