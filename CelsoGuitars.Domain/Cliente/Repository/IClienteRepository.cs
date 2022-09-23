using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Cliente.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Guid> ValidarLogin(string email, string senha);
    }
}
