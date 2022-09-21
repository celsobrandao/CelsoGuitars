using CelsoGuitars.Domain.Fornecedor;
using CelsoGuitars.Infra.Entidade;

namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public abstract class ParteBase : Entidade<Guid>
    {
        public Marca Marca { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoFabricante { get; set; }
    }
}
