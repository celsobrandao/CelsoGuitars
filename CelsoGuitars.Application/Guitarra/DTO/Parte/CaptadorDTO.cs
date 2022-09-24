using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
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
