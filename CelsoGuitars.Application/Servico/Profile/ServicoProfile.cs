using CelsoGuitars.Application.Servico.DTO;
using CelsoGuitars.Domain.Servico;

namespace CelsoGuitars.Application.Servico.Profile
{
    public class ServicoProfile : AutoMapper.Profile
    {
        public ServicoProfile()
        {
            CreateMap<OrdemServico, OrdemServicoOutputDTO>();
            CreateMap<OrdemServicoInputDTO, OrdemServico>();
            CreateMap<OrdemServicoUpdateDTO, OrdemServico>();

            CreateMap<TipoServico, TipoServicoOutputDTO>();
            CreateMap<TipoServicoInputDTO, TipoServico>();
            CreateMap<TipoServicoUpdateDTO, TipoServico>();
        }
    }
}
