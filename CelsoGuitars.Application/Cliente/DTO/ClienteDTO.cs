using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Cliente.DTO
{
    public record ClienteInputDTO([Required(ErrorMessage = "O Email deve ser informado.")] string Email,
                                  [Required(ErrorMessage = "A Senha deve ser informada.")] string Senha,
                                  [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                  [Required(ErrorMessage = "A Data de Nascimento deve ser informada.")] DateTime DataNascimento);

    public record ClienteUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                   [Required(ErrorMessage = "O Email deve ser informado.")] string Email,
                                   [Required(ErrorMessage = "A Senha deve ser informada.")] string Senha,
                                   [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                   [Required(ErrorMessage = "A Data de Nascimento deve ser informada.")] DateTime DataNascimento);

    public record ClienteOutputDTO(Guid ID,
                                   string Email,
                                   string Nome,
                                   DateTime DataNascimento);

    public record ClienteLoginInputDTO([Required(ErrorMessage = "O Email deve ser informado.")] string Email,
                                       [Required(ErrorMessage = "A Senha deve ser informada.")] string Senha);

    public record ClienteLoginOutputDTO(bool Valido,
                                        string Mensagem,
                                        Guid? ID);
}
