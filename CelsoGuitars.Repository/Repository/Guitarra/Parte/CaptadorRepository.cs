using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class CaptadorRepository : Repository<Captador>, ICaptadorRepository
    {
        public CaptadorRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
