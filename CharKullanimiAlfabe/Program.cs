using System;

namespace CharKullanimiAlfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            char i= 'A';
            while (i<='Z')
            {
                Console.Write(i + "---");
                i++;
            }
            Console.ReadKey();
        }
    }
}
