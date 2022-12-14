using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Guitarra.Repository.Parte
{
    public interface ICaptadorRepository : IRepository<Captador>
    {
        Task<List<Captador>> GetAllCompleto();
    }
}
