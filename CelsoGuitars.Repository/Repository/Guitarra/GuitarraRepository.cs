using CelsoGuitars.Domain.Guitarra.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Repository.Repository.Guitarra
{
    public class GuitarraRepository : Repository<GuitarraModel>, IGuitarraRepository
    {
        public GuitarraRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<GuitarraModel> GetByIDCompleto(Guid id)
        {
            return DbSet
                        .Include(x => x.Braco)
                            .ThenInclude(x => x.MadeiraBraco)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Braco)
                            .ThenInclude(x => x.MadeiraEscala)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Corpo)
                            .ThenInclude(x => x.MadeiraCorpo)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Corpo)
                            .ThenInclude(x => x.MadeiraTopo)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Captadores)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Chaveamentos)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Ponte)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Tarraxa)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Traste)
                            .ThenInclude(x => x.Marca)
                        .SingleAsync(x => x.ID == id);
        }

        public Task<List<GuitarraModel>> GetAllCompleto()
        {
            return DbSet
                        .Include(x => x.Braco)
                            .ThenInclude(x => x.MadeiraBraco)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Braco)
                            .ThenInclude(x => x.MadeiraEscala)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Corpo)
                            .ThenInclude(x => x.MadeiraCorpo)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Corpo)
                            .ThenInclude(x => x.MadeiraTopo)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Captadores)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Chaveamentos)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Ponte)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Tarraxa)
                            .ThenInclude(x => x.Marca)
                        .Include(x => x.Traste)
                            .ThenInclude(x => x.Marca)
                        .ToListAsync();
        }
    }
}
