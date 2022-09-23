using CelsoGuitars.Application.Fornecedor.DTO;
using MediatR;

namespace CelsoGuitars.Application.Fornecedor.Handler.Command
{
    public class CriarMarcaCommand : IRequest<CriarMarcaCommandResponse>
    {
        public MarcaInputDTO Marca { get; set; }

        public CriarMarcaCommand(MarcaInputDTO marca)
        {
            Marca = marca;
        }
    }

    public class CriarMarcaCommandResponse
    {
        public MarcaOutputDTO Marca { get; set; }

        public CriarMarcaCommandResponse(MarcaOutputDTO marca)
        {
            Marca = marca;
        }
    }

    public class AtualizarMarcaCommand : IRequest<AtualizarMarcaCommandResponse>
    {
        public MarcaUpdateDTO Marca { get; set; }

        public AtualizarMarcaCommand(MarcaUpdateDTO marca)
        {
            Marca = marca;
        }
    }

    public class AtualizarMarcaCommandResponse
    {
        public MarcaOutputDTO Marca { get; set; }

        public AtualizarMarcaCommandResponse(MarcaOutputDTO marca)
        {
            Marca = marca;
        }
    }

    public class RemoverMarcaCommand : IRequest<RemoverMarcaCommandResponse>
    {
        public RemoverMarcaCommand(Guid iD)
        {
            ID = iD;
        }

        public Guid ID { get; set; }
    }

    public class RemoverMarcaCommandResponse
    {
        public RemoverMarcaCommandResponse()
        {
        }
    }
}
