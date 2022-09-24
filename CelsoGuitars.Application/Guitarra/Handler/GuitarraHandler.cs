using CelsoGuitars.Application.Guitarra.Handler.Command;
using CelsoGuitars.Application.Guitarra.Handler.Query;
using CelsoGuitars.Application.Guitarra.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Guitarra.Handler
{
    public class GuitarraHandler : IRequestHandler<CriarGuitarraCommand, CriarGuitarraCommandResponse>,
                                   IRequestHandler<AtualizarGuitarraCommand, AtualizarGuitarraCommandResponse>,
                                   IRequestHandler<RemoverGuitarraCommand, RemoverGuitarraCommandResponse>,
                                   IRequestHandler<GetAllGuitarraQuery, GetAllGuitarraQueryResponse>,
                                   IRequestHandler<GetAllPartesQuery, GetAllPartesQueryResponse>
    {
        private readonly IGuitarraService _guitarraService;
        private readonly IParteService _parteService;

        public GuitarraHandler(IGuitarraService guitarraService,
                               IParteService parteService)
        {
            _guitarraService = guitarraService;
            _parteService = parteService;
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

        public async Task<GetAllPartesQueryResponse> Handle(GetAllPartesQuery request, CancellationToken cancellationToken)
        {
            var result = await _parteService.ObterTodos();

            return new GetAllPartesQueryResponse(result);
        }
    }
}
