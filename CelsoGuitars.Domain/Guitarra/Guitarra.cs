using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Rules;
using FluentValidation;

namespace CelsoGuitars.Domain.Guitarra
{
    public enum ConfiguracaoCaptadoresEnum : byte
    {
        HH = 0,
        SSS = 1,
        HSS = 2,
        SS = 3,
        HSH = 4,
        H = 5,
        S = 6,
        Outro = byte.MaxValue
    }

    public class Guitarra : ParteBase
    {
        public Braco Braco { get; set; }
        public Corpo Corpo { get; set; }
        public ConfiguracaoCaptadoresEnum ConfiguracaoCaptadores { get; set; }
        public string ConfiguracaoCaptadoresOutro { get; set; }
        public List<Captador> Captadores { get; set; }
        public List<Chaveamento> Chaveamentos { get; set; }
        public Ponte Ponte { get; set; }
        public Tarraxa Tarraxa { get; set; }
        public Traste Traste { get; set; }
        public string Foto { get; set; }

        public void Validar() => new ValidadorGuitarra().ValidateAndThrow(this);
    }
}
