using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
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
