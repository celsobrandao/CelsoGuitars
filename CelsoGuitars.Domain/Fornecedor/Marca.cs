using CelsoGuitars.Infra.Entidade;

namespace CelsoGuitars.Domain.Fornecedor
{
    public class Marca : Entidade<Guid>
    {
        public string Nome { get; set; }
    }
}