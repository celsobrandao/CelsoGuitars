using CelsoGuitars.Application.Fornecedor.DTO;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record CorpoInputDTO([Required(ErrorMessage = "O ID da Madeira do Corpo deve ser informado.")] Guid MadeiraCorpoID,
                                Guid MadeiraTopo,
                                string Cor,
                                [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                string Descricao,
                                [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record CorpoUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                 [Required(ErrorMessage = "O ID da Madeira do Corpo deve ser informado.")] Guid MadeiraCorpoID,
                                 Guid MadeiraTopo,
                                 string Cor,
                                 [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                 [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                 string Descricao,
                                 [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record CorpoOutputDTO(Guid ID,
                                 MadeiraOutputDTO MadeiraCorpo,
                                 MadeiraOutputDTO MadeiraTopo,
                                 string Cor,
                                 MarcaOutputDTO Marca,
                                 string Nome,
                                 string Descricao,
                                 string CodigoFabricante);
}
