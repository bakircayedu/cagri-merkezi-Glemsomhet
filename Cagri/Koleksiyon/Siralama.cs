namespace Cagri.Koleksiyon
{
    internal static class Siralama
    {
        public static void Quick_Sort(object[] dizi, int sol, int sag)
        {
            if (sol < sag)
            {
                int pivot = Partition(dizi, sol, sag);

                if (pivot > 1)
                {
                    Quick_Sort(dizi, sol, pivot - 1);
                }
                if (pivot + 1 < sag)
                {
                    Quick_Sort(dizi, pivot + 1, sag);
                }
            }

        }

        private static int Partition(object[] dizi, int sol, int sag)
        {
            int pivot = dizi[sol].GetHashCode();
            while (true)
            {

                while (dizi[sol].GetHashCode() < pivot)
                {
                    sol++;
                }

                while (dizi[sag].GetHashCode() > pivot)
                {
                    sag--;
                }

                if (sol < sag)
                {
                    if (dizi[sol] == dizi[sag]) return sag;

                    object temp = dizi[sol];
                    dizi[sol] = dizi[sag];
                    dizi[sag] = temp;
                }
                else
                {
                    return sag;
                }
            }
        }
    }
}
