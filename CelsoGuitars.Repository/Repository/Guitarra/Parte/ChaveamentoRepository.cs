using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class ChaveamentoRepository : Repository<Chaveamento>, IChaveamentoRepository
    {
        public ChaveamentoRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
