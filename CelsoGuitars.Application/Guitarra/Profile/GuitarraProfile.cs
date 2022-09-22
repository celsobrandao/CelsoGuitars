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
            CreateMap<BracoInputDTO, Braco>();
            CreateMap<BracoUpdateDTO, Braco>();

            CreateMap<Captador, CaptadorOutputDTO>();
            CreateMap<CaptadorInputDTO, Captador>();
            CreateMap<CaptadorUpdateDTO, Captador>();

            CreateMap<Chaveamento, ChaveamentoOutputDTO>();
            CreateMap<ChaveamentoInputDTO, Chaveamento>();
            CreateMap<ChaveamentoUpdateDTO, Chaveamento>();

            CreateMap<Corpo, CorpoOutputDTO>();
            CreateMap<CorpoInputDTO, Corpo>();
            CreateMap<CorpoUpdateDTO, Corpo>();

            CreateMap<Madeira, MadeiraOutputDTO>();
            CreateMap<MadeiraInputDTO, Madeira>();
            CreateMap<MadeiraUpdateDTO, Madeira>();

            CreateMap<Ponte, PonteOutputDTO>();
            CreateMap<PonteInputDTO, Ponte>();
            CreateMap<PonteUpdateDTO, Ponte>();

            CreateMap<Tarraxa, TarraxaOutputDTO>();
            CreateMap<TarraxaInputDTO, Tarraxa>();
            CreateMap<TarraxaUpdateDTO, Tarraxa>();

            CreateMap<Traste, TrasteOutputDTO>();
            CreateMap<TrasteInputDTO, Traste>();
            CreateMap<TrasteUpdateDTO, Traste>();
            #endregion

            CreateMap<GuitarraModel, GuitarraOutputDTO>();
            CreateMap<GuitarraInputDTO, GuitarraModel>();
            CreateMap<GuitarraUpdateDTO, GuitarraModel>();

        }
    }
}
