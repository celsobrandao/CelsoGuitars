using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Usuario.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Guid> ValidarLogin(string email, string senha);
    }
}
