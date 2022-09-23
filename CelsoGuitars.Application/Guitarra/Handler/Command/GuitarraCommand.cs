using CelsoGuitars.Application.Guitarra.DTO;
using MediatR;

namespace CelsoGuitars.Application.Guitarra.Handler.Command
{
    public class CriarGuitarraCommand : IRequest<CriarGuitarraCommandResponse>
    {
        public GuitarraInputDTO Guitarra { get; set; }

        public CriarGuitarraCommand(GuitarraInputDTO guitarra)
        {
            Guitarra = guitarra;
        }
    }

    public class CriarGuitarraCommandResponse
    {
        public GuitarraOutputDTO Guitarra { get; set; }

        public CriarGuitarraCommandResponse(GuitarraOutputDTO guitarra)
        {
            Guitarra = guitarra;
        }
    }

    public class AtualizarGuitarraCommand : IRequest<AtualizarGuitarraCommandResponse>
    {
        public GuitarraUpdateDTO Guitarra { get; set; }

        public AtualizarGuitarraCommand(GuitarraUpdateDTO guitarra)
        {
            Guitarra = guitarra;
        }
    }

    public class AtualizarGuitarraCommandResponse
    {
        public GuitarraOutputDTO Guitarra { get; set; }

        public AtualizarGuitarraCommandResponse(GuitarraOutputDTO guitarra)
        {
            Guitarra = guitarra;
        }
    }

    public class RemoverGuitarraCommand : IRequest<RemoverGuitarraCommandResponse>
    {
        public RemoverGuitarraCommand(Guid iD)
        {
            ID = iD;
        }

        public Guid ID { get; set; }
    }

    public class RemoverGuitarraCommandResponse
    {
        public RemoverGuitarraCommandResponse()
        {
        }
    }
}
