using CelsoGuitars.Application.Fornecedor.DTO;

namespace CelsoGuitars.Application.Fornecedor.Service.Interfaces
{
    public interface IMarcaService
    {
        Task<MarcaOutputDTO> Criar(MarcaInputDTO dto);
        Task<MarcaOutputDTO> Atualizar(MarcaUpdateDTO dto);
        Task Remover(Guid marcaID);
        Task<List<MarcaOutputDTO>> ObterTodos();
    }
}
