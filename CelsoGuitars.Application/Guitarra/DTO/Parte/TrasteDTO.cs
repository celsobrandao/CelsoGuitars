using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record TrasteOutputDTO(Guid ID,
                                  CorMetalEnum Cor,
                                  MarcaOutputDTO Marca,
                                  string Nome,
                                  string Descricao,
                                  string CodigoFabricante);
}
