using CelsoGuitars.Application.Fornecedor.DTO;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record CorpoOutputDTO(Guid ID,
                                 MadeiraOutputDTO MadeiraCorpo,
                                 MadeiraOutputDTO MadeiraTopo,
                                 string Cor,
                                 MarcaOutputDTO Marca,
                                 string Nome,
                                 string Descricao,
                                 string CodigoFabricante);
}
