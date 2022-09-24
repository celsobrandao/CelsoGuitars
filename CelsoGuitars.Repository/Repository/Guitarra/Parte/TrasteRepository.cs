using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class TrasteRepository : Repository<Traste>, ITrasteRepository
    {
        public TrasteRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<Traste>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.Marca)
                        .ToListAsync();
        }
    }
}
