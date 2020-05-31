using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] HaftaninGunleri = { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            foreach (var item in HaftaninGunleri)
            {
                Console.Write(item + "--");
            }
            Console.ReadKey();
        }
    }
}
