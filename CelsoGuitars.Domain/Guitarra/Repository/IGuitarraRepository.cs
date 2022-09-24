using CelsoGuitars.Infra.Repository;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Domain.Guitarra.Repository
{
    public interface IGuitarraRepository : IRepository<GuitarraModel>
    {
        Task<GuitarraModel> GetByIDCompleto(Guid id);
        Task<List<GuitarraModel>> GetAllCompleto();
    }
}
