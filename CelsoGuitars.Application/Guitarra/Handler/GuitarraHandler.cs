using CelsoGuitars.Application.Guitarra.Handler.Command;
using CelsoGuitars.Application.Guitarra.Handler.Query;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Guitarra.Handler
{
    public class GuitarraHandler : IRequestHandler<CriarGuitarraCommand, CriarGuitarraCommandResponse>,
                                   IRequestHandler<AtualizarGuitarraCommand, AtualizarGuitarraCommandResponse>,
                                   IRequestHandler<RemoverGuitarraCommand, RemoverGuitarraCommandResponse>,
                                   IRequestHandler<GetAllGuitarraQuery, GetAllGuitarraQueryResponse>
    {
        private readonly IGuitarraService _guitarraService;

        public GuitarraHandler(IGuitarraService guitarraService)
        {
            _guitarraService = guitarraService;
        }

        public async Task<CriarGuitarraCommandResponse> Handle(CriarGuitarraCommand request, CancellationToken cancellationToken)
        {
            var result = await _guitarraService.Criar(request.Guitarra);

            return new CriarGuitarraCommandResponse(result);
        }

        public async Task<AtualizarGuitarraCommandResponse> Handle(AtualizarGuitarraCommand request, CancellationToken cancellationToken)
        {
            var result = await _guitarraService.Atualizar(request.Guitarra);

            return new AtualizarGuitarraCommandResponse(result);
        }

        public async Task<RemoverGuitarraCommandResponse> Handle(RemoverGuitarraCommand request, CancellationToken cancellationToken)
        {
            await _guitarraService.Remover(request.ID);

            return new RemoverGuitarraCommandResponse();
        }

        public async Task<GetAllGuitarraQueryResponse> Handle(GetAllGuitarraQuery request, CancellationToken cancellationToken)
        {
            var result = await _guitarraService.ObterTodos();

            return new GetAllGuitarraQueryResponse(result);
        }
    }
}
