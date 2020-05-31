using System;
using System.Collections;

namespace DizilerSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //DizilerSortedList sınıfı object tipinde key ve object tipinde value değerleri ile eleman alır. Keye göre sıralanır. Generic SortedList<> sınıfının ilkel halidir. Hastable ile tek farkının key 'e göre sınırlanmasıdır.
            var sortedList = new SortedList();
            sortedList.Add("A","Vacip");
            sortedList.Add("B","Taha");
            sortedList.Add("C","Mücahit");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Value);
            }
            //ADD ADDRANGE TRIMTOSIZE COUNT
            //CONTAINS INDEXOFKEY INDEXOFVALUE
            Console.ReadKey();

        }
    }
}
