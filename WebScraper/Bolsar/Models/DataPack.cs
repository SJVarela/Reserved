using System;

namespace WebScraper.Bolsar.Models
{
    public class DataPack
    {
        public TablaIntradiario MovDiarios { get; set; }
        public DateTime Fecha { get; set; }
        public ResumenAccion Resumen { get; set; }
    }
}
