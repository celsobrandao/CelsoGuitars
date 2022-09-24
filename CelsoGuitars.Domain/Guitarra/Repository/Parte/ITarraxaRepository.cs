using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface ITarraxaRepository : IRepository<Tarraxa>
    {
        Task<List<Tarraxa>> GetAllCompleto();
    }
}
