using CelsoGuitars.Domain.Fornecedor.Rules;
using CelsoGuitars.Infra.Entidade;
using FluentValidation;

namespace CelsoGuitars.Domain.Fornecedor
{
    public class Marca : Entidade<Guid>
    {
        public string Nome { get; set; }

        public void Validar() => new ValidadorMarca().ValidateAndThrow(this);
    }
}