using CelsoGuitars.Domain.Servico.Rules;
using CelsoGuitars.Infra.Entidade;
using FluentValidation;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Domain.Servico
{
    public class OrdemServico : Entidade<Guid>
    {
        public ClienteModel Cliente { get; set; }
        public GuitarraModel Guitarra { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataInicioServico { get; set; }
        public DateTime DataSaidaPrevista { get; set; }
        public DateTime? DataSaidaEfetiva { get; set; }
        public List<TipoServico> TiposServicos { get; set; }
        public decimal ValorPrevisto { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal? ValorEfetivo { get; set; }
        public string Observacoes { get; set; }

        public void Validar() => new ValidadorOrdemServico().ValidateAndThrow(this);
        public void ValidarFinalizacao() => new ValidadorOrdemServicoFinalizacao().ValidateAndThrow(this);

        public void Calcular()
        {
            DataSaidaPrevista = DataInicioServico.AddMinutes(TiposServicos.Sum(ts => ts.MinutosExecucao) * 2);
            ValorPrevisto = TiposServicos.Sum(ts => ts.Valor) * (1 - PercentualDesconto);
        }
    }
}
