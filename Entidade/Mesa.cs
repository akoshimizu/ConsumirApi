using Newtonsoft.Json;

namespace ConsumirApi.Entidade
{
    public class Mesa
    {
        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("descricaoMesa")]
        public string DescricaoMesa { get; set; }


        [JsonProperty("indicadorMesaAtiva")]
        public bool IndicadorMesaAtiva { get; set; }


        [JsonProperty("dataDeCriacaoMesa")]
        public DateTime DataDeCriacaoMesa { get; set; }
        

        [JsonProperty("dataUltimaAlteracaoMesa")]
        public DateTime DataUltimaAlteracaoMesa { get; set; }
    }
}