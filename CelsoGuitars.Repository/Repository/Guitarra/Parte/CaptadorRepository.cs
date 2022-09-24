using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class CaptadorRepository : Repository<Captador>, ICaptadorRepository
    {
        public CaptadorRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<Captador>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.Marca)
                        .ToListAsync();
        }
    }
}
