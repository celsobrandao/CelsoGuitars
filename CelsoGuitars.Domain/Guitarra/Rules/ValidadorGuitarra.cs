using CelsoGuitars.Domain.Fornecedor.Rules;
using FluentValidation;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Domain.Guitarra.Rules
{
    public class ValidadorGuitarra : AbstractValidator<GuitarraModel>
    {
        public ValidadorGuitarra()
        {
            RuleFor(x => x.Marca).NotNull().SetValidator(new ValidadorMarca());
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.CodigoFabricante).NotEmpty();
            RuleFor(x => x.Braco).NotNull();
            RuleFor(x => x.Corpo).NotNull();
            RuleFor(x => x.Captadores).NotEmpty();
            RuleFor(x => x.Chaveamentos).NotEmpty();
            RuleFor(x => x.Ponte).NotNull();
            RuleFor(x => x.Tarraxa).NotNull();
            RuleFor(x => x.Traste).NotNull();
            RuleFor(x => x.Foto).NotEmpty();
        }
    }
}
