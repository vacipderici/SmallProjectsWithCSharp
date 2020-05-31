using System;

namespace DizilerReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe = new char[26];
            int sayac = 0;
            for (char i = 'A'; i < 'Z'; i++)
            {
                alfabe[sayac] = i;
                sayac++;
            }
            Console.WriteLine(alfabe);
            Array.Reverse(alfabe);
            Console.WriteLine(alfabe);
            Console.ReadKey();
        }
    }
}
