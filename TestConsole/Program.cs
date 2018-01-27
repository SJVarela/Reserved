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
            var lista = new List<DataPack>();

            var x = scraper.GetAllAcciones();

            foreach (var y in x)
            {
                lista.Add(scraper.GetAccion(y.Simbolo));
            }
            Console.ReadKey();

            foreach (var t in lista)
            {
                Console.WriteLine(t.MovDiarios.Operaciones.Find(r => r.AgenteCompradorID == 0).Simbolo);
            }

            Console.ReadKey();
        }
    }
}
