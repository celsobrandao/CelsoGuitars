using CelsoGuitars.Application.Servico.DTO;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler.Command
{
    public class CriarOrdemServicoCommand : IRequest<CriarOrdemServicoCommandResponse>
    {
        public OrdemServicoInputDTO OrdemServico { get; set; }

        public CriarOrdemServicoCommand(OrdemServicoInputDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class CriarOrdemServicoCommandResponse
    {
        public OrdemServicoOutputDTO OrdemServico { get; set; }

        public CriarOrdemServicoCommandResponse(OrdemServicoOutputDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class AtualizarOrdemServicoCommand : IRequest<AtualizarOrdemServicoCommandResponse>
    {
        public OrdemServicoUpdateDTO OrdemServico { get; set; }

        public AtualizarOrdemServicoCommand(OrdemServicoUpdateDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class AtualizarOrdemServicoCommandResponse
    {
        public OrdemServicoOutputDTO OrdemServico { get; set; }

        public AtualizarOrdemServicoCommandResponse(OrdemServicoOutputDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class FinalizarOrdemServicoCommand : IRequest<FinalizarOrdemServicoCommandResponse>
    {
        public OrdemServicoFinalizarInputDTO OrdemServico { get; set; }

        public FinalizarOrdemServicoCommand(OrdemServicoFinalizarInputDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class FinalizarOrdemServicoCommandResponse
    {
        public OrdemServicoOutputDTO OrdemServico { get; set; }

        public FinalizarOrdemServicoCommandResponse(OrdemServicoOutputDTO ordemServico)
        {
            OrdemServico = ordemServico;
        }
    }

    public class RemoverOrdemServicoCommand : IRequest<RemoverOrdemServicoCommandResponse>
    {
        public RemoverOrdemServicoCommand(Guid iD)
        {
            ID = iD;
        }

        public Guid ID { get; set; }
    }

    public class RemoverOrdemServicoCommandResponse
    {
        public RemoverOrdemServicoCommandResponse()
        {
        }
    }
}
