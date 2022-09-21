using CelsoGuitars.Domain.Cliente.Rules;
using CelsoGuitars.Domain.Cliente.ValueObject;
using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Infra.Entidade;
using CelsoGuitars.Infra.Utils;
using FluentValidation;

namespace CelsoGuitars.Domain.Cliente
{
    public class Cliente : Entidade<Guid>
    {
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public List<OrdemServico> OrdensServicos { get; set; }

        public void Validar() => new ValidadorCliente().ValidateAndThrow(this);

        public void AtualizarSenha()
        {
            Senha.Valor = SegurancaUtils.HashSHA1(Senha.Valor);
        }
    }
}
