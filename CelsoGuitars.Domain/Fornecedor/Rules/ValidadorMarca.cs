using FluentValidation;

namespace CelsoGuitars.Domain.Fornecedor.Rules
{
    public class ValidadorMarca : AbstractValidator<Marca>
    {
        public ValidadorMarca()
        {
            RuleFor(x => x.Nome).NotEmpty();
        }
    }
}
