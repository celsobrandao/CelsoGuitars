using CelsoGuitars.Domain.Servico.Rules;
using CelsoGuitars.Infra.Entidade;
using FluentValidation;

namespace CelsoGuitars.Domain.Servico
{
    public class TipoServico : Entidade<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int MinutosExecucao { get; set; }

        public List<OrdemServico> OrdensServicos { get; set; }

        public void Validar() => new ValidadorTipoServico().ValidateAndThrow(this);
    }
}
