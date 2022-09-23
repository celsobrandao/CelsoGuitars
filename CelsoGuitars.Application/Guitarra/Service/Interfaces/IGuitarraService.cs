using CelsoGuitars.Application.Guitarra.DTO;

namespace CelsoGuitars.Application.Guitarra.Service.Interfaces
{
    public interface IGuitarraService
    {
        Task<GuitarraOutputDTO> Criar(GuitarraInputDTO dto);
        Task<GuitarraOutputDTO> Atualizar(GuitarraUpdateDTO dto);
        Task Remover(Guid guitarraID);
        Task<List<GuitarraOutputDTO>> ObterTodos();
    }
}
