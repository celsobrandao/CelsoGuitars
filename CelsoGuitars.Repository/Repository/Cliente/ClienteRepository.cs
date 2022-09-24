using CelsoGuitars.Domain.Cliente.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Repository.Repository.Cliente
{
    public class ClienteRepository : Repository<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
