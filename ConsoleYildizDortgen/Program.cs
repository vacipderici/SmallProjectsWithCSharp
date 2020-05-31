using System;

namespace ConsoleYildizDortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dörtgenin en değerini yazınız");
            int en = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dörtgenin boy değerini yazınız");
            int boy = Convert.ToInt32(Console.ReadLine());


            if (en != boy)
            {
                for (int i = 0; i < boy; i++)
                {
                    for (int j = 0; j < en; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Kare Seçtiniz");
            }
            Console.ReadKey();
        }
    }
}
