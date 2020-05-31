using System;
using System.Collections;

namespace DizilerHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable arac = new Hashtable();
            arac.Add("41bb900", "alfa Romeo");
            arac.Add("42cc800", "Mercedes");
            arac.Add("25dd700", "Ford");
            ///Keye göre arama Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar(Key) mevcutsa TRUE  değilse FALSE döndürecektir.
            if (arac.ContainsKey("41 ABC 123"))
                Console.WriteLine(arac["41 ABC 123"]);
            else
                Console.WriteLine("Araç Bulunamadı.");
            //Value Göre arama
            // Koleksiyon içerisinde, parametre olarak girilen ifadede bir Değer(Value) mevcutsa TRUE  değilse FALSE döndürecektir.

            arac.Add("41 ABC 123", "Alfa Romeo");
            arac.Add("56 ABC 456", "Audi");
            arac.Add("25 ABC 789", "Mercedes-Benz");

            // Koleksiyonda "Audi" Değeri mevcut olduğu için TRUE döndürecektir.
            // Ekran çıktısı: Mevcut
            if (arac.ContainsValue("Audi"))
                Console.WriteLine("Mevcut");
            else
                Console.WriteLine("Mevcut Değil.");
            // Remove(Anahtar) Metodu
            //Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar(Key) mevcutsa; Anahtarı ve anahtarla ilişkili Değeri silecektir.

            arac.Remove("41 ABC 123");
        }
    }
}
