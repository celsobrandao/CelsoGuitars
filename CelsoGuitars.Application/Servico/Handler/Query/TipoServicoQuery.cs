using CelsoGuitars.Application.Servico.DTO;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler.Query
{
    public class GetAllTipoServicoQuery : IRequest<GetAllTipoServicoQueryResponse>
    {
    }

    public class GetAllTipoServicoQueryResponse
    {
        public IList<TipoServicoOutputDTO> TiposServicos { get; set; }

        public GetAllTipoServicoQueryResponse(IList<TipoServicoOutputDTO> tiposServicos)
        {
            TiposServicos = tiposServicos;
        }
    }
}
