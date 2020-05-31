using System;

namespace DoWhileTekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i % 2 == 0 ? i + "Çift" : i + "Tek");
                i++;
            } while (i<=100);
            Console.ReadLine();
        }
    }
}
