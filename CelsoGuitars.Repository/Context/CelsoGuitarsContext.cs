using CelsoGuitars.Domain.Fornecedor;
using CelsoGuitars.Domain.Guitarra.Parte;
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

            modelBuilder.Entity<Marca>()
                .HasData(
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Gibson"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Fender"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Gotoh"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Grover"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Floyd Rose"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Seymour Duncan"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Dimarzio"
                    },
                    new Marca
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Warmoth"
                    }
                );

            modelBuilder.Entity<Madeira>()
                .HasData(
                    new Madeira
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Maple"
                    },
                    new Madeira
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Rosewood"
                    },
                    new Madeira
                    {
                        ID = Guid.NewGuid(),
                        Nome = "Ebony"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
