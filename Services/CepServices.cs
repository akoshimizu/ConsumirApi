using System.Text.Json;
using consumirApi.Entidade;
using consumirApi.Interfaces;

namespace consumirApi.Services
{
    public class CepServices : ICepService
    {
        //static readonly HttpClient client = new HttpClient();
        public async Task<CEP> BuscaCepAsync(string cep)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://viacep.com.br/");

            // var response = await client.GetAsync($"/ws/{cep}/json");
            // var obje = JObject.Parse(response.Content);
            
            HttpResponseMessage response = await client.GetAsync($"ws/{cep}/json");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<CEP>(responseBody);
            return result;
        }
    }
}