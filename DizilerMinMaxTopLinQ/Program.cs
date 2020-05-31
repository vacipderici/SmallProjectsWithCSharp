using System;
using System.Linq;

namespace DizilerMinMaxTopLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam;
            int min, max;
            Random rnd = new Random();

            Console.WriteLine("Lütfen dizinizin boyutunu giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[boyut];
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                sayiDizisi[i] = rnd.Next(10, 100);
            }
            Console.WriteLine($"Toplam={sayiDizisi.Sum()}Ortalama:{sayiDizisi.Average()}");
            Console.WriteLine($"Minimum={sayiDizisi.Min()}Ortalama:{sayiDizisi.Max()}");

            Console.ReadKey();
        }
    }
}
