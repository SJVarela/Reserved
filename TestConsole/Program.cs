using System;
using WebScraper.Bolsar;

namespace TestConsole
{
    class Program
    {


        static void Main(string[] args)
        {
            BolsarScraper scraper = new BolsarScraper();
            var x = scraper.GetSpecieTable("AGRO");
            Console.WriteLine(x.Fecha);
            Console.ReadKey();
        }
    }
}
