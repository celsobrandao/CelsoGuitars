using CelsoGuitars.Application.Guitarra.DTO;
using CelsoGuitars.Application.Guitarra.DTO.Parte;
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

    public class GetAllPartesQuery : IRequest<GetAllPartesQueryResponse>
    {
    }

    public class GetAllPartesQueryResponse
    {
        public TodasPartesOutputDTO Partes { get; set; }

        public GetAllPartesQueryResponse(TodasPartesOutputDTO partes)
        {
            Partes = partes;
        }
    }
}
