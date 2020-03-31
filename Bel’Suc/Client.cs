using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Vallade
{
    class Client
    {
        public int code_c { get; set; }
        public string nom { get; set; }
        public string Adresse { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string telephone { get; set; }
       
        public static List<string> Champs = new List<string>() { "Nom", "telephone" };
        
        
    }
}
