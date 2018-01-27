using System;

namespace WebScraper.Bolsar.Models
{
    [Serializable]
    public class Operacion
    {
        public int AgenteCompradorID { get; set; }
        public int AgenteVendedorID { get; set; }
        public int CantidadOperacion { get; set; }
        public int CantidadOperaciones { get; set; }
        public int Categoria { get; set; }
        public bool EsFraccion { get; set; }
        public int HoraCotizacion { get; set; }
        public int MensajeNro { get; set; }
        public int Mercado { get; set; }
        public decimal MontoOperado { get; set; }
        public int NroRegistro { get; set; }
        public decimal PrecioApertura { get; set; }
        public decimal PrecioCierreAnterior { get; set; }
        public decimal PrecioMaximo { get; set; }
        public decimal PrecioMinimo { get; set; }
        public decimal PrecioOperacion { get; set; }
        public decimal PrecioUltimo { get; set; }
        public string Simbolo { get; set; }
        public int Tendencia { get; set; }
        public string TipoEvento { get; set; }
        public int TipoGarantiaSIU { get; set; }
        public int TipoLiquidacionSIU { get; set; }
        public int TotalOperadoMonto { get; set; }
        public int TotalOperadoVN { get; set; }
        public decimal Variacion { get; set; }
        public int Vencimiento { get; set; }
        public string cAtributoPrecio { get; set; }
        public string cVencimientoStandard { get; set; }
        public string dtHoraCotizacion { get; set; }
    }
}

