using CelsoGuitars.Application.Guitarra.DTO;
using MediatR;

namespace CelsoGuitars.Application.Guitarra.Handler.Query
{
    public class GetAllGuitarraQuery : IRequest<GetAllGuitarraQueryResponse>
    {
    }

    public class GetAllGuitarraQueryResponse
    {
        public IList<GuitarraOutputDTO> Guitarras { get; set; }

        public GetAllGuitarraQueryResponse(IList<GuitarraOutputDTO> guitarras)
        {
            Guitarras = guitarras;
        }
    }
}
