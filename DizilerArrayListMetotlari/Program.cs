using System;
using System.Collections;

namespace DizilerArrayListMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            //Listeye eleman eklemek.

            arrList.Add("Vacip  Taha ");  //Listeye object tipinde veri ekler.

            arrList.AddRange("Harflerine göre ayır".ToCharArray()); //Listeye ICollection Tipinde eleman ekler.

            arrList.Insert(0, "Mücahit"); //Listeye elemanekler ancak parametre olarak index ve elemanı ister.

            //InsertRange  metodu ICollection tipinde eleman ekler. PArametre olarak eklenecek elemanın index numarasını ve eklenecek ICOllection tipinde elemanı ister.

            // ADD listenin sonuna ekler insert ise index numarasına göre ekler.

            //KAPASITE MessageBox.Show(arrList.Capacity.ToString());

            //TrimToSize arrlist.TrimToSize();  //Kapasitede eleman sayısını eşitler.

            //COUNT arrList.Count.ToString(); dizideki eleman sayısını verir.

            arrList.Clear();

            arrList.Remove("Emine");

            arrList.RemoveAt(0);

            arrList.RemoveRange(0, 3); // sıfırdan başlayarak 3 tane sil.

            //ARAMA İŞLEMLERİ
            arrList.Contains("Vacip"); //İçeren parametre object alır.

            arrList.IndexOf("Vacip");  // indexini verir. -1 dönder

            arrList.LastIndexOf(25); //sonuncusunu verir.

            //Sıralama          //Reverse
            arrList.Sort();    arrList.Reverse(); //Diziyi tersine çevirir.

            //TİP ÇEVİRİMİ  
            arrList.ToArray();


            //KLONLAMA

            ArrayList Yedek = (ArrayList)arrList.Clone();



            Console.WriteLine("Hello World!");
        }
    }
}
