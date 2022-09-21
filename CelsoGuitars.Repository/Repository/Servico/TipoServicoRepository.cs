using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Servico
{
    public class TipoServicoRepository : Repository<TipoServico>, ITipoServicoRepository
    {
        public TipoServicoRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
