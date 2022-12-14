using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface ITrasteRepository : IRepository<Traste>
    {
        Task<List<Traste>> GetAllCompleto();
    }
}
