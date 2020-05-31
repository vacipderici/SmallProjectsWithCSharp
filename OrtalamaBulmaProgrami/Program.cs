using System;

namespace OrtalamaBulmaProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldin. Kaç adet sayı gireceksin");
            decimal hafiza = 0;
            int adet = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < adet; i++)
            {
                Console.WriteLine(i + ". sayiyi giriniz");
                hafiza += Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine(adet + "adet sayının ortalaması:" + hafiza / adet);
            Console.ReadLine();
        }
    }
}
