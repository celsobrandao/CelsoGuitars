using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface IMadeiraRepository : IRepository<Madeira>
    {
        Task<List<Madeira>> GetAllCompleto();
    }
}
