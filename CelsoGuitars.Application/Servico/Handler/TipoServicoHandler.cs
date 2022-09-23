using CelsoGuitars.Application.Servico.Handler.Command;
using CelsoGuitars.Application.Servico.Handler.Query;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler
{
    public class TipoServicoHandler : IRequestHandler<CriarTipoServicoCommand, CriarTipoServicoCommandResponse>,
                                      IRequestHandler<AtualizarTipoServicoCommand, AtualizarTipoServicoCommandResponse>,
                                      IRequestHandler<RemoverTipoServicoCommand, RemoverTipoServicoCommandResponse>,
                                      IRequestHandler<GetAllTipoServicoQuery, GetAllTipoServicoQueryResponse>
    {
        private readonly ITipoServicoService _tipoServicoService;

        public TipoServicoHandler(ITipoServicoService tipoServicoService)
        {
            _tipoServicoService = tipoServicoService;
        }

        public async Task<CriarTipoServicoCommandResponse> Handle(CriarTipoServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _tipoServicoService.Criar(request.TipoServico);

            return new CriarTipoServicoCommandResponse(result);
        }

        public async Task<AtualizarTipoServicoCommandResponse> Handle(AtualizarTipoServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _tipoServicoService.Atualizar(request.TipoServico);

            return new AtualizarTipoServicoCommandResponse(result);
        }

        public async Task<RemoverTipoServicoCommandResponse> Handle(RemoverTipoServicoCommand request, CancellationToken cancellationToken)
        {
            await _tipoServicoService.Remover(request.ID);

            return new RemoverTipoServicoCommandResponse();
        }

        public async Task<GetAllTipoServicoQueryResponse> Handle(GetAllTipoServicoQuery request, CancellationToken cancellationToken)
        {
            var result = await _tipoServicoService.ObterTodos();

            return new GetAllTipoServicoQueryResponse(result);
        }
    }
}
