using CelsoGuitars.Domain.Servico;
using CelsoGuitars.Domain.Servico.Repository;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Repository.Servico
{
    public class OrdemServicoRepository : Repository<OrdemServico>, IOrdemServicoRepository
    {
        public OrdemServicoRepository(CelsoGuitarsContext context) : base(context)
        {
        }

        public Task<List<OrdemServico>> GetCompletoByCliente(Guid clienteID)
        {
            return DbSet
                        .Include(x => x.TiposServicos)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Braco)
                                .ThenInclude(x => x.MadeiraBraco)
                                    .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Braco)
                                .ThenInclude(x => x.MadeiraEscala)
                                    .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Corpo)
                                .ThenInclude(x => x.MadeiraCorpo)
                                    .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Corpo)
                                .ThenInclude(x => x.MadeiraTopo)
                                    .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Captadores)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Chaveamentos)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Ponte)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Tarraxa)
                                .ThenInclude(x => x.Marca)
                        .Include(x => x.Guitarra)
                            .ThenInclude(x => x.Traste)
                                .ThenInclude(x => x.Marca)
                        .Where(x => x.Cliente.ID == clienteID)
                        .ToListAsync();
        }
    }
}
