using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Vallade
{
    class Produit
    {
        public string designation { get; set; }
        public int quantité { get; set; }
        public decimal prix_unitaire_ht { get; set; }
        public int stock { get; set; }

        public static List<string> Champs = new List<string>() { "designation", "quantite" };


    }
}
