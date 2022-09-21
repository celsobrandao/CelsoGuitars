namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public enum FormatoBracoEnum : byte
    {
        C = 0,
        D = 1,
        V = 2,
        ModernC = 3,
        Assimetrico = 4,
        Outro = byte.MaxValue
    }

    public enum JuncaoBracoEnum : byte
    {
        Set = 0,
        BoltOn = 1,
        Through = 2,
        Outro = byte.MaxValue
    }

    public class Braco : ParteBase
    {
        public Madeira MadeiraBraco { get; set; }
        public Madeira MadeiraEscala { get; set; }
        public decimal ComprimentoEscala { get; set; }
        public byte QuantidadeTrastes { get; set; }
        public FormatoBracoEnum Formato { get; set; }
        public string FormatoOutro { get; set; }
        public decimal RaioEscala { get; set; }
        public JuncaoBracoEnum JuncaoBraco { get; set; }
        public string JuncaoBracoOutro { get; set; }
    }
}
