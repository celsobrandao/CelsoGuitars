using CelsoGuitars.Domain.Usuario.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;
using UsuarioModel = CelsoGuitars.Domain.Usuario.Usuario;

namespace CelsoGuitars.Repository.Repository.Usuario
{
    public class UsuarioRepository : Repository<UsuarioModel>, IUsuarioRepository
    {
        public UsuarioRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<Guid> ValidarLogin(string email, string senha)
        {
            return DbSet.Where(x => x.Email.Valor.ToUpper() == email.ToUpper() && x.Senha.Valor == senha)
                        .Select(x => x.ID)
                        .FirstOrDefaultAsync();
        }
    }
}
