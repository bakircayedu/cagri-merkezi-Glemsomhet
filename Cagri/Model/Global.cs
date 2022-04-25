using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cagri.Koleksiyon;

namespace Cagri.Model
{
    internal class Global
    {
        public static Musteri AktifMusteri = new Musteri();
        public static DateTime AramaZamani = new DateTime();

        public static Kuyruk Cagrilar = new Kuyruk(1000);
        public static Kuyruk Bekleyen = new Kuyruk(100);

        public static Kuyruk Musteriler = new Kuyruk(100);
        public static int CagriSayisi = 0;

        public static Kuyruk kuyrukBireysel1 = new Kuyruk(20);
        public static Kuyruk kuyrukBireysel2 = new Kuyruk(20);

        public static Kuyruk kuyrukTicari1 = new Kuyruk(20);
        public static Kuyruk kuyrukTicari2 = new Kuyruk(20);

    }
}
