using CelsoGuitars.Infra.Repository;

namespace CelsoGuitars.Domain.Servico.Repository
{
    public interface IOrdemServicoRepository : IRepository<OrdemServico>
    {
        Task<OrdemServico> GetByIDCompleto(Guid ordemServicoID);
        Task<List<OrdemServico>> GetCompletoByCliente(Guid clienteID);
    }
}
