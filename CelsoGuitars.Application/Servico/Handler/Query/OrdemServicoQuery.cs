using CelsoGuitars.Application.Servico.DTO;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler.Query
{
    public class GetByClienteOrdemServicoCommand : IRequest<GetByClienteOrdemServicoCommandResponse>
    {
        public Guid ClienteID { get; set; }

        public GetByClienteOrdemServicoCommand(Guid clienteID)
        {
            ClienteID = clienteID;
        }
    }

    public class GetByClienteOrdemServicoCommandResponse
    {
        public List<OrdemServicoOutputDTO> OrdensServicos { get; set; }

        public GetByClienteOrdemServicoCommandResponse(List<OrdemServicoOutputDTO> ordensServicos)
        {
            OrdensServicos = ordensServicos;
        }
    }

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
