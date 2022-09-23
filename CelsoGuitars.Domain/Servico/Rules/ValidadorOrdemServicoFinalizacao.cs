using FluentValidation;

namespace CelsoGuitars.Domain.Servico.Rules
{
    public class ValidadorOrdemServicoFinalizacao : AbstractValidator<OrdemServico>
    {
        public ValidadorOrdemServicoFinalizacao()
        {
            RuleFor(x => x.DataSaidaEfetiva).GreaterThan(DateTime.MinValue);
            RuleFor(x => x.ValorEfetivo).GreaterThanOrEqualTo(0);
        }
    }
}
