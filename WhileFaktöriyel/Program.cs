using System;

namespace WhileFaktöriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı Girin:");
            double sayi = Convert.ToInt32(Console.ReadLine());
            double faktoriyel = 1;
            int i = 1;

            while (i <= sayi)
            {
                faktoriyel = faktoriyel * i;
                i++;
            }
            Console.WriteLine("{0} sayısının faktöriyeli={1}", sayi, faktoriyel);
            Console.ReadKey();
        }
    }
}
