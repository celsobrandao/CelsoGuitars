using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Application.Guitarra.DTO.Parte;
using CelsoGuitars.Domain.Guitarra;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO
{
    public record GuitarraInputDTO([Required(ErrorMessage = "O ID do Braço deve ser informado.")] Guid BracoID,
                                   [Required(ErrorMessage = "O ID do Corpo deve ser informado.")] Guid CorpoID,
                                   [Required(ErrorMessage = "A Configuração dos Captadores deve ser informada.")] ConfiguracaoCaptadoresEnum ConfiguracaoCaptadores,
                                   string ConfiguracaoCaptadoresOutro,
                                   [Required(ErrorMessage = "Os IDs de Captadores devem ser informados.")] List<Guid> CaptadoresIDs,
                                   [Required(ErrorMessage = "Os IDs de Chaveamentos devem ser informados.")] List<Guid> ChaveamentoIDs,
                                   [Required(ErrorMessage = "O ID da Ponte deve ser informado.")] Guid PonteID,
                                   [Required(ErrorMessage = "O ID das Tarraxas deve ser informado.")] Guid TarraxaID,
                                   [Required(ErrorMessage = "O ID dos Trastes deve ser informado.")] Guid TrasteID,
                                   [Required(ErrorMessage = "A Junção do Braço deve ser informada.")] string FotoUrl,
                                   [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                   [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                   string Descricao,
                                   [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record GuitarraUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                    [Required(ErrorMessage = "O ID do Braço deve ser informado.")] Guid BracoID,
                                    [Required(ErrorMessage = "O ID do Corpo deve ser informado.")] Guid CorpoID,
                                    [Required(ErrorMessage = "A Configuração dos Captadores deve ser informada.")] ConfiguracaoCaptadoresEnum ConfiguracaoCaptadores,
                                    string ConfiguracaoCaptadoresOutro,
                                    [Required(ErrorMessage = "Os IDs de Captadores devem ser informados.")] List<Guid> CaptadoresIDs,
                                    [Required(ErrorMessage = "Os IDs de Chaveamentos devem ser informados.")] List<Guid> ChaveamentoIDs,
                                    [Required(ErrorMessage = "O ID da Ponte deve ser informado.")] Guid PonteID,
                                    [Required(ErrorMessage = "O ID das Tarraxas deve ser informado.")] Guid TarraxaID,
                                    [Required(ErrorMessage = "O ID dos Trastes deve ser informado.")] Guid TrasteID,
                                    [Required(ErrorMessage = "A Junção do Braço deve ser informada.")] string FotoUrl,
                                    [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                    [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                    string Descricao,
                                    [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record GuitarraOutputDTO(Guid ID,
                                    BracoOutputDTO Braco,
                                    CorpoOutputDTO Corpo,
                                    ConfiguracaoCaptadoresEnum ConfiguracaoCaptadores,
                                    string ConfiguracaoCaptadoresOutro,
                                    List<CaptadorOutputDTO> Captadores,
                                    List<ChaveamentoOutputDTO> Chaveamento,
                                    PonteOutputDTO Ponte,
                                    TarraxaOutputDTO Tarraxa,
                                    TrasteOutputDTO Traste,
                                    string Foto,
                                    MarcaOutputDTO Marca,
                                    string Nome,
                                    string Descricao,
                                    string CodigoFabricante);
}
