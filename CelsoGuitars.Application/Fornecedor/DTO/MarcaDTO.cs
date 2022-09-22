using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Fornecedor.DTO
{
    public record MarcaInputDTO([Required(ErrorMessage = "O Nome deve ser informado.")] string Nome);

    public record MarcaUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                 [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome);

    public record MarcaOutputDTO(Guid ID,
                                 string Nome);
}
