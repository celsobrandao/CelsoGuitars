using Microsoft.EntityFrameworkCore;

namespace CelsoGuitars.Repository.Context
{
    public class CelsoGuitarsContext : DbContext
    {
        public CelsoGuitarsContext(DbContextOptions<CelsoGuitarsContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CelsoGuitarsContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
