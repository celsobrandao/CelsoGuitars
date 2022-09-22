using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record ChaveamentoInputDTO([Required(ErrorMessage = "O Tipo de Chaveamento deve ser informado.")] TipoChaveamentoEnum TipoChaveamento,
                                      string TipoChaveamentoOutro,
                                      [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                      [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                      string Descricao,
                                      [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record ChaveamentoUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                       [Required(ErrorMessage = "O Tipo de Chaveamento deve ser informado.")] TipoChaveamentoEnum TipoChaveamento,
                                       string TipoChaveamentoOutro,
                                       [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                       [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                       string Descricao,
                                       [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record ChaveamentoOutputDTO(Guid ID,
                                       TipoChaveamentoEnum TipoChaveamento,
                                       string TipoChaveamentoOutro,
                                       MarcaOutputDTO Marca,
                                       string Nome,
                                       string Descricao,
                                       string CodigoFabricante);
}
