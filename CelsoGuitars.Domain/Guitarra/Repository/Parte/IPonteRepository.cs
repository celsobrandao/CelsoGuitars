using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface IPonteRepository : IRepository<Ponte>
    {
        Task<List<Ponte>> GetAllCompleto();
    }
}
