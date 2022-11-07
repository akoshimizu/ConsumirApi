using consumirApi.Entidade;

namespace consumirApi.Interfaces
{
    public interface ICepService
    {
         Task<CEP> BuscaCepAsync(string cep);
    }
}