using CelsoGuitars.Application.Servico.DTO;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler.Command
{
    public class CriarTipoServicoCommand : IRequest<CriarTipoServicoCommandResponse>
    {
        public TipoServicoInputDTO TipoServico { get; set; }

        public CriarTipoServicoCommand(TipoServicoInputDTO tipoServico)
        {
            TipoServico = tipoServico;
        }
    }

    public class CriarTipoServicoCommandResponse
    {
        public TipoServicoOutputDTO TipoServico { get; set; }

        public CriarTipoServicoCommandResponse(TipoServicoOutputDTO tipoServico)
        {
            TipoServico = tipoServico;
        }
    }

    public class AtualizarTipoServicoCommand : IRequest<AtualizarTipoServicoCommandResponse>
    {
        public TipoServicoUpdateDTO TipoServico { get; set; }

        public AtualizarTipoServicoCommand(TipoServicoUpdateDTO tipoServico)
        {
            TipoServico = tipoServico;
        }
    }

    public class AtualizarTipoServicoCommandResponse
    {
        public TipoServicoOutputDTO TipoServico { get; set; }

        public AtualizarTipoServicoCommandResponse(TipoServicoOutputDTO tipoServico)
        {
            TipoServico = tipoServico;
        }
    }

    public class RemoverTipoServicoCommand : IRequest<RemoverTipoServicoCommandResponse>
    {
        public RemoverTipoServicoCommand(Guid iD)
        {
            ID = iD;
        }

        public Guid ID { get; set; }
    }

    public class RemoverTipoServicoCommandResponse
    {
        public RemoverTipoServicoCommandResponse()
        {
        }
    }
}
