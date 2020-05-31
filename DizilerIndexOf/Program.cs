using System;

namespace DizilerIndexOf
{
    class Program
    {
        //Parametresinde sunulan dizi elemanlarında,parametresinde sunduğunuz değeri arar, Bulursa bulunduğu elemanın index numarasını sunar. Bulamazsa -1 dönder. BÖylece eksi bir haricinde buldu demektir.
        static void Main(string[] args)
        {
            int bulunduMu = 0;
            string[] isimler = {"Vacip","Mücahit","Hülya" };
            bulunduMu = Array.IndexOf(isimler, "Vacip") +1;
            Console.WriteLine(bulunduMu == -1 ? "Bulunamadı" : "Bulundu" + bulunduMu + ".sırada");
            Console.ReadKey();
        }
    }
}
