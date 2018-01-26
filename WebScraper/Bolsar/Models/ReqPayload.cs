using System.Runtime.Serialization;

namespace WebScraper.Bolsar.Models
{
    [DataContract]
    public class ReqPayload
    {
        public ReqPayload(string especie)
        {
            objEstadoIntradiarioEspecie = new ReqParam() { FiltroEspecie = especie, FiltroVto = "3", MensajeNro = 0 };
        }
        [DataMember]
        internal ReqParam objEstadoIntradiarioEspecie;
    }

    [DataContract]
    public class ReqParam
    {
        [DataMember]
        internal string FiltroEspecie;
        [DataMember]
        internal string FiltroVto;
        [DataMember]
        internal int MensajeNro;

    }
}
