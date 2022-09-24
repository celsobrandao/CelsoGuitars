using CelsoGuitars.Application.Usuario.DTO;
using UsuarioModel = CelsoGuitars.Domain.Usuario.Usuario;

namespace CelsoGuitars.Application.Usuario.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioModel, UsuarioOutputDTO>()
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Email.Valor));
            CreateMap<UsuarioInputDTO, UsuarioModel>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));
            CreateMap<UsuarioUpdateDTO, UsuarioModel>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));
        }
    }
}
