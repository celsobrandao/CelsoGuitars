using CelsoGuitars.Application.Cliente.Handler.Command;
using CelsoGuitars.Application.Cliente.Handler.Query;
using CelsoGuitars.Application.Cliente.Service.Interfaces;
using MediatR;

namespace CelsoGuitars.Application.Cliente.Handler
{
    public class ClienteHandler : IRequestHandler<CriarClienteCommand, CriarClienteCommandResponse>,
                                  IRequestHandler<AtualizarClienteCommand, AtualizarClienteCommandResponse>,
                                  IRequestHandler<RemoverClienteCommand, RemoverClienteCommandResponse>,
                                  IRequestHandler<GetAllClienteQuery, GetAllClienteQueryResponse>
    {
        private readonly IClienteService _clienteService;

        public ClienteHandler(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<CriarClienteCommandResponse> Handle(CriarClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.Criar(request.Cliente);

            return new CriarClienteCommandResponse(result);
        }

        public async Task<AtualizarClienteCommandResponse> Handle(AtualizarClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.Atualizar(request.Cliente);

            return new AtualizarClienteCommandResponse(result);
        }

        public async Task<RemoverClienteCommandResponse> Handle(RemoverClienteCommand request, CancellationToken cancellationToken)
        {
            await _clienteService.Remover(request.ID);

            return new RemoverClienteCommandResponse();
        }

        public async Task<GetAllClienteQueryResponse> Handle(GetAllClienteQuery request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.ObterTodos();

            return new GetAllClienteQueryResponse(result);
        }
    }
}
