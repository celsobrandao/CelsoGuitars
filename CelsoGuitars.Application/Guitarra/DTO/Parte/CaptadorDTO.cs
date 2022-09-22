using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record CaptadorInputDTO([Required(ErrorMessage = "O Tipo do Captador deve ser informado.")] TipoCaptadorEnum TipoCaptador,
                                   string TipoCaptadorOutro,
                                   [Required(ErrorMessage = "A Resistência deve ser informada.")] decimal Resistencia,
                                   [Required(ErrorMessage = "A Cor do Captador deve ser informada.")] CorCaptadorEnum CorCaptador,
                                   string CorCaptadorOutro,
                                   [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                   [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                   string Descricao,
                                   [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record CaptadorUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                    [Required(ErrorMessage = "O Tipo do Captador deve ser informado.")] TipoCaptadorEnum TipoCaptador,
                                    string TipoCaptadorOutro,
                                    [Required(ErrorMessage = "A Resistência deve ser informada.")] decimal Resistencia,
                                    [Required(ErrorMessage = "A Cor do Captador deve ser informada.")] CorCaptadorEnum CorCaptador,
                                    string CorCaptadorOutro,
                                    [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                    [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                    string Descricao,
                                    [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record CaptadorOutputDTO(Guid ID,
                                    TipoCaptadorEnum TipoCaptador,
                                    string TipoCaptadorOutro,
                                    decimal Resistencia,
                                    CorCaptadorEnum CorCaptador,
                                    string CorCaptadorOutro,
                                    MarcaOutputDTO Marca,
                                    string Nome,
                                    string Descricao,
                                    string CodigoFabricante);
}
