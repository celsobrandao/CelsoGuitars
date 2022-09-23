using CelsoGuitars.Application.Servico.DTO;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler.Query
{
    public class GetAllOrdemServicoQuery : IRequest<GetAllOrdemServicoQueryResponse>
    {
    }

    public class GetAllOrdemServicoQueryResponse
    {
        public IList<OrdemServicoOutputDTO> OrdensServicos { get; set; }

        public GetAllOrdemServicoQueryResponse(IList<OrdemServicoOutputDTO> ordensServico)
        {
            OrdensServicos = ordensServico;
        }
    }
}
