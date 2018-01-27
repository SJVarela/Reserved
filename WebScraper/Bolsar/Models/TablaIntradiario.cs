using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebScraper.Bolsar.Models
{
    [Serializable]
    public class TablaIntradiario
    {
        public int CantidadTotalFilas { get; set; }
        public int HashCode { get; set; }
        public string HoraUltimaCotizacion { get; set; }
        public int MRC { get; set; }
        public int MensajeNro { get; set; }
        public string TablaNombre { get; set; }
        public int UltimaActualizacionListaEspecies { get; set; }
        [JsonProperty("aTabla")]
        public List<Operacion> Operaciones { get; set; }
    }
}
