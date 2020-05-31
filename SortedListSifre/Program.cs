using System;
using System.Collections;

namespace SortedListSifre
{
    class Program
    {
        static void Main(string[] args)
        {


            SifreDene(adet: 5);
        }

        private static void SifreDene(int adet)
        {
            string alinanSifre;
            Console.WriteLine("Kullanıcı adını yazınız");
            string kull = Console.ReadLine();
            string sifre = KulSifreVer(kull);
            while (adet>0)
            {
                Console.WriteLine("Şifreyi yazınız");
                alinanSifre = Console.ReadLine();
                adet--;
                if (alinanSifre==sifre)
                {
                    Console.WriteLine("Tebrikler şifreyi doğru girdiniz");
                    Console.ReadKey();
                    break;
                }
                else if (alinanSifre !=  sifre)
                {
                    Console.WriteLine($"Kalan hakkınız:{adet}");
                }
                if (adet ==0 )
                {
                    Console.WriteLine("kullanıcı adı veya şifreyi yanlış girdiniz");
                }
               
            }
        }
        static string KulSifreVer(string kullanici)
        {
            SortedList kulSifre = new SortedList();
            kulSifre.Add("12345", "Ali");
            kulSifre.Add("123", "Can");
            kulSifre.Add("1", "Veli");
            kulSifre.Add("4", "Kemal");
            kulSifre.Add("12", "Ayşe");

            int indeks = kulSifre.IndexOfValue(kullanici);
            return indeks != -1 ? kulSifre.GetKey(indeks).ToString() : null;

        }
    }
}
