using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using WebScraper.Bolsar.Models;

namespace WebScraper.Bolsar
{
    public class BolsarScraper
    {
        private async Task<string> ReadSpecie(string sName)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string address = "https://www.bolsar.com/VistasDL/PaginaIntradiarioEspecies.aspx/GetDataPack";
            var msg = new ReqPayload(sName);
            var serializer = new DataContractJsonSerializer(typeof(ReqPayload));
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, msg);
            var reader = new StreamReader(stream);
            stream.Position = 0;
            var payload = reader.ReadToEnd();
            HttpResponseMessage wcfResponse = await client.PostAsync(address, new StringContent(payload, Encoding.UTF8, "application/json"));
            string x = await wcfResponse.Content.ReadAsStringAsync();
            return x;
        }

        private async Task<string> ReadAcciones()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string address = "https://www.bolsar.com/VistasDL/PaginaLideres.aspx/GetDataPack";
            var payload = @"{""aEstadoTabla"":[{""TablaNombre"":""tbAcciones"",""FiltroVto"":""48"",""FiltroEspecies"":"""",""Orden"":"""",""EsOrdenAsc"":true,""FilasxPagina"":-1,""MensajeNro"":0,""HashCode"":0},{""TablaNombre"":""tbMontos"",""FiltroVto"":"""",""FiltroEspecies"":"""",""PagActualNro"":""1"",""Orden"":"""",""EsOrdenAsc"":true,""FilasxPagina"":-1,""MensajeNro"":0,""HashCode"":0},{""TablaNombre"":""tbIndices"",""FiltroVto"":"""",""FiltroEspecies"":"""",""PagActualNro"":""1"",""Orden"":"""",""EsOrdenAsc"":true,""FilasxPagina"":-1,""MensajeNro"":0,""HashCode"":0}]}";
            HttpResponseMessage wcfResponse = await client.PostAsync(address, new StringContent(payload, Encoding.UTF8, "application/json"));
            string x = await wcfResponse.Content.ReadAsStringAsync();
            return x;
        }
        public List<ResumenAccion> GetAcciones()
        {

            string result = ReadAcciones().GetAwaiter().GetResult();
            JObject json = JObject.Parse(result);
            var jsonData = new JsonDataResult();
            var x = json["d"][0]["aTabla"].ToObject<List<ResumenAccion>>();
            return x;
        }
        public JsonDataResult GetSpecieData(string sName)
        {

            string result = ReadSpecie(sName).GetAwaiter().GetResult();
            JObject json = JObject.Parse(result);
            var jsonData = new JsonDataResult();
            jsonData.MovDiarios = json["d"][0].ToObject<BolsarTable>();
            jsonData.Fecha = json["d"][1].ToObject<DateTime>();
            jsonData.Resumen = json["d"][2].ToObject<ResumenAccion>();

            return jsonData;
        }
    }
}




