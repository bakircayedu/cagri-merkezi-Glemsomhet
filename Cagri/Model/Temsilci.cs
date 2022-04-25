using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri.Model
{
    internal class Temsilci
    {
        public int Id { get; set; }
        public CagriTuru Tur { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return "" + Id + " " + Ad + " (" + Tur + ")";
        }
        public static List<Temsilci> Listele() 
        {
            var liste = new List<Temsilci>();
            liste.Add(new Temsilci() { Id = 1, Tur = CagriTuru.Bireysel, Ad = "Ali" });
            liste.Add(new Temsilci() { Id = 2, Tur = CagriTuru.Bireysel, Ad = "Ayşe" });
            liste.Add(new Temsilci() { Id = 3, Tur = CagriTuru.Ticari, Ad = "Can" });
            liste.Add(new Temsilci() { Id = 4, Tur = CagriTuru.Ticari, Ad = "Canan" });
            return liste;
        }
    }
}
