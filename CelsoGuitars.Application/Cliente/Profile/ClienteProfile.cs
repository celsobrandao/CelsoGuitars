using CelsoGuitars.Application.Cliente.DTO;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Application.Cliente.Profile
{
    public class ClienteProfile : AutoMapper.Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteModel, ClienteOutputDTO>()
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Email.Valor));
            CreateMap<ClienteInputDTO, ClienteModel>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));
            CreateMap<ClienteUpdateDTO, ClienteModel>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));
        }
    }
}
