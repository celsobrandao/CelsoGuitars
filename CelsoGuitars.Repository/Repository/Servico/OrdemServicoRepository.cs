using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Servico
{
    public class OrdemServicoRepository : Repository<OrdemServico>, IOrdemServicoRepository
    {
        public OrdemServicoRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
