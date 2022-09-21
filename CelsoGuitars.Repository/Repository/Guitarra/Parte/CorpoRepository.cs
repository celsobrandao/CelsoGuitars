using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class CorpoRepository : Repository<Corpo>, ICorpoRepository
    {
        public CorpoRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
