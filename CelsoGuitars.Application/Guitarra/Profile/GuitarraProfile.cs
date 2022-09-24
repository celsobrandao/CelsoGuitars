using CelsoGuitars.Application.Guitarra.DTO;
using CelsoGuitars.Application.Guitarra.DTO.Parte;
using CelsoGuitars.Domain.Guitarra.Parte;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Application.Guitarra.Profile
{
    public class GuitarraProfile : AutoMapper.Profile
    {
        public GuitarraProfile()
        {
            #region Parte
            CreateMap<Braco, BracoOutputDTO>();

            CreateMap<Captador, CaptadorOutputDTO>();

            CreateMap<Chaveamento, ChaveamentoOutputDTO>();

            CreateMap<Corpo, CorpoOutputDTO>();

            CreateMap<Madeira, MadeiraOutputDTO>();

            CreateMap<Ponte, PonteOutputDTO>();

            CreateMap<Tarraxa, TarraxaOutputDTO>();

            CreateMap<Traste, TrasteOutputDTO>();
            #endregion

            CreateMap<GuitarraModel, GuitarraOutputDTO>();
            CreateMap<GuitarraInputDTO, GuitarraModel>();
            CreateMap<GuitarraUpdateDTO, GuitarraModel>();
        }
    }
}
