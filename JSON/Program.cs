using Nancy.Json;
using System;
using System.Collections.Generic;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Jsonolustur();
            Console.WriteLine();
            JsonOku();
            Console.ReadLine();
        }

        static string JsonMetniSakla;
        //Oluşaacak olan Json sakladığımız Global değişen


        private static void JsonOku()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            List<Kisiler> kisiler = (List<Kisiler>)serializer.Deserialize(jsonMetni,typeof(List<Kisiler)));

            foreach (Kisiler item in kisiler)
            {
                Console.WriteLine($"{nameof(item.Adi)}");
                Console.WriteLine($"{nameof(item.SoyAdi)}");
                Console.WriteLine($"{nameof(item.Yasi)}");
                Console.WriteLine($"{nameof(item.Cinsiyeti)}");
            }
        }

        private static void Jsonolustur()
        {
            Kisiler kisi1 = new Kisiler();
            kisi1.Adi = "mehmet";
            kisi1.SoyAdi = "Memo";
            kisi1.Yasi = 25;
            kisi1.Cinsiyeti = "Erkek";


            Kisiler kisi2 = new Kisiler();
            kisi2.Adi = "mehmet";
            kisi2.SoyAdi = "Memo";
            kisi2.Yasi = 25;
            kisi2.Cinsiyeti = "Erkek";


            Kisiler kisi3 = new Kisiler();
            kisi3.Adi = "mehmet";
            kisi3.SoyAdi = "Memo";
            kisi3.Yasi = 25;
            kisi3.Cinsiyeti = "Erkek";

            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(kisi1);
            kisi.Add(kisi2);
            kisi.Add(kisi3);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            JsonMetniSakla = serializer.Serialize(kisi); //Json oluşturma işlemi yapıyoruz.

            Console.WriteLine(JsonMetniSakla);


        }
        

    }
}
