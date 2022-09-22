using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record TarraxaInputDTO([Required(ErrorMessage = "A Indicação de Trava deve ser informada.")] bool IndicaComTrava,
                                  [Required(ErrorMessage = "A Cor deve ser informada.")] CorMetalEnum Cor,
                                  [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                  [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                  string Descricao,
                                  [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record TarraxaUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                   [Required(ErrorMessage = "A Indicação de Trava deve ser informada.")] bool IndicaComTrava,
                                   [Required(ErrorMessage = "A Cor deve ser informada.")] CorMetalEnum Cor,
                                   [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                   [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                   string Descricao,
                                   [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record TarraxaOutputDTO(Guid ID,
                                   bool IndicaComTrava,
                                   CorMetalEnum Cor,
                                   MarcaOutputDTO Marca,
                                   string Nome,
                                   string Descricao,
                                   string CodigoFabricante);
}
