using CelsoGuitars.Application.Servico.DTO;

namespace CelsoGuitars.Application.Servico.Service.Interfaces
{
    public interface IOrdemServicoService
    {
        Task<OrdemServicoOutputDTO> Criar(OrdemServicoInputDTO dto);
        Task<OrdemServicoOutputDTO> Atualizar(OrdemServicoUpdateDTO dto);
        Task<OrdemServicoOutputDTO> Finalizar(OrdemServicoFinalizarInputDTO dto);
        Task Remover(Guid ordemServicoID);
        Task<List<OrdemServicoOutputDTO>> ObterTodos();
    }
}
