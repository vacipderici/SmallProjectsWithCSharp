using System;

namespace DonguyleDizidenDegerOkumak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = new string[7];
            int i = 0;
            gunler[0] = "Pazartesi";
            gunler[1] = "Sali";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            foreach (string days in gunler)
            {
                Console.WriteLine(gunler[i]);
                i++;
            }
             
            
            Console.ReadKey();
        }
    }
}
