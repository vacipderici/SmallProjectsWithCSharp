using System;

namespace goToKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kahveniz nasıl olsun :1=Küçük,2=Orta,3=Büyük");
            Console.WriteLine("Lütfen seçiminizi yapınız");
            int n = int.Parse(Console.ReadLine());
            int fiyat = 0;
            switch (n)
            {
                case 1:
                    fiyat += 2;
                    break;
                case 2:
                    fiyat += 2;
                    goto case 1;
                case 3:
                    fiyat += 4;
                    goto case 1;
                default:
                    Console.WriteLine("Seçiminiz geçerli değildir.");
                    break;
            }
            if (fiyat!=0)
            {
                Console.WriteLine("Lütfen{0} lira ödeyiniz.", fiyat);
                Console.WriteLine($"Lütfen{fiyat} lira ödeyiniz");
                Console.WriteLine("Teşekkürler");
                Console.ReadKey();
            }
        }
    }
}
