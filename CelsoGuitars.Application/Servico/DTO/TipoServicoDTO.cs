using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Servico.DTO
{
    public record TipoServicoInputDTO([Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                      string Descricao,
                                      [Required(ErrorMessage = "O Valor deve ser informado.")] decimal Valor,
                                      [Required(ErrorMessage = "Os Minutos para Execução devem ser informados.")] int MinutosExecucao);

    public record TipoServicoUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                       [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                       string Descricao,
                                       [Required(ErrorMessage = "O Valor deve ser informado.")] decimal Valor,
                                       [Required(ErrorMessage = "Os Minutos para Execução devem ser informados.")] int MinutosExecucao);

    public record TipoServicoOutputDTO(Guid ID,
                                       string Nome,
                                       string Descricao,
                                       decimal Valor,
                                       int MinutosExecucao);
}
