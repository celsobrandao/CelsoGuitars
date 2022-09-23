using CelsoGuitars.Application.Cliente.DTO;
using MediatR;

namespace CelsoGuitars.Application.Cliente.Handler.Query
{
    public class GetAllClienteQuery : IRequest<GetAllClienteQueryResponse>
    {
    }

    public class GetAllClienteQueryResponse
    {
        public IList<ClienteOutputDTO> Clientes { get; set; }

        public GetAllClienteQueryResponse(IList<ClienteOutputDTO> clientes)
        {
            Clientes = clientes;
        }
    }
}
