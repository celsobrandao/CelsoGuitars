namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public enum TipoCaptadorEnum : byte
    {
        SingleCoil = 0,
        Humbucker = 1,
        P90 = 2,
        HumbuckerSigleSize = 3,
        Lipstick = 4,
        Outro = byte.MaxValue
    }

    public enum CorCaptadorEnum : byte
    {
        Preto = 0,
        Branco = 1,
        Creme = 2,
        ZebraBranco = 3,
        ZebraCreme = 4,
        Cromado = 5,
        Outro = byte.MaxValue
    }

    public class Captador : ParteBase
    {
        public TipoCaptadorEnum TipoCaptador { get; set; }
        public string TipoCaptadorOutro { get; set; }
        public decimal Resistencia { get; set; }
        public CorCaptadorEnum CorCaptador { get; set; }
        public string CorCaptadorOutro { get; set; }

        public List<Guitarra> Guitarras { get; set; }
    }
}
