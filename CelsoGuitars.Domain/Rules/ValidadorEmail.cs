using CelsoGuitars.Domain.ValueObject;
using FluentValidation;
using System.Text.RegularExpressions;

namespace CelsoGuitars.Domain.Rules
{
    public class ValidadorEmail : AbstractValidator<Email>
    {
        private const string _padrao = @"^[a-z0-9.]+@[a-z0-9]+(.[a-z]+)+$";

        public ValidadorEmail()
        {
            RuleFor(x => x.Valor)
                .NotEmpty()
                .Must(EmailValido)
                .WithMessage("Email inválido.");
        }

        private bool EmailValido(string valor) => Regex.IsMatch(valor, _padrao);
    }
}
