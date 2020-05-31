using System;

namespace HarfSayi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Lütfen ismi giriniz");
            string isim = Console.ReadLine();
            isim.ToLower();
            char[] isimDizi = isim.ToCharArray();

           
            foreach (var h in isimDizi)
            {

            }
        }
    }
}
