using CelsoGuitars.Application.Cliente.DTO;
using CelsoGuitars.Application.Guitarra.DTO;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Servico.DTO
{
    public record OrdemServicoInputDTO([Required(ErrorMessage = "O ID do Cliente deve ser informado.")] Guid ClienteID,
                                       [Required(ErrorMessage = "O ID da Guitarra deve ser informado.")] Guid GuitarraID,
                                       [Required(ErrorMessage = "A Data de Entrada deve ser informada.")] DateTime DataEntrada,
                                       [Required(ErrorMessage = "A Data de Início do Serviço deve ser informada.")] DateTime DataInicioServico,
                                       [Required(ErrorMessage = "Os IDs dos Tipos de Serviços devem ser informados.")] List<Guid> TiposServicosIDs,
                                       [Required(ErrorMessage = "O Percentual de Desconto deve ser informado.")] decimal PercentualDesconto,
                                       string Observacoes);

    public record OrdemServicoUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                        [Required(ErrorMessage = "O ID do Cliente deve ser informado.")] Guid ClienteID,
                                        [Required(ErrorMessage = "O ID da Guitarra deve ser informado.")] Guid GuitarraID,
                                        [Required(ErrorMessage = "A Data de Entrada deve ser informada.")] DateTime DataEntrada,
                                        [Required(ErrorMessage = "A Data de Início do Serviço deve ser informada.")] DateTime DataInicioServico,
                                        [Required(ErrorMessage = "Os IDs dos Tipos de Serviços devem ser informados.")] List<Guid> TiposServicosIDs,
                                        [Required(ErrorMessage = "O Percentual de Desconto deve ser informado.")] decimal PercentualDesconto,
                                        string Observacoes);

    public record OrdemServicoOutputDTO(Guid ID,
                                        ClienteOutputDTO Cliente,
                                        GuitarraOutputDTO Guitarra,
                                        DateTime DataEntrada,
                                        DateTime DataInicioServico,
                                        DateTime DataSaidaPrevista,
                                        DateTime? DataSaidaEfetiva,
                                        List<TipoServicoOutputDTO> TiposServicos,
                                        decimal ValorPrevisto,
                                        decimal PercentualDesconto,
                                        decimal? ValorEfetivo,
                                        string Observacoes);


    public record OrdemServicoFinalizarInputDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                                [Required(ErrorMessage = "A Data de Saída Efetiva deve ser informada.")] DateTime DataSaidaEfetiva,
                                                [Required(ErrorMessage = "O Valor Efetivo deve ser informado.")] decimal ValorEfetivo,
                                                string ObservacoesComplementares);
}
