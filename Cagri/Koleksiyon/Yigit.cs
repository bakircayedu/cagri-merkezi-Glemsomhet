using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri.Koleksiyon
{
    internal class Yigit
    {
        int Bas;          // Yığıtın en üstündeki öğenin indisi
        object[] _yigit;  // Yığıttaki öğeleri tutan dizi

        private int sayi; // Yığıttaki (korumalı alan) öğe sayısı 
        public int Sayi   // Yığıttaki (salt-okunur özellik) öğe sayısı
        {
            get { return sayi; }
        }

        private int kapasite; // Yığıtın tutabileceği (korumalı) azami öğe sayısı
        public int Kapasite   // Yığıtın tutabileceği (salt-okunur) azami öğe sayısı
        {
            get { return kapasite; }
        }

        /// <summary>
        /// Yığıtın (Stack) boş olup olmadığını kontrol eder.
        /// </summary>
        /// <returns><b>true</b>: yığıt boş, <b>false</b>: yığıt boş değil.</returns>
        public bool Bos()
        {
            return (sayi == 0);
        }

        /// <summary>
        /// Yığıtın dolu olup olmadığını kontrol eder.
        /// </summary>
        /// <returns><b>true</b>: yığıt dolu, <b>false</b>: yığıt dolu değil.</returns>
        public bool Dolu()
        {
            return Sayi == Kapasite;
        }

        /// <summary>
        /// Yığıt (stack) koleksiyonu oluşturur.
        /// </summary>
        /// <param name="kapasite">Yığıtın içerebileceği öğe sayısı</param>
        public Yigit(int kapasite)
        {
            _yigit = new object[kapasite];
            this.kapasite = kapasite;
            Bas = -1;
        }

        /// <summary>
        /// Yığıtın en üstüne bir öğe ekler.
        /// </summary>
        /// <param name="data">Eklenecek öğe</param>
        /// <exception cref="StackOverflowException">Yığıt doldu.</exception>
        public void Push(object data)
        {
            if (Sayi >= Kapasite)
                throw new StackOverflowException("Yığıt dolu.");
            else
            {
                _yigit[++Bas] = data;
                sayi++;
            }

        }

        /// <summary>
        /// Yığıtın en üsütündeki öğeyi siler.
        /// </summary>
        /// <returns>Yığıtın en üstündeki öğe</returns>
        /// <exception cref="IndexOutOfRangeException">Yığıt zaten boş.</exception>
        public object Pop()
        {
            if (Sayi <= 0)
                throw new IndexOutOfRangeException("Yığıt boş.");
            else
            {
                sayi--;
                return _yigit[Bas--];
            }
        }

        /// <summary>
        /// Yığıtın en üstünde işlem için bekleyen öğeyi silmeden döndürür.
        /// </summary>
        /// <returns>Yığıtın en üstünde işlem için bekleyen öğeyi döndürür.</returns>
        /// <exception cref="IndexOutOfRangeException">Yığıt zaten boş.</exception>
        public object Peek()
        {
            if (Sayi <= 0)
                throw new IndexOutOfRangeException("Yığıt boş.");
            else
                return _yigit[Bas];
        }

        /// <summary>
        /// Yığıtı küçükten büyüğe doğru sıralar.
        /// </summary>
        public void Sirala()
        {
            Siralama.Quick_Sort(_yigit, 0, Bas);
        }

        /// <summary>
        /// Yığıttaki öğelerin sırasını ters düz eder.
        /// </summary>
        public void Ters()
        {
            int yari = Sayi / 2;
            object gecici;
            for (int i = 0; i <= Bas; i++)
            {
                gecici = _yigit[i];
                _yigit[i] = _yigit[Bas - i];
                _yigit[Bas - i] = gecici;
            }
        }

        /// <summary>
        /// Yığıttaki tüm öğeleri foreach ile yazdırabilmek için bir liste olarak döndürür.
        /// </summary>
        /// <returns>Yığıttaki öğelerden oluşan bir liste dödürür.</returns>
        public IEnumerable<object> TumunuAl()
        {
            var liste = new List<object>();
            for (int i = Bas; i >= 0; i++)
                liste.Add(_yigit[i]);
            return liste;
        }
    }
}

