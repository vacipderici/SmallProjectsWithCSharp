using System;

namespace ParseDortgeninAlani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kısa kenar değerini giriniz");
            int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenar değeri giriniz");
            int uzun = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dortgenin alanı:{kisa * uzun}");
            Console.ReadKey();

        }
    }
}
