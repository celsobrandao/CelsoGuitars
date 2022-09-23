using CelsoGuitars.Application.Cliente.DTO;

namespace CelsoGuitars.Application.Cliente.Service.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteOutputDTO> Criar(ClienteInputDTO dto);
        Task<ClienteOutputDTO> Atualizar(ClienteUpdateDTO dto);
        Task Remover(Guid clienteID);
        Task<ClienteLoginOutputDTO> ValidarLogin(ClienteLoginInputDTO dto);
        Task<List<ClienteOutputDTO>> ObterTodos();
    }
}
