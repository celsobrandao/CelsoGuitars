using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Guitarra.Parte
{
    public class ChaveamentoMapping : IEntityTypeConfiguration<Chaveamento>
    {
        public void Configure(EntityTypeBuilder<Chaveamento> builder)
        {
            builder.ToTable("Chaveamentos");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.TipoChaveamento)
                .IsRequired();

            builder.Property(x => x.TipoChaveamentoOutro)
                .HasMaxLength(100);

            builder.HasOne(x => x.Marca)
                .WithMany()
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Descricao)
                .HasMaxLength(4000);

            builder.Property(x => x.CodigoFabricante)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
