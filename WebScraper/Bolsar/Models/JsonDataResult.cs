using System;
using System.Collections.Generic;

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
    [Serializable]
    public class BolsarTable
    {
        public int CantidadTotalFilas { get; set; }
        public int HashCode { get; set; }
        public string HoraUltimaCotizacion { get; set; }
        public int MRC { get; set; }
        public int MensajeNro { get; set; }
        public string TablaNombre { get; set; }
        public int UltimaActualizacionListaEspecies { get; set; }
        public List<Operacion> aTabla { get; set; }
    }
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

    public class JsonDataResult
    {
        public BolsarTable MovDiarios { get; set; }
        public DateTime Fecha { get; set; }
        public ResumenAccion Resumen { get; set; }
    }
}
