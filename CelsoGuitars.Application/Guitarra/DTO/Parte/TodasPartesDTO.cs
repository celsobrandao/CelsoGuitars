namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record TodasPartesOutputDTO(List<BracoOutputDTO> Braco,
                                       List<CaptadorOutputDTO> Captador,
                                       List<ChaveamentoOutputDTO> Chaveamento,
                                       List<CorpoOutputDTO> Corpo,
                                       List<MadeiraOutputDTO> Madeira,
                                       List<PonteOutputDTO> Ponte,
                                       List<TarraxaOutputDTO> Tarraxa,
                                       List<TrasteOutputDTO> Traste);
}
