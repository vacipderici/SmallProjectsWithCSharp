using System;

namespace SifreWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int deneme = 5;
            int sifre = 1234;
            int kullSifre = 0;
            while (deneme>0)
            {
                Console.WriteLine("Lütfen şifretyi giriniz");
                kullSifre = Convert.ToInt32(Console.ReadLine());
                deneme--;
                if (kullSifre==sifre)
                {
                    Console.WriteLine("Tebrikler şifreyi doğru tahmin ettiniz");
                    Console.ReadKey();
                    break;
                }
                else if (kullSifre!=sifre)
                {
                    Console.WriteLine($"Kalan kullanım hakkınız:{deneme}");
                }
                if (deneme==0)
                {
                    Console.WriteLine("Şifreyi yanlış girdiniz");
                    Console.ReadKey();
                }
            }
        }
    }
}
