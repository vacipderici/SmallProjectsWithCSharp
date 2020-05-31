using System;

namespace DizilerSort
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] isimler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} . ismi giriniz", i+1);
                isimler[i] = Console.ReadLine();
            }
            Array.Sort(isimler);
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.ReadKey();
        }
    }
}
