using System;
using System.Collections.Generic;
using System.IO;

namespace DosyaVeKlasorIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //KLASOR OLUŞTURMA İSLEMLERİ
            //CreateDirectory => Yeni bir klasöt oluşturur.
            string Ad = "Klasör adı";
            Directory.CreateDirectory(@"C:\" + Ad);

            //KLASOR SILME ISLEMLERI
            //DELETE
            Directory.Delete(@"C:\" + Ad, true); //Recursive yaptım true ile.

            //klasorleri listelemek
            string yol = @"C:\";
            List<string> dir = new List<string>(Directory.EnumerateDirectories(yol));
            string[] yollar = dir.ToArray();
            foreach (var item in yollar)
            {
                Console.WriteLine(item);
            }

            //Klasör var mı =
            Console.WriteLine(Directory.Exists(yol).ToString());



            Console.ReadKey();
        }
    }
}
