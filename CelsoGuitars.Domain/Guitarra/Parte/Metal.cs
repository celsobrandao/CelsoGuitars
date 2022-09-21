namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public enum CorMetalEnum : byte
    {
        Cromado = 0,
        Dourado = 1,
        Preto = 2,
        Outro = byte.MaxValue
    }

    public abstract class Metal : ParteBase
    {
        public CorMetalEnum Cor { get; set; }
    }
}
