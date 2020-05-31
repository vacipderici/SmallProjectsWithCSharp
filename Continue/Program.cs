using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 11; i++)
            {
                if (i == 3) continue;
               
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
