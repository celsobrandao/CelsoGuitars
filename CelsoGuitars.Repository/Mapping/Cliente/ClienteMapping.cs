using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ClienteModel = CelsoGuitars.Domain.Cliente.Cliente;

namespace CelsoGuitars.Repository.Mapping.Cliente
{
    public class ClienteMapping : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.OwnsOne(x => x.Email, p =>
            {
                p.Property(f => f.Valor)
                    .HasColumnName("Email")
                    .IsRequired()
                    .HasMaxLength(100);
            });

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.DataNascimento)
                .IsRequired();

            builder.HasMany(x => x.OrdensServicos)
                .WithOne(x => x.Cliente);
        }
    }
}
