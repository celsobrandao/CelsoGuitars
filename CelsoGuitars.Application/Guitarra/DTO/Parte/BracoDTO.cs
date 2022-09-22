using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record BracoInputDTO([Required(ErrorMessage = "O ID da Madeira do Braço deve ser informado.")] Guid MadeiraBracoID,
                                [Required(ErrorMessage = "O ID da Madeira da Escala deve ser informado.")] Guid MadeiraEscalaID,
                                [Required(ErrorMessage = "O Comprimento da Escala deve ser informado.")] decimal ComprimentoEscala,
                                [Required(ErrorMessage = "A Quantidade de Trastes deve ser informada.")] byte QuantidadeTrastes,
                                [Required(ErrorMessage = "O Formato do Braço deve ser informado.")] FormatoBracoEnum Formato,
                                string FormatoOutro,
                                [Required(ErrorMessage = "O Raio da Escala deve ser informado.")] decimal RaioEscala,
                                [Required(ErrorMessage = "A Junção do Braço deve ser informada.")] JuncaoBracoEnum JuncaoBraco,
                                string JuncaoBracoOutro,
                                [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                string Descricao,
                                [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record BracoUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                 [Required(ErrorMessage = "O ID da Madeira do Braço deve ser informado.")] Guid MadeiraBracoID,
                                 [Required(ErrorMessage = "O ID da Madeira da Escala deve ser informado.")] Guid MadeiraEscalaID,
                                 [Required(ErrorMessage = "O Comprimento da Escala deve ser informado.")] decimal ComprimentoEscala,
                                 [Required(ErrorMessage = "A Quantidade de Trastes deve ser informada.")] byte QuantidadeTrastes,
                                 [Required(ErrorMessage = "O Formato do Braço deve ser informado.")] FormatoBracoEnum Formato,
                                 string FormatoOutro,
                                 [Required(ErrorMessage = "O Raio da Escala deve ser informado.")] decimal RaioEscala,
                                 [Required(ErrorMessage = "A Junção do Braço deve ser informado.")] JuncaoBracoEnum JuncaoBraco,
                                 string JuncaoBracoOutro,
                                 [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                 [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                 string Descricao,
                                 [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record BracoOutputDTO(Guid ID,
                                 MadeiraOutputDTO MadeiraBraco,
                                 MadeiraOutputDTO MadeiraEscala,
                                 decimal ComprimentoEscala,
                                 byte QuantidadeTrastes,
                                 FormatoBracoEnum Formato,
                                 string FormatoOutro,
                                 decimal RaioEscala,
                                 JuncaoBracoEnum JuncaoBraco,
                                 string JuncaoBracoOutro,
                                 MarcaOutputDTO Marca,
                                 string Nome,
                                 string Descricao,
                                 string CodigoFabricante);
}
