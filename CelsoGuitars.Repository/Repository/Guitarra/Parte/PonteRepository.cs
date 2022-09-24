using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class PonteRepository : Repository<Ponte>, IPonteRepository
    {
        public PonteRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<Ponte>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.Marca)
                        .ToListAsync();
        }
    }
}
