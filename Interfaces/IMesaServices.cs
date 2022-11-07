using ConsumirApi.Entidade;

namespace ConsumirApi.Interfaces
{
    public interface IMesaServices
    {
        Task<Mesa> BuscarMesas();
        Task<Mesa> BuscarMesaPorId(int id);
    }
}