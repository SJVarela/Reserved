using System;
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
        public async Task<string> ReadSpecie(string sName)
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

        public JsonDataResult GetSpecieTable(string sName)
        {
            string result = ReadSpecie(sName).GetAwaiter().GetResult();
            var data = new JavaScriptSerializer().Deserialize<Data>(result);
            var jsonData = new JsonDataResult();
            jsonData.TablaDiaria = (BolsarTable)data.d[0];
            jsonData.Fecha = (DateTime)data.d[1];
            jsonData.TablaHistorico = (HistoricoTable)data.d[2];

            return jsonData;
        }
    }
}
