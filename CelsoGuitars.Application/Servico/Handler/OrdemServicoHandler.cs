using CelsoGuitars.Application.Servico.Handler.Command;
using CelsoGuitars.Application.Servico.Handler.Query;
using CelsoGuitars.Application.Servico.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Servico.Handler
{
    public class OrdemServicoHandler : IRequestHandler<CriarOrdemServicoCommand, CriarOrdemServicoCommandResponse>,
                                       IRequestHandler<AtualizarOrdemServicoCommand, AtualizarOrdemServicoCommandResponse>,
                                       IRequestHandler<GetByClienteOrdemServicoCommand, GetByClienteOrdemServicoCommandResponse>,
                                       IRequestHandler<FinalizarOrdemServicoCommand, FinalizarOrdemServicoCommandResponse>,
                                       IRequestHandler<RemoverOrdemServicoCommand, RemoverOrdemServicoCommandResponse>,
                                       IRequestHandler<GetAllOrdemServicoQuery, GetAllOrdemServicoQueryResponse>
    {
        private readonly IOrdemServicoService _ordemServicoService;

        public OrdemServicoHandler(IOrdemServicoService ordemServicoService)
        {
            _ordemServicoService = ordemServicoService;
        }

        public async Task<CriarOrdemServicoCommandResponse> Handle(CriarOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _ordemServicoService.Criar(request.OrdemServico);

            return new CriarOrdemServicoCommandResponse(result);
        }

        public async Task<AtualizarOrdemServicoCommandResponse> Handle(AtualizarOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _ordemServicoService.Atualizar(request.OrdemServico);

            return new AtualizarOrdemServicoCommandResponse(result);
        }

        public async Task<GetByClienteOrdemServicoCommandResponse> Handle(GetByClienteOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _ordemServicoService.ObterPorCliente(request.ClienteID);

            return new GetByClienteOrdemServicoCommandResponse(result);
        }

        public async Task<FinalizarOrdemServicoCommandResponse> Handle(FinalizarOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            var result = await _ordemServicoService.Finalizar(request.OrdemServico);

            return new FinalizarOrdemServicoCommandResponse(result);
        }

        public async Task<RemoverOrdemServicoCommandResponse> Handle(RemoverOrdemServicoCommand request, CancellationToken cancellationToken)
        {
            await _ordemServicoService.Remover(request.ID);

            return new RemoverOrdemServicoCommandResponse();
        }

        public async Task<GetAllOrdemServicoQueryResponse> Handle(GetAllOrdemServicoQuery request, CancellationToken cancellationToken)
        {
            var result = await _ordemServicoService.ObterTodos();

            return new GetAllOrdemServicoQueryResponse(result);
        }
    }
}
