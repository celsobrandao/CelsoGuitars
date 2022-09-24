using CelsoGuitars.Application.Guitarra.DTO;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Application.Guitarra.Service.Interfaces
{
    public interface IGuitarraService
    {
        Task<GuitarraOutputDTO> Criar(GuitarraInputDTO dto);
        Task<GuitarraOutputDTO> Atualizar(GuitarraUpdateDTO dto);
        Task Remover(Guid guitarraID);
        Task<List<GuitarraOutputDTO>> ObterTodos();
        Task<GuitarraModel> Obter(Guid guitarraID);
    }
}
