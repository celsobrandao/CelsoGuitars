using CelsoGuitars.Application.Servico.DTO;

namespace CelsoGuitars.Application.Servico.Service.Interfaces
{
    public interface ITipoServicoService
    {
        Task<TipoServicoOutputDTO> Criar(TipoServicoInputDTO dto);
        Task<TipoServicoOutputDTO> Atualizar(TipoServicoUpdateDTO dto);
        Task Remover(Guid tipoServicoID);
        Task<List<TipoServicoOutputDTO>> ObterTodos();
    }
}
