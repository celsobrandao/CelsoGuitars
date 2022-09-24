using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Domain.Servico;

namespace CelsoGuitars.Application.Servico.Service.Interfaces
{
    public interface ITipoServicoService
    {
        Task<TipoServicoOutputDTO> Criar(TipoServicoInputDTO dto);
        Task<TipoServicoOutputDTO> Atualizar(TipoServicoUpdateDTO dto);
        Task Remover(Guid tipoServicoID);
        Task<List<TipoServicoOutputDTO>> ObterTodos();
        Task<TipoServico> Obter(Guid tipoServico);
    }
}
