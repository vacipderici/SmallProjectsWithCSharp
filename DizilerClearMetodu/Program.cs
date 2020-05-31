using System;

namespace DizilerClearMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] iller = new string[36];
            int plaka;
            iller[6] = "Ankara";
            iller[34] = "İstanbul";
            iller[35] = "İzmir";
            Console.WriteLine("Birplaka numarası yazınız");
            plaka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(iller[plaka]);
            Console.WriteLine("Dizinin boyutu:" + iller.Length);
            Array.Clear(iller, plaka, 1);
            Console.WriteLine(iller[6]);
            Console.WriteLine(iller[34]);
            Console.WriteLine(iller[35]);
            Console.ReadKey();
;
        }
    }
}
