using CelsoGuitars.Application.Fornecedor.DTO;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record MadeiraInputDTO([Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                  [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                  string Descricao,
                                  [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record MadeiraUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                   [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                   [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                   string Descricao,
                                   [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record MadeiraOutputDTO(Guid ID,
                                   MarcaOutputDTO Marca,
                                   string Nome,
                                   string Descricao,
                                   string CodigoFabricante);
}
