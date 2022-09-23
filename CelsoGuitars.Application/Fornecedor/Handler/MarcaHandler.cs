using CelsoGuitars.Application.Fornecedor.Handler.Command;
using CelsoGuitars.Application.Fornecedor.Handler.Query;
using CelsoGuitars.Application.Fornecedor.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Fornecedor.Handler
{
    public class MarcaHandler : IRequestHandler<CriarMarcaCommand, CriarMarcaCommandResponse>,
                                IRequestHandler<AtualizarMarcaCommand, AtualizarMarcaCommandResponse>,
                                IRequestHandler<RemoverMarcaCommand, RemoverMarcaCommandResponse>,
                                IRequestHandler<GetAllMarcaQuery, GetAllMarcaQueryResponse>
    {
        private readonly IMarcaService _marcaService;

        public MarcaHandler(IMarcaService marcaService)
        {
            _marcaService = marcaService;
        }

        public async Task<CriarMarcaCommandResponse> Handle(CriarMarcaCommand request, CancellationToken cancellationToken)
        {
            var result = await _marcaService.Criar(request.Marca);

            return new CriarMarcaCommandResponse(result);
        }

        public async Task<AtualizarMarcaCommandResponse> Handle(AtualizarMarcaCommand request, CancellationToken cancellationToken)
        {
            var result = await _marcaService.Atualizar(request.Marca);

            return new AtualizarMarcaCommandResponse(result);
        }

        public async Task<RemoverMarcaCommandResponse> Handle(RemoverMarcaCommand request, CancellationToken cancellationToken)
        {
            await _marcaService.Remover(request.ID);

            return new RemoverMarcaCommandResponse();
        }

        public async Task<GetAllMarcaQueryResponse> Handle(GetAllMarcaQuery request, CancellationToken cancellationToken)
        {
            var result = await _marcaService.ObterTodos();

            return new GetAllMarcaQueryResponse(result);
        }
    }
}
