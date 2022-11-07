using ConsumirApi.Entidade;
using ConsumirApi.Interfaces;
using Newtonsoft.Json;

namespace ConsumirApi.Services
{
    public class MesaServices : IMesaServices
    {
        public async Task<Mesa> BuscarMesas()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7198/");

            HttpResponseMessage response = await client.GetAsync("api/Mesa/ListarMesas");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Mesa>(responseBody);
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
        
    }
}