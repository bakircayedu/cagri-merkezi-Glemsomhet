using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri.Model
{
    internal class CagriKaydi
    {
        public int Id { get; set; }
        public CagriTuru Tur { get; set; }
        public int MusteriId { get; set; }
        public string Not { get; set; }
        public DateTime AtamaZaman { get; set; }
        public int TemsilciId { get; set; }
        public DateTime BaslamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
