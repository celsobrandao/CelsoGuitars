using CelsoGuitars.Domain.Cliente.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Repository.Repository.Cliente
{
    public class ClienteRepository : Repository<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(CelsoGuitarsContext context) : base(context)
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
