using System;

namespace DizilerMinMaxTop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[50];
            double toplam = 0;
            Random rnd = new Random();
            int min, max;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(10, 100);
                Console.WriteLine(sayilar[i]);
            }
            min = sayilar[0];
            max = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (min < sayilar[i])
                    min = sayilar[i];
                if (max > sayilar[i])
                    max = sayilar[i];
                toplam += sayilar[i];

            }
            Console.WriteLine("Dizi içindeki en büyük sayi :" + max.ToString());
            Console.WriteLine("Dizi içindeki en küçük sayi :" + min.ToString());
            Console.WriteLine("Dizi içindeki sayilarin toplami" + toplam.ToString());

            Console.ReadKey();

        }
    }
}
