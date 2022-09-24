using CelsoGuitars.Application.Guitarra.DTO.Parte;
using CelsoGuitars.Domain.Guitarra.Parte;

namespace CelsoGuitars.Application.Guitarra.Service.Interfaces
{
    public interface IParteService
    {
        Task<Braco> GetBraco(Guid id);
        Task<Captador> GetCaptador(Guid id);
        Task<Chaveamento> GetChaveamento(Guid id);
        Task<Corpo> GetCorpo(Guid id);
        Task<Madeira> GetMadeira(Guid id);
        Task<Ponte> GetPonte(Guid id);
        Task<Tarraxa> GetTarraxa(Guid id);
        Task<Traste> GetTraste(Guid id);
        Task<TodasPartesOutputDTO> ObterTodos();
    }
}
