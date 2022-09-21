namespace CelsoGuitars.Domain.Cliente.ValueObject
{
    public class Senha
    {
        public Senha()
        {
        }

        public Senha(string valor)
        {
            Valor = valor ?? throw new ArgumentNullException(nameof(valor));
        }

        public string Valor { get; set; }
    }
}
