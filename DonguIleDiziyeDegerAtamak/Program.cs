using System;

namespace DonguIleDiziyeDegerAtamak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rakamlar = new int[10];
            for (int i = 0; i < rakamlar.Length; i++)
            {
                rakamlar[i] = i + 1;
                Console.WriteLine(rakamlar[i]);
            }
            Console.ReadKey();
        }
    }
}
