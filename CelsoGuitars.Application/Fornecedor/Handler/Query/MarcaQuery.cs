using CelsoGuitars.Application.Fornecedor.DTO;
using MediatR;

namespace CelsoGuitars.Application.Fornecedor.Handler.Query
{
    public class GetAllMarcaQuery : IRequest<GetAllMarcaQueryResponse>
    {
    }

    public class GetAllMarcaQueryResponse
    {
        public IList<MarcaOutputDTO> Marcas { get; set; }

        public GetAllMarcaQueryResponse(IList<MarcaOutputDTO> marcas)
        {
            Marcas = marcas;
        }
    }
}
