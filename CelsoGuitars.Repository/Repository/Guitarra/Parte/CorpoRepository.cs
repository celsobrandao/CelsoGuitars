using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class CorpoRepository : Repository<Corpo>, ICorpoRepository
    {
        public CorpoRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<Corpo>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.MadeiraCorpo)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.MadeiraTopo)
                            .ThenInclude(x => x.Marca)
                        .ToListAsync();
        }
    }
}
