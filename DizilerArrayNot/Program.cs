using System;
using System.Collections;

namespace DizilerArrayNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int ortalama = 0;

            Console.WriteLine("Bakmak istediğiniz kaç tane not var");
            int kacNot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 ile 100 arasında bir sayı giriniz");

            ArrayList notlar = new ArrayList();

            for (int i = 0; i < kacNot; i++)
            {
                Console.WriteLine($"Aldıgınız {i + 1}.notu yazınız:");
                notlar.Add(Console.ReadLine());
            }
            for (int j = 1; j < notlar.Count; j++)
            {
                sayac += Convert.ToInt32(notlar[j]);
            }
          
            ortalama = sayac / (notlar.Count - 1);
            Console.WriteLine("Not ortalamanız:" + ortalama);
            Console.WriteLine(ortalama >= 45 ? "Geçtiniz" : "Kaldınız");
            Console.ReadKey();
        }
    }
}
