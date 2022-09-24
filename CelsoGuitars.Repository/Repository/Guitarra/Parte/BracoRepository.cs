using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class BracoRepository : Repository<Braco>, IBracoRepository
    {
        public BracoRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<Braco>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.MadeiraBraco)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.MadeiraEscala)
                            .ThenInclude(x => x.Marca)
                        .ToListAsync();
        }
    }
}
