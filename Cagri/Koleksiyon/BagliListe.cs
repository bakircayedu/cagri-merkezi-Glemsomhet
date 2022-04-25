using Cagri.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri.Koleksiyon
{
    /// <summary>
    /// Çift yönlü bağlı liste (doubly lined list) sınıfı.
    /// </summary>
    internal class BagliListe
    {
        /// <summary>
        /// İlk (head) düğüm (node).
        /// </summary>
        public Node Bas { get; set; }

        /// <summary>
        ///  Son (tail) düğüm (node).
        /// </summary>
        public Node Son { get; set; }

        private int sayi;

        public int Sayi
        {
            get { return sayi; }
        }

        /// <summary>
        /// Boş bir bağlı liste kurar.
        /// </summary>
        public BagliListe()
        {
            Bas = Son = null;
        }
        /// <summary>
        /// Bağlı listeden, indis argümanının belirlediği sıradaki elemanı döndüren yöntem.
        /// </summary>
        /// <param name="indis">Bağli listedeki düğümün sıra numarası</param>
        /// <returns>Bağlı listeden indis argümanı ile belirlenen sıradaki düğümü döndürür.</returns>
        private Node Al(int indis)
        {
            Node siradakiDugum = Bas;
            for (int i = 0; i < indis; i++)
            {
                if (siradakiDugum == null)
                    return null;
                siradakiDugum = siradakiDugum.Next;
            }
            return siradakiDugum;
        }

        /// <summary>
        /// Bağlı listenin sonuna bir düğüm ekler.
        /// </summary>
        /// <param name="data">Bağlı listeye eklenecek veri.</param>
        public void SonaEkle(object data)
        {
            if (Bas == null)
            {
                Bas = new Node(data);
                Son = Bas;
            }
            else
            {
                Son.Next = new Node(data);
                Son.Next.Prev = Son;
                Son = Son.Next;
            }
            sayi++;
        }

        /// <summary>
        /// Bağlı listenin indisleyicisi.
        /// </summary>
        /// <param name="indis">Bağlı listedeki düğümün sıra numarası</param>
        /// <returns>Bağlı listede indis argümanı ile belirlenen düğümü döndürür.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Düğümün indisi sınırlar içerisinde değil.</exception>
        public object this[int indis]
        {
            get
            {
                var node = Al(indis);
                if (node == null)
                    throw new ArgumentOutOfRangeException();
                return node.Data;
            }
            set
            {
                var node = Al(indis);
                if (node == null)
                    throw new ArgumentOutOfRangeException();
                node.Data = value;
            }
        }

        /// <summary>
        /// Bağlı listeden argüman olarak gönderilen sıradaki düğümü siler.
        /// </summary>
        /// <param name="indis">Bağlı listeden silinecek düğümün sıra numarası</param>
        public void Sil(int indis)
        {
            if (Bas == null)
                throw new ArgumentOutOfRangeException("Bağlı listede hiç düğüm yok.");
            else if (indis == 0)
            { // Bas siliniyor.
                if (sayi == 1)
                { // Listedeki tek düğüm ise
                    Bas = Son = null;
                    sayi--; ;
                    return;
                }
                else
                {
                    Bas = Bas.Next;
                    Bas.Prev=null;
                    sayi--;
                }
            }
            else if (indis >= sayi) // İndis sınırların dışında ise 
                throw new ArgumentOutOfRangeException("İndis sınırların dışında.");
            else
            {   
                Node gecici = Bas;
                for (int i = 0; i < indis - 1; i++)
                {
                    gecici = gecici.Next; // Silinecek düğüme kadar ilerle.  
                }
                gecici.Next = gecici.Next.Next; // Belirlenen düğümü sil  
                gecici.Next.Prev = gecici;
                sayi--;
            }   
        }

        /// <summary>
        /// Bağlı listeyi tersine çevirir.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Liste boş.</exception>
        public void Ters()
        {
            if (Bas == null)
                throw new ArgumentOutOfRangeException("Bağlı listede hiç düğüm yok.");
            else
            {
                Node simdiki = Bas;
                Node sonraki = null;
                Node onceki = null;

                while (simdiki != null)
                {
                    sonraki = simdiki.Next;
                    simdiki.Next = onceki;
                    onceki = simdiki;
                    simdiki = sonraki;
                }
                Bas = onceki;
            }
        }

        /// <summary>
        /// Bağlı listede bir verinin listedeki sıra numarasını döndüren yöntem.
        /// </summary>
        /// <param name="data">Aranan veri</param>
        /// <returns><b>-1</b>: Veri bağlı listede bulunmuyor; <b>>=0</b>: Verinin listedeki konumu</returns>
        /// <exception cref="ArgumentOutOfRangeException">Liste boş.</exception>
        int Bul(object data)
        {
            if (Bas == null)
                throw new ArgumentOutOfRangeException("Bağlı listede hiç düğüm yok.");
            else
            {
                Node gecici = Bas;
                for (int i = 0; i < sayi; i++)
                {
                    if (gecici.Data == data)
                        return i;
                    gecici = gecici.Next;
                }
                return -1; // Veri listede yok.
            }
        }

        /// <summary>
        /// Bağlı listede belirtilen bir yere bir düğüm ekler.
        /// </summary>
        /// <param name="data">Eklenecek veri</param>
        /// <param name="yer">Eklemenin yapılacağı konum</param>
        /// <exception cref="ArgumentOutOfRangeException">İndis sınırların dışında.</exception>
        public void Ekle(object data, int yer)
        {

            //create blank node   
            var node = new Node(data);

            if (Bas == null && yer >0)
                throw new ArgumentOutOfRangeException("Bağlı listede hiç düğüm yok.");
            else if (yer == 0)
            {
                node.Next=Bas;
                node.Prev=null;
                Bas.Prev=node;
                Bas = node;

            }
            else if (yer >= Sayi)
                throw new ArgumentOutOfRangeException("İndis sınırların dışında.");
            else
            {
                Node gecici = Bas;
                int indis = 0;
                while (indis < yer - 1)
                {
                    gecici = gecici.Next;
                    indis++;
                }  
                node.Next=gecici.Next;
                node.Prev=gecici;
                gecici.Next=node;
                node.Next.Prev=node;
            }
            sayi++;
        } 

        /// <summary>
        /// Bağlı listeyi küçükten büyüğe doğru sıralar.
        /// </summary>
        public void Sirala()
        {
            Node gecici = Bas;
            Node ilk = null;
            object val = null;
            while (gecici != null)
            {
                ilk = gecici.Next;
                while (ilk != null)
                {
                    if (gecici.Data.GetHashCode() > ilk.Data.GetHashCode())
                    {
                        val = ilk.Data;
                        ilk.Data = gecici.Data;
                        gecici.Data  = val;
                    }
                    ilk = ilk.Next;
                }
                gecici = gecici.Next;

            }
        }
    }
}
