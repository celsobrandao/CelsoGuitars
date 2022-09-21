using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class PonteRepository : Repository<Ponte>, IPonteRepository
    {
        public PonteRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
