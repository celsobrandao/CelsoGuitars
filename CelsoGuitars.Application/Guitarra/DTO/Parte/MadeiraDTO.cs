using CelsoGuitars.Application.Fornecedor.DTO;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record MadeiraOutputDTO(Guid ID,
                                   MarcaOutputDTO Marca,
                                   string Nome,
                                   string Descricao,
                                   string CodigoFabricante);
}
