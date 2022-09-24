using CelsoGuitars.Application.Cliente.DTO;
using MediatR;

namespace CelsoGuitars.Application.Cliente.Handler.Command
{
    public class CriarClienteCommand : IRequest<CriarClienteCommandResponse>
    {
        public ClienteInputDTO Cliente { get; set; }

        public CriarClienteCommand(ClienteInputDTO cliente)
        {
            Cliente = cliente;
        }
    }

    public class CriarClienteCommandResponse
    {
        public ClienteOutputDTO Cliente { get; set; }

        public CriarClienteCommandResponse(ClienteOutputDTO cliente)
        {
            Cliente = cliente;
        }
    }

    public class AtualizarClienteCommand : IRequest<AtualizarClienteCommandResponse>
    {
        public ClienteUpdateDTO Cliente { get; set; }

        public AtualizarClienteCommand(ClienteUpdateDTO cliente)
        {
            Cliente = cliente;
        }
    }

    public class AtualizarClienteCommandResponse
    {
        public ClienteOutputDTO Cliente { get; set; }

        public AtualizarClienteCommandResponse(ClienteOutputDTO cliente)
        {
            Cliente = cliente;
        }
    }

    public class RemoverClienteCommand : IRequest<RemoverClienteCommandResponse>
    {
        public RemoverClienteCommand(Guid iD)
        {
            ID = iD;
        }

        public Guid ID { get; set; }
    }

    public class RemoverClienteCommandResponse
    {
        public RemoverClienteCommandResponse()
        {
        }
    }
}
