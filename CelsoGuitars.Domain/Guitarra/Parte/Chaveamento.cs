namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public enum TipoChaveamentoEnum : byte
    {
        Switch3Pos = 0,
        Switch5Pos = 1,
        MiniSwitch = 2,
        PotenciometroA = 3,
        PotenciometroB = 4,
        PotenciometroPushPullA = 5,
        PotenciometroPushPullB = 6,
        Outro = byte.MaxValue
    }

    public class Chaveamento : ParteBase
    {
        public TipoChaveamentoEnum TipoChaveamento { get; set; }
        public string TipoChaveamentoOutro { get; set; }

        public List<Guitarra> Guitarras { get; set; }
    }
}