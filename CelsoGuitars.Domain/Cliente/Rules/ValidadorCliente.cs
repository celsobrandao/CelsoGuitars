using CelsoGuitars.Domain.Rules;
using FluentValidation;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Domain.Cliente.Rules
{
    public class ValidadorCliente : AbstractValidator<ClienteModel>
    {
        public ValidadorCliente()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Email).SetValidator(new ValidadorEmail());
        }
    }
}
