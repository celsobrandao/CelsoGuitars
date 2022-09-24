using CelsoGuitars.Domain.Usuario.Rules;
using CelsoGuitars.Domain.Usuario.ValueObject;
using CelsoGuitars.Domain.ValueObject;
using CelsoGuitars.Infra.Entidade;
using CelsoGuitars.Infra.Utils;
using FluentValidation;

namespace CelsoGuitars.Domain.Usuario
{
    public class Usuario : Entidade<Guid>
    {
        public Email Email { get; set; }
        public Senha Senha { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void Validar() => new ValidadorUsuario().ValidateAndThrow(this);

        public void AtualizarSenha()
        {
            Senha.Valor = SegurancaUtils.HashSHA1(Senha.Valor);
        }
    }
}
