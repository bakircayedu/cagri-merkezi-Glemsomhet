using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri.Gorunum
{
    /*
    // İki uçlu kuyruk: Kuyruk + Yığıt
    public class Deque : ICollection, IEnumerable, ICloneable
    {
        // Kuyruğun başı
        private Node Bas = null;

        // Kuyruğun sonu
        private Node Son = null;

        // Kuyruktaki öğe sayısı
        private int sayi;

        public int Sayi
        {
            get { return sayi; }
        }

        /// <summary>
        /// Deque nesnesi oluşturur.
        /// </summary>
        public Deque()
        {
            sayi = 0;
        }

        /// <summary>
        /// Argüman olarak gelen listeyi kopyalayarak Deque nesnesi oluşturur. 
        /// </summary>
        /// <param name="liste">
        /// Deque'e kopyalanacak ICollection türünden liste.
        /// </param>
        public Deque(ICollection liste)
        {
            if (liste == null)
                throw new ArgumentNullException("Liste boş.");
            foreach (object obj in liste)
                SonaEkle(obj);
        }

        /// <summary>
        /// Deque'teki tüm öğeleri siler.
        /// </summary>
        public virtual void Clear()
        {
            sayi = 0;
            Bas = Son = null;
            Denetle();
        }

        /// <summary>
        /// Deque içinde bir nesnenin olup olmadığını belirler.
        /// </summary>
        /// <param name="oge">Aranan öğe</param>
        /// <returns>
        /// <b>true</b>: <i>oge</i> Deque içinde var; <b>false</b>: <i>oge</i> Deque içinde yok.
        /// </returns>
        public virtual bool Contains(object oge)
        {
            foreach (object o in this)
            {
                if (o == null && oge == null)
                {
                    return true;
                }
                else if (o.Equals(oge))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Inserts an object at the front of the Deque.
        /// </summary>
        /// <param name="oge">
        /// The object to push onto the deque;
        /// </param>
        public void PushFront(object oge)
        {
            // The new node to add to the front of the deque.
            Node yeniDugum = new Node(oge);

            // Link the new node to the front node. The current front node at 
            // the front of the deque is now the second node in the deque.
            yeniDugum.Next = Bas;

            // If the deque isn't empty.
            if (Sayi > 0)
            {
                // Link the current front to the new node.
                Bas.Previous = yeniDugum;
            }

            // Make the new node the front of the deque.
            Bas = yeniDugum;

            // Keep track of the number of elements in the deque.
            sayi++;

            // If this is the first element in the deque.
            if (Sayi == 1)
            {
                // The front and back nodes are the same.
                Son = Bas;
            }
            Denetle();
        }

        /// <summary>
        /// Deque'in sonuna yeni bir öğe ekler
        /// </summary>
        /// <param name="oge">Deque'e push edilecek nesne</param>
        public virtual void SonaEkle(object oge)
        {
            // DequE2in sonuna eklemek üzere yeni düğümü oluştur.
            Node yeniDugum = new Node(oge);

            // Yeni düğümü, son düğüme bağla. En son düğüm artık sondan ikinci düğümdür.
            yeniDugum.Previous = Son;

            // Deque boş değilse,
            if (Sayi > 0)
                Son.Next = yeniDugum; // şimdiki düğümü yeni düğüme bağla.

            // Yeni düüğümü Deque'in sonuna ekle
            Son = yeniDugum;

            // Deque'teki öğe sayısını artır.
            sayi++;

            // Deque'teki ilk öğe ise
            if (Sayi == 1)
                Bas = Son;// Bas ve Son düğümler aynı.
            Denetle();
        }

        /// <summary>
        /// Deque'in en baştaki öğesini döndürür ve siler.
        /// </summary>
        /// <returns>Deque'in en önündeki öğeyi döndürür.</returns>
        /// <exception cref="InvalidOperationException">Deque zaten boş.</exception>
        public virtual object BastakiniSil()
        {
            if (Sayi == 0)
                throw new InvalidOperationException("Deque zaten boş.");
            // Deque'in en başındaki öğeyi al.
            object oge = Bas.Value;

            // Sonraki düğümü başa al.
            Bas = Bas.Next;

            // Deque'teki öğe sayısını ayarla.
            sayi--;

            // Deque boş değilse,
            if (Sayi > 0)
                Bas.Previous = null;// Baştaki düğümün önceki bağlantısını kopar.
            // Deque boşsa
            else
                Son = null; // Son düğüm artık yok
            Denetle();
            return oge;
        }

        /// <summary>
        /// Deque'in en sonundaki öğeyi döndürür ve siler.
        /// </summary>
        /// <returns>Deque'in en sonundaki öğe</returns>
        /// <exception cref="InvalidOperationException">
        ///Deque zaten boş.
        /// </exception>
        public virtual object SondakiniSil()
        {
            if (Sayi == 0)
                throw new InvalidOperationException("Deque zaten boş.");
            // Deque'in en sonundaki öğeyi al.
            object oge = Son.Value;

            // Son düğümü bir öncekine taşı.
            Son = Son.Previous;

            // Deque'teki öğe sayısını ayarla.
            sayi--;

            // Deque boş değilse,
            if (Sayi > 0)
                Son.Next = null;// Son düğümün bağlantısını kes.
            // Deque boşsa,.
            else
                Bas = null;// Başta düğüm olmadığını bildir.

            Denetle();
            return oge;
        }

        /// <summary>
        /// Returns the object at the front of the Deque without removing it.
        /// </summary>
        /// <returns>
        /// The object at the front of the Deque.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The Deque is empty.
        /// </exception>
        public virtual object PeekFront()
        {
            #region Require

            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            #endregion

            return Bas.Value;
        }

        /// <summary>
        /// Returns the object at the back of the Deque without removing it.
        /// </summary>
        /// <returns>
        /// The object at the back of the Deque.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// The Deque is empty.
        /// </exception>
        public virtual object PeekBack()
        {
            #region Require

            if (Count == 0)
            {
                throw new InvalidOperationException("Deque is empty.");
            }

            #endregion

            return Son.Value;
        }

        /// <summary>
        /// Copies the Deque to a new array.
        /// </summary>
        /// <returns>
        /// A new array containing copies of the elements of the Deque.
        /// </returns>
        public virtual object[] ToArray()
        {
            object[] array = new object[Count];
            int index = 0;

            foreach (object obj in this)
            {
                array[index] = obj;
                index++;
            }

            return array;
        }

        /// <summary>
        /// Returns a synchronized (thread-safe) wrapper for the Deque.
        /// </summary>
        /// <param name="deque">
        /// The Deque to synchronize.
        /// </param>
        /// <returns>
        /// A synchronized wrapper around the Deque.
        /// </returns>
        public static Deque Synchronized(Deque deque)
        {
            #region Require

            if (deque == null)
            {
                throw new ArgumentNullException("deque");
            }

            #endregion

            return new SynchronizedDeque(deque);
        }

        private void Denetle()
        {
            int n = 0;
            Node simdiki = Bas;

            while (simdiki != null)
            {
                n++;
                simdiki = simdiki.Next;
            }
            if (Sayi > 0)
            {
                Node ileri = Bas;
                Node geri = Son;

                while (ileri.Next != null && geri.Previous != null)
                {
                    ileri = ileri.Next;
                    geri = geri.Previous;
                }
            }
        }
        // Represents a node in the deque.
        [Serializable()]
        private class Node
        {
            private object value;

            private Node previous = null;

            private Node next = null;

            public Node(object value)
            {
                this.value = value;
            }

            public object Value
            {
                get
                {
                    return value;
                }
            }

            public Node Previous
            {
                get
                {
                    return previous;
                }
                set
                {
                    previous = value;
                }
            }

            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
        }

        #region DequeEnumerator Class

        [Serializable()]
        private class DequeEnumerator : IEnumerator
        {
            private Deque owner;

            private Node currentNode;

            private object current = null;

            private bool moveResult = false;

            private long version;

            public DequeEnumerator(Deque owner)
            {
                this.owner = owner;
                currentNode = owner.Bas;
                this.version = owner.version;
            }

            #region IEnumerator Members

            public void Reset()
            {
                #region Require

                if (version != owner.version)
                {
                    throw new InvalidOperationException(
                        "The Deque was modified after the enumerator was created.");
                }

                #endregion

                currentNode = owner.Bas;
                moveResult = false;
            }

            public object Current
            {
                get
                {
                    #region Require

                    if (!moveResult)
                    {
                        throw new InvalidOperationException(
                            "The enumerator is positioned before the first " +
                            "element of the Deque or after the last element.");
                    }

                    #endregion

                    return current;
                }
            }

            public bool MoveNext()
            {
                #region Require

                if (version != owner.version)
                {
                    throw new InvalidOperationException(
                        "The Deque was modified after the enumerator was created.");
                }

                #endregion

                if (currentNode != null)
                {
                    current = currentNode.Value;
                    currentNode = currentNode.Next;

                    moveResult = true;
                }
                else
                {
                    moveResult = false;
                }

                return moveResult;
            }

            #endregion
        }

        #endregion

        #region SynchronizedDeque Class

        // Implements a synchronization wrapper around a deque.
        [Serializable()]
        private class SynchronizedDeque : Deque
        {
            #region SynchronziedDeque Members

            #region Fields

            // The wrapped deque.
            private Deque deque;

            // The object to lock on.
            private object root;

            #endregion

            #region Construction

            public SynchronizedDeque(Deque deque)
            {
                #region Require

                if (deque == null)
                {
                    throw new ArgumentNullException("deque");
                }

                #endregion

                this.deque = deque;
                this.root = deque.SyncRoot;
            }

            #endregion

            #region Methods

            public override void Temizle()
            {
                lock (root)
                {
                    deque.Temizle();
                }
            }

            public override bool Icerir(object obj)
            {
                bool result;

                lock (root)
                {
                    result = deque.Icerir(obj);
                }

                return result;
            }

            public override void PushFront(object obj)
            {
                lock (root)
                {
                    deque.PushFront(obj);
                }
            }

            public override void SonaEkle(object obj)
            {
                lock (root)
                {
                    deque.SonaEkle(obj);
                }
            }

            public override object BastakiniSil()
            {
                object obj;

                lock (root)
                {
                    obj = deque.BastakiniSil();
                }

                return obj;
            }

            public override object SondakiniSil()
            {
                object obj;

                lock (root)
                {
                    obj = deque.SondakiniSil();
                }

                return obj;
            }

            public override object PeekFront()
            {
                object obj;

                lock (root)
                {
                    obj = deque.PeekFront();
                }

                return obj;
            }

            public override object PeekBack()
            {
                object obj;

                lock (root)
                {
                    obj = deque.PeekBack();
                }

                return obj;
            }

            public override object[] ToArray()
            {
                object[] array;

                lock (root)
                {
                    array = deque.ToArray();
                }

                return array;
            }

            public override object Klonla()
            {
                object clone;

                lock (root)
                {
                    clone = deque.Klonla();
                }

                return clone;
            }

            public override void CopyTo(Array array, int index)
            {
                lock (root)
                {
                    deque.CopyTo(array, index);
                }
            }

            public override IEnumerator GetEnumerator()
            {
                IEnumerator e;

                lock (root)
                {
                    e = deque.GetEnumerator();
                }

                return e;
            }

            #endregion

            #region Properties

            public override int Count
            {
                get
                {
                    lock (root)
                    {
                        return deque.Count;
                    }
                }
            }

            public override bool IsSynchronized
            {
                get
                {
                    return true;
                }
            }

            #endregion

            #endregion
        }

        /// <summary>
        /// Gets a value indicating whether access to the Deque is synchronized 
        /// (thread-safe).
        /// </summary>
        public virtual bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the Deque.
        /// </summary>
        public virtual int Count
        {
            get
            {
                return Sayi;
            }
        }

        /// <summary>
        /// Copies the Deque elements to an existing one-dimensional Array, 
        /// starting at the specified array index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional Array that is the destination of the elements 
        /// copied from Deque. The Array must have zero-based indexing. 
        /// </param>
        /// <param name="index">
        /// The zero-based index in array at which copying begins. 
        /// </param>
        public virtual void CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", index,
                    "Index is less than zero.");
            }
            else if (array.Rank > 1)
            {
                throw new ArgumentException("Array is multidimensional.");
            }
            else if (index >= array.Length)
            {
                throw new ArgumentException("Index is equal to or greater " +
                    "than the length of array.");
            }
            else if (Count > array.Length - index)
            {
                throw new ArgumentException(
                    "The number of elements in the source Deque is greater " +
                    "than the available space from index to the end of the " +
                    "destination array.");
            }
            int i = index;

            foreach (object obj in this)
            {
                array.SetValue(obj, i);
                i++;
            }
        }

        /// <summary>
        /// Gets an object that can be used to synchronize access to the Deque.
        /// </summary>
        public virtual object SyncRoot
        {
            get
            {
                return this;
            }
        }

        #endregion
        /// <summary>
        /// Returns an enumerator that can iterate through the Deque.
        /// </summary>
        /// <returns>
        /// An IEnumerator for the Deque.
        /// </returns>
        public IEnumerable GetEnumerator()
        {
            IEnumerator liste;

            lock (Bas)
                liste = deque.GetEnumerator();
            return liste;
        }

        /// <summary>
        /// Deque'in bir kopyasını oluşturur.
        /// </summary>
        /// <returns>Deque'in kpyasını döndürür.</returns>
        public object Clone()
        {
            return new Deque(this);
        }
    }
    */
}

