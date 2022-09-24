using CelsoGuitars.Application.Usuario.DTO;
using UsuarioModel = CelsoGuitars.Domain.Usuario.Usuario;

namespace CelsoGuitars.Application.Usuario.Service.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDTO> Criar(UsuarioInputDTO dto);
        Task<UsuarioOutputDTO> Atualizar(UsuarioUpdateDTO dto);
        Task Remover(Guid usuarioID);
        Task<UsuarioLoginOutputDTO> ValidarLogin(UsuarioLoginInputDTO dto);
        Task<UsuarioModel> Obter(Guid usuarioID);
        Task<List<UsuarioOutputDTO>> ObterTodos();
    }
}
