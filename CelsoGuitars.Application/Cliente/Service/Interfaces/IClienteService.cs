using CelsoGuitars.Application.Cliente.DTO;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Application.Cliente.Service.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteOutputDTO> Criar(ClienteInputDTO dto);
        Task<ClienteOutputDTO> Atualizar(ClienteUpdateDTO dto);
        Task Remover(Guid clienteID);
        Task<ClienteModel> Obter(Guid clienteID);
        Task<List<ClienteOutputDTO>> ObterTodos();
    }
}
