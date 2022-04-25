using System;
using System.Collections;
using System.Collections.Generic;

namespace Cagri.Koleksiyon
{
    internal class Kuyruk : IEnumerable
    {
        internal int Bas;  // Kuyruğun ilk öğesinin indisi
        internal int Son;  // Kuyruğun son öğesinin indisi

        private int sayi;  // Kuyruğun korunan öğe sayısı
        public int Sayi    // Kuyruğun salt okunur öğe sayısı
        {
            get { return sayi; }
        }

        internal int Kapasite; // Kuyruğun tutabileceği öğe sayısı

        internal object[] _kuyruk; // Kuyruk elemanlarını tutan dizi

        /// <summary>
        /// Kuyruk (Queue) ilk ayarlamalarını yapar.
        /// </summary>
        /// <param name="kapasite">Kuyruğun kapasitesi, tutabileceği öğe sayısı</param>
        public Kuyruk(int kapasite)
        {
            this.Kapasite = kapasite;
            Bas = sayi = 0;
            Son = kapasite - 1;
            _kuyruk = new object[kapasite];
        }

        /// <summary>
        /// Kuyruğun dolu olup olmadığını bildirir.
        /// </summary>
        /// <returns><b>true</b>: kuyruk dolu, <b>false</b>: kuyruk henüz dolmadı.</returns>
        public bool Dolu()
        {
            return Sayi == Kapasite;
        }

        /// <summary>
        /// Kuyruğun boş olup olmadığını kontrol eder.
        /// </summary>
        /// <returns><b>true</b>: kuyruk henüz boş, <b>false</b>: kuyruk boş değil.</returns>
        public bool Bos()
        {
            return (Sayi == 0);
        }

        // Method to add an item to the queue. We will add items from rear of Queue.
        // It changes rear and size

        /// <summary>
        /// Kyruğun sırasına yeni bir öğe ekler.
        /// </summary>
        /// <param name="kuyruk"></param>
        /// <param name="oge"></param>
        /// <exception cref="StackOverflowException"></exception>
        public void EnQueue(object oge)
        {
            if (Dolu())
                throw new StackOverflowException("Kuyruk dolu.");
            Son = (Son + 1) % Kapasite;
            _kuyruk[Son] = oge;
            sayi++;
        }

        /// <summary>
        /// Kuyruktan sıradaki öğeyi döndürür ve siler.
        /// </summary>
        /// <exception cref="StackOverflowException"></exception>
        public object DeQueue()
        {
            if (Bos())
                throw new StackOverflowException("Kuyruk zaten boş.");

            object oge = _kuyruk[Bas];
            Bas = (Bas + 1) % Kapasite;
            sayi--;
            return oge;
        }

        /// <summary>
        /// Bir öğenin kuyruktaki yerini bulur.
        /// </summary>
        /// <param name="oge">Kuyrukta aranacak öğe</param>
        /// <returns><b>-1</b>: öğe kuyrukta yok, <b>>=0</b>: öğenin kuyruktaki yeri</returns>
        public int Bul(object oge)
        {
            int yer = -1;
            for (int i = 0; i < sayi; i++)
            {
                if (oge.GetHashCode() == _kuyruk[(Bas + i) % Kapasite].GetHashCode())
                {
                    yer = (Bas + i) % Kapasite;
                    break;
                }
            }
            return yer;
        }

        /// <summary>
        /// Bir öğeyi kuyruğun en öüne ekler.
        /// </summary>
        /// <param name="oge">Eklenecek öğe</param>
        public void OneEkle(object oge)
        {
            int yer = Bul(oge);
            if (yer >= 0)
            {
                object gecici = _kuyruk[Bas];
                _kuyruk[Bas] = _kuyruk[yer];
                _kuyruk[yer] = gecici;
            }
            else
            {
                Bas = (Kapasite + Bas - 1) % Kapasite;
                _kuyruk[Bas] = oge;
                sayi++;
            }
        }

        /// <summary>
        /// Sıradaki öğeyi döndürür.
        /// </summary>
        /// <returns>Sıradaki öğe veya null (kuyruk boşsa)</returns>
        public object Peek()
        {
            if (Bos())
                return null;
            return _kuyruk[Bas];
        }

        /// <summary>
        /// Kuyruğun en sonundaki öğeyi döndürür.
        /// </summary>
        /// <returns>Kuyruğun sonundaki öğe veya null (kuyruk boşsa)</returns>
        public object Sonuncu()
        {
            if (Bos())
                return null;
            return _kuyruk[Son];
        }

        /// <summary>
        /// Kuyruktaki öğeleri küçükten büyüğe doğru sıralar.
        /// </summary>
        public void Sirala() // Seçerek sıralama
        {
            int yer = 0;
            for (int i = 0; i < sayi - 1; i++)
            {
                yer = (Bas + i) % Kapasite;
                for (int j = i + 1; j < sayi; j++)
                {
                    if (_kuyruk[yer].GetHashCode() > _kuyruk[(Bas + j) % Kapasite].GetHashCode())
                        yer = (Bas + j) % Kapasite;
                }
                object gecici = _kuyruk[yer];
                _kuyruk[yer] = _kuyruk[(Bas + i) % Kapasite];
                _kuyruk[(Bas + i) % Kapasite] = gecici;
            }
        }

        /// <summary>
        /// Dizi öğelerini ters cevirir.
        /// </summary>
        public void Ters()
        {
            int yari = sayi / 2;
            object gecici;
            for (int i = 0; i < yari; i++)
            {
                gecici = _kuyruk[(Bas + i) % Kapasite];
                _kuyruk[(Bas + i) % Kapasite] = _kuyruk[(Kapasite + Son - i) % Kapasite];
                _kuyruk[(Kapasite + Son - i) % Kapasite] = gecici;
            }
        }

        public object Al(int indis) { return _kuyruk[(Bas + indis) % Kapasite]; }
        public object this[int indis]
        {
            get
            {
                var oge = Al(indis);
                if (oge == null)
                    throw new ArgumentOutOfRangeException();
                return oge;
            }
            set
            {
                var oge = Al(indis);
                if (oge == null)
                    throw new ArgumentOutOfRangeException();
                oge = value;
            }
        }

        /// <summary>
        /// Kuyruktaki öğeleri bir listeye döndürür.
        /// </summary>
        /// <returns>IEnumerable sınıfından kuyruktaki tüm öğelerin listesi</returns>
        public List<object> TumunuAl()
        {
            var liste = new List<object>();
            for (int i = Bas; i <= Son; i++)
                liste.Add(_kuyruk[i]);
            return liste;
        }

        /// <summary>
        /// Kuyruktaki öğeleri foreach ile yazdırılabilecek bir listeye döndürür.
        /// </summary>
        /// <returns>IEnumerable sınıfından kuyruktaki tüm öğelerin listesi</returns>
        public IEnumerator GetEnumerator()
        {
            /*
            var liste = new List<object>();
            for (int i = Bas; i <= Son; i++)
                liste.Add(_kuyruk[i]);
            return liste;
            */
            return new KuyrukEnum(_kuyruk);
        }
    }

    public class KuyrukEnum : IEnumerator
    {
        public object[] _kuyruk;

        int position = -1;

        public KuyrukEnum(object[] list)
        {
            _kuyruk = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _kuyruk.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _kuyruk[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}