using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Vallade
{
    class Commande
    {
        public DateTime date_livraison { get; set; }
        public DateTime date_commmande { get; set; }
        public float total_ht  { get; set; }
        public static List<string> Champs = new List<string>() { "date_livraison", "date_commande" };
    }
}
