using System;

namespace WebScraper.Bolsar.Models
{
    [Serializable]
    public class ResumenAccion
    {
        public int CantidadNominalCompra { get; set; }
        public int CantidadNominalVenta { get; set; }
        public int CantidadOperaciones { get; set; }
        public bool EsPrestamo { get; set; }
        public int EstadoID { get; set; }
        public bool FormoPrecio { get; set; }
        public string HoraCotizacion { get; set; }
        public string HoraEmision { get; set; }
        public int HoraEmisionNum { get; set; }
        public bool MarcaPrecioEX { get; set; }
        public int MensajeNro { get; set; }
        public int MontoOperado { get; set; }
        public decimal PrecioApertura { get; set; }
        public decimal PrecioCierreAnterior { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioMaximo { get; set; }
        public decimal PrecioMinimo { get; set; }
        public decimal PrecioOperacion { get; set; }
        public decimal PrecioPromedio { get; set; }
        public decimal PrecioPromedioPonderado { get; set; }
        public decimal PrecioUltimo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Simbolo { get; set; }
        public decimal Tendencia { get; set; }
        public int TipoLiquidacion { get; set; }
        public decimal Variacion { get; set; }
        public decimal VariacionOrden { get; set; }
        public int VencimientoID { get; set; }
        public int VolumenNominal { get; set; }
    }
}
