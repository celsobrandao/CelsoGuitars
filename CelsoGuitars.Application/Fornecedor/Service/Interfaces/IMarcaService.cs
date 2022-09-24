using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Fornecedor;

namespace CelsoGuitars.Application.Fornecedor.Service.Interfaces
{
    public interface IMarcaService
    {
        Task<MarcaOutputDTO> Criar(MarcaInputDTO dto);
        Task<MarcaOutputDTO> Atualizar(MarcaUpdateDTO dto);
        Task Remover(Guid marcaID);
        Task<Marca> Obter(Guid marcaID);
        Task<List<MarcaOutputDTO>> ObterTodos();
    }
}
