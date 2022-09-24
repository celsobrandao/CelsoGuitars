using CelsoGuitars.Domain.Cliente.Rules;
using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.ValueObject;
using CelsoGuitars.Infra.Entidade;
using FluentValidation;

namespace CelsoGuitars.Domain.Cliente
{
    public class Cliente : Entidade<Guid>
    {
        public Email Email { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public List<OrdemServico> OrdensServicos { get; set; }

        public void Validar() => new ValidadorCliente().ValidateAndThrow(this);
    }
}
