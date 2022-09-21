using CelsoGuitars.Domain.Fornecedor;
using CelsoGuitars.Domain.Fornecedor.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Fornecedor
{
    public class MarcaRepository : Repository<Marca>, IMarcaRepository
    {
        public MarcaRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
