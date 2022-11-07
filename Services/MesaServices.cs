using System.Text;
using ConsumirApi.Entidade;
using ConsumirApi.Interfaces;
using Newtonsoft.Json;

namespace ConsumirApi.Services
{
    public class MesaServices : IMesaServices
    {
        public async Task<List<Mesa>> BuscarMesas()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7198/");

            HttpResponseMessage response = await client.GetAsync($"api/Mesa/ListarMesas");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<Mesa>>(responseBody);
            return result;
        }

        public async Task<Mesa> BuscarMesaPorId(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7198/");

            HttpResponseMessage response = await client.GetAsync($"api/Mesa/BuscarMesaPorId/{id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Mesa>(responseBody);
            return result;
        }

        public async Task<Mesa> CriarMesa(Mesa mesa)
        {
            //var client = new HttpClient();
            // client.BaseAddress = new Uri("https://localhost:7198/");

            var novaMesa = JsonConvert.SerializeObject(mesa);
            var data = new StringContent(novaMesa, Encoding.UTF8, "application/json");

            var url = "https://localhost:7198/api/Mesa/CriarMesa";

            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = JsonConvert.DeserializeObject<Mesa>(await response.Content.ReadAsStringAsync());
            
            return result;

        }
    }
}