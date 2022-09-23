using CelsoGuitars.Domain.Cliente.Rules;
using CelsoGuitars.Domain.Guitarra.Rules;
using FluentValidation;

namespace CelsoGuitars.Domain.Servico.Rules
{
    public class ValidadorOrdemServico : AbstractValidator<OrdemServico>
    {
        public ValidadorOrdemServico()
        {
            RuleFor(x => x.Cliente).NotNull().SetValidator(new ValidadorCliente());
            RuleFor(x => x.Guitarra).NotNull().SetValidator(new ValidadorGuitarra());
            RuleFor(x => x.DataEntrada).GreaterThan(DateTime.MinValue);
            RuleFor(x => x.DataInicioServico).GreaterThan(DateTime.MinValue);
            RuleFor(x => x.DataSaidaPrevista).GreaterThan(DateTime.MinValue);
            RuleFor(x => x.TiposServicos).NotEmpty();
            RuleFor(x => x.ValorPrevisto).GreaterThan(0);
            RuleFor(x => x.PercentualDesconto).GreaterThanOrEqualTo(0).LessThanOrEqualTo(1);
        }
    }
}
