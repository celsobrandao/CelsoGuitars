namespace CelsoGuitars.Domain.Guitarra.Parte
{
    public class Corpo : ParteBase
    {
        public Madeira MadeiraCorpo { get; set; }
        public Madeira MadeiraTopo { get; set; }
        public string Cor { get; set; }
    }
}
