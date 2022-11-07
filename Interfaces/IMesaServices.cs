using ConsumirApi.Entidade;

namespace ConsumirApi.Interfaces
{
    public interface IMesaServices
    {
        Task<List<Mesa>> BuscarMesas();
        Task<Mesa> BuscarMesaPorId(int id);
    }
}