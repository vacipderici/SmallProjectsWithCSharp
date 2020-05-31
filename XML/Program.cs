using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement exchange = XElement.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            List<XElement> exchangeList = (from ex in exchange.Elements()
                                           select ex).ToList();
            Console.WriteLine(string.Format("{0,-3} | {1,-9} | {2,-9}", "Kur", "Alış Kuru", "Satış Kuru"));
            Console.WriteLine("----------------------------");
            foreach (XElement item in exchangeList)
            {
                Console.WriteLine(string.Format("{0,-3} | {1,-9} | {2,-9}", item.Attribute("CurrencyCode").Value, item.Element("ForexBuying").Value, item.Element("ForexSelling").Value));
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
