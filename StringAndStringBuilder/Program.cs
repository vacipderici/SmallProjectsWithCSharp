using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //String sınıfı char veri tipinin karakterlerinin birden fazlasının bir araya gelmesi ile oluşur.


            //Char Özelliği
            Console.WriteLine("Beşiktaş"[0].ToString()); //B döner

            char krktr = "ABC"[1]; //B döner

            //Length Özelliği

            Console.WriteLine("test".Length.ToString());

            //STRING CLASS METHODS

            //CLONE

            string metin = "bu bir metotdur";
            object klon = metin.Clone();
            Console.WriteLine(klon);

            //KARŞILAŞTIRMA
            //İki string veriyi karşılaştırır. int tipinde değer döndürür. İki değer eşit ise 0 döner. Soldan ilk değer önde ise -1 ,önde değilse 1 döner.


            Console.WriteLine(string.Compare("A", "B").ToString()); //1 Döner

            Console.WriteLine(string.Compare("C", "B").ToString()); //-1 Döner

            //bool IgnoreCase parametresi true ise büyük küçük harfi ayırmadan karşılaştırma yapılır.

            Console.WriteLine(string.Compare("vacip", "VACİP", true).ToString()); //0 Döner yani eşitlik var.

            // 
            Console.WriteLine(string.Compare("aaa", null)); //nullda da hata bulunmaz.

            //BİRLEŞTİRME
            //contac
            Console.WriteLine(string.Concat("Ahmet", "Mehmet")); //AhmetMehmet döner.

            //Join
            string[] dizi = new string[] { "ali", "ayşe", "kara" };
            string birlestirmis = string.Join("-", dizi);

            //Insert
            //Bir string versine başka bir string verisini ekler,eklemenin hangi indeksten başlayacağını belirtmemizi ister.
            string inSample = "Veli Bak";
            Console.WriteLine(inSample.Insert(inSample.Length, "Koş"));



            //REMOVE

            Console.WriteLine(inSample.Remove(6));

            Console.WriteLine(inSample.Remove(5, 2));

            //DEGISTIRME
            //Replace string bir verinin içinden,yine string bir veri ile değiştir
            string ifade = "Ali Koş";
            Console.WriteLine(ifade.Replace("Gel", "Koş"));//Sonuç Ali koş

            //Substring //Parçalama
            string metinn = "Ali Gel";
            Console.WriteLine(metinn.Substring(2, 4)); //Çıktısı =>i Ge

            //Metin Bölme Split
            //Strgin veriyi parametrede bildirilen ayraç işaretine göre böler. String dizisi tipinde değerler dizisi döndürür.
            string dogTarihi = "17.11-1976/Çarşamba";
            List<string> listes = new List<string>();
            listes.AddRange(dogTarihi.Split('.', '/', '-'));
            string[] str = listes.ToArray();
            foreach (var item in listes)
            {
                Console.WriteLine(item);
            }

            //EKLEME padLeft String ifadenin uuznluğunu parametrede belirtilen karakteri Sola ekleyerek tamamlar. Parametrede bir karakter kullanışmamışsa boşluk ekler.
            //PadRight

            List<string> sayilar = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(i.ToString().PadLeft(0, 'L').PadRight(1, '-'));

            }
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            //KIRPMA Trimleme
            string trimlenecek = "Ali Tok";
            trimlenecek.TrimEnd(); //Sondaki boşlukları siler
            trimlenecek.TrimStart(); //Baştaki boşlujları siler


            //ARAMA

            //Contains string bir veride arama yapar bulursa true döndürür.
            string ad = "Ahmet Ak";
            Console.WriteLine(ad.Contains("met").ToString());//true döner

            //StartsWith string ifade parametre olarak veirlen değer ile başlıyorsa true döner;

            Console.WriteLine(ad.StartsWith("Ahmet".ToString())); //true döner

            Console.WriteLine(ad.EndsWith("Ahmet".ToString())); //true döner

            //IndexOf PArametre olarak verilen değer string ifade içinde varsa ilk harfin index numarasını döner. Değer bulunmadıysa -1 döner.
            string name = "Veli Tur";
            Console.WriteLine(name.IndexOf("li T").ToString()); //2 DÖner

            Console.WriteLine(name.IndexOf("li TU").ToString()); //-1 döner yani veri yok.

            Console.WriteLine(name.IndexOf("li TU", StringComparison.InvariantCultureIgnoreCase).ToString()); //-1 döner yani veri yok.


            //LastIndexOf  PArametre olarak verilen değer string ifade içinde varsa son harfin index numarasını döner. Değer bulunmadıysa -1 döner.

            string nameHasan = "Hasan";
            Console.WriteLine(nameHasan.LastIndexOf("an").ToString()); //5 döner

            //INDEXOFANY String ifadede aramak istediğiniz karakterleri bir char[] dizisine ekleyip arama işlemi yaptırabilirsiniz. Değer bulursa indeksi döner, bulamazsa -1 döner;

            char[] charDizi = new char[] { '0', '1', '2' };
            string adChar = "55532";
            Console.WriteLine(adChar.IndexOfAny(charDizi).ToString()); //4 döner


            //NULL KONTROLLERİ
            //IsNullOrEmpty  String bir ifadenin Null veya Boş ise True döndürür.

            //IsNullOrWhiteSpace String bir ifade Null, boş veya (Space tuşu ile oluşlan)boşluk karakterinden oluşmuş ise true döner
            string mesaj = "";
            bool b1 = string.IsNullOrWhiteSpace(mesaj);
            bool b2 = string.IsNullOrEmpty(mesaj);

            //BİÇİMLENDİRME format

            byte hava = 28;
            byte deniz = 28;
            Console.WriteLine(string.Format($"Bugun hava {hava} derece,Deniz sıcaklığı {deniz} derece"));

            //Rakamsal Formatlama ve Tarihsel Formatlamalar var. 

            //ÇEVİRİMLER
            //TOCHARARRAY karakterlerine ayırma.
            string ayrilacak = "Beşiktaş";
            foreach (char item in ayrilacak.ToCharArray())
            {
                List<char> sad = new List<char>();
                sad.Add(item);
                char[] sadas = sad.ToArray();
                Console.WriteLine(sadas);
            }
            //Bir cümlede hangi harften kaç tane olduğunu bulalım.
            string cumle = "Bu bir cümledir";
            cumle = cumle.ToLower();
            var frekans = cumle.ToCharArray()
                .GroupBy(x => x)
                .Select(x => new { Karakter = x.Key, Sayi = x.Count() });

            foreach (var item in frekans.OrderBy(f => f.Karakter))
            {
                Console.WriteLine($"Karakter:{item.Karakter},Sayi{item.Sayi}");
            }

            //TOLOWER,TOUPPER,
            //----------------
            //TOTITLECASE
            //metindeki ilk karakterleri büyük harfe çevirir. Bu işlemi yapabilmek için ihtiyacımız olan sınıf CultureInfo sınıfıdır,

            string titleCase = "Bu gun hava çok güzel";
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titleCase));   //Sonuç  Bu Gun Hava Çok Güzel.

            //TOSTRING
            string dte = DateTime.Now.ToString("g");
            Console.WriteLine(dte); //18.10.2020;


            //STRING BUILDER //Join,Concat,Insert ve + işaretinden daha hızlıdır.
            StringBuilder sb = new StringBuilder();
            sb.Append("AAA");
            sb.Append(" BBB");

            Console.WriteLine(sb);

            ///STRINGBUILDER PROPERTIES
            
            //Capacity stringbuilder tipinde değişkende ne kadar uzunlukta metin barındırabileceğimizi belirler. İlk Tanımlandığında 16 karaktere izin verir. 16 -32 -64 şeklinde gider.

            //MaxCapacity StringBuilder sınıfının alabileceği boyur, en fazla int veri tipinin pozitif üst sınırına kadardır. Yani 2.147.483.647'dir.

            //Length SB içindeki verilerin karakter adedini verir.

            //STRINGBUILDER METHODS

            //Append => veri ekler object tipinde veri kabul eder. Stringe çevrilebilenlerin stringe çevrilmesine gerek yoktur.
            //AppendLine=> Ekledikten sonra yeni bir satır açar.
            //AppendFormat =>Biçimlendirilmiş veri ekler. Eklenen verrnin formatını ayarlamaya imkan tanır. String Format gibi.

            //Clear SB sınıfı tipinde tanımlanan değişkendeki tüm verileri temizler
            //CopyTo SB tipindeki değişkenin içerdiği verileri kopyalar.
            //Equals SB sınıfı tipinde tanımlanan iki değişkeni karşılaştırır.
            //Insert SB sınıfı tipinde  iki değişkene veri ekler.
            //Remove SB sınıfı tipinde int tipindeki değerden başlar ve belirtilen adette veriyi siler.
            //Replace  veriyi değiştirir.

            //Console Project StringBuilder Metot ve Özellikleri.

            //STOPWATCH SINIFI  kod parçacıkların ne kadar süre çalıştıklarını ölçmek için kullanılan bir sınıftır.
            //StopWatch Özellikleri

            //Elapsed Toplam süreyi TimePan tipinde verir.
            //ElapsedMilliSeconds Toplam süreyi Long tipinde milisaniye cinsinden verir. Mesela 699.
            //IsRunning Kronomere sayacının çalışıp çalışmadığını bool tipinde döner.

            //StopWatch Metotları
            //Reset Ölçüm sonucunda oluşan süre aralığını sıfırlar.
            //Restart süreyi sıfırlar
            //Start Yeni bir ölçüm başlatır. New anahtar kelimesi ile STOPWATCH örneği alınmadığında direkt olarak, sınıfın StartNew metodu kullanılabilir, durumdadır.
            //Stop StopWatch süre ölçme işlemini durdurur.

            

            Console.ReadKey();













        }
    }
}
