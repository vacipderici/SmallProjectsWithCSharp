using System;

namespace HataDenetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRYCATCH FINALLY

            //TRY => Hata oluşabilecek kod satırları.

            //Catch => Sadece hata yakalandığında yapılaaklar.

            //Finally =>Her durumda çalışacak kodlar.

            try
            {
                throw new Exception("2. nolu hatayı fırlat");
            }
            catch (Exception ex) when (ex.Message =="1. nolu hatayı fırlat")
            {

                Console.WriteLine("1 nolu hatayı fırlat");
            }
            catch (Exception ex) when (ex.Message == "2. nolu hatayı fırlat")
            {

                Console.WriteLine("2 nolu hata");
            }

            Console.ReadKey();

        }
    }
}
