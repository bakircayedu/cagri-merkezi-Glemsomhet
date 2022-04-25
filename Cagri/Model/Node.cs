namespace Cagri.Model
{
    /// <summary>
    /// Bağlı liste, yığıt veya kuyruk koleksiyonlarında kullanılacak düğüm sınıfı.
    /// </summary>
    internal class Node
    {

        public object Data;
        public Node Next;
        public Node Prev;

        /// <summary>
        /// Node (düğüm) oluşturur.
        /// </summary>
        /// <param name="data">Düğümde saklanacak veri, her türlü veri türünü kapsayabilmesi için object tipinde</param>
        public Node(object data)
        {
            Data = data;
        }

        /// <summary>
        /// Node (düğüm) içinde saklanan veriyi metne dönüştürür.
        /// </summary>
        /// <returns>Data üyesinin içerdiği metni döndürür.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
