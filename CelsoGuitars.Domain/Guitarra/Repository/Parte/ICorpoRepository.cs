using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface ICorpoRepository : IRepository<Corpo>
    {
        Task<List<Corpo>> GetAllCompleto();
    }
}
