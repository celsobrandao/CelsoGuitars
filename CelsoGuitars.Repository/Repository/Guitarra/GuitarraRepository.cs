using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Repository.Repository.Guitarra
{
    public class GuitarraRepository : Repository<GuitarraModel>, IGuitarraRepository
    {
        public GuitarraRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
