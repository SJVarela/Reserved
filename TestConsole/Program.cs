using System;
using System.Collections.Generic;
using WebScraper.Bolsar;
using WebScraper.Bolsar.Models;

namespace TestConsole
{
    class Program
    {


        static void Main(string[] args)
        {
            BolsarScraper scraper = new BolsarScraper();
            var lista = new List<JsonDataResult>();

            var x = scraper.GetAcciones();

            foreach(var y in x)
            {
                lista.Add(scraper.GetSpecieData(y.Simbolo));                
            }
            Console.ReadKey();
        }
    }
}
