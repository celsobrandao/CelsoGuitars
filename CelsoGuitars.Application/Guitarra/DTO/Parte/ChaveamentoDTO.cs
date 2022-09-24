using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record ChaveamentoOutputDTO(Guid ID,
                                       TipoChaveamentoEnum TipoChaveamento,
                                       string TipoChaveamentoOutro,
                                       MarcaOutputDTO Marca,
                                       string Nome,
                                       string Descricao,
                                       string CodigoFabricante);
}
