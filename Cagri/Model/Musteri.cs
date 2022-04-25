namespace Cagri.Model
{
    public class Musteri
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public override string ToString()
        {
            return Id+": "+Ad;
        }

        public static bool operator >(Musteri m1, Musteri m2)
        {
            return (m1.Id > m2.Id);
        }
        public static bool operator <(Musteri m1, Musteri m2)
        {
            return (m1.Id < m2.Id);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

}
