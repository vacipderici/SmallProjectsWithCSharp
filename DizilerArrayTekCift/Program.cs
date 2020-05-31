using System;
using System.Collections;

namespace DizilerArrayTekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tek ve çift sayıla hangi sayıya kadar listelenecek:");
            int kacaKadar = Convert.ToInt32(Console.ReadLine());
            ArrayList tekSayilar = new ArrayList();
            ArrayList ciftSayilar = new ArrayList();
            for (int i = 0; i < kacaKadar; i++)
            {
                if (i % 2 == 0) ciftSayilar.Add(i);
                if (i % 2 != 0) tekSayilar.Add(i);
            }
            Console.WriteLine("Tek Sayilar:");
            for (int i = 0; i < tekSayilar.Count; i++)
            {
                Console.WriteLine(tekSayilar[i]);
            }
            Console.WriteLine("Çift Sayilar:");
            for (int i = 0; i < ciftSayilar.Count; i++)
            {
                Console.WriteLine(ciftSayilar[i]);
            }
            Console.ReadKey();
               
;        }
    }
}
