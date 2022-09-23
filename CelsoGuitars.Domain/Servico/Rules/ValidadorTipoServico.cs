using FluentValidation;

namespace CelsoGuitars.Domain.Servico.Rules
{
    public class ValidadorTipoServico : AbstractValidator<TipoServico>
    {
        public ValidadorTipoServico()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Valor).GreaterThanOrEqualTo(0);
            RuleFor(x => x.MinutosExecucao).GreaterThanOrEqualTo(0);
        }
    }
}
