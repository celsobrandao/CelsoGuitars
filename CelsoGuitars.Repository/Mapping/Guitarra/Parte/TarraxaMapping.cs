using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CelsoGuitars.Repository.Mapping.Guitarra.Parte
{
    public class TarraxaMapping : IEntityTypeConfiguration<Tarraxa>
    {
        public void Configure(EntityTypeBuilder<Tarraxa> builder)
        {
            builder.ToTable("Tarraxas");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.IndicaComTrava)
                .IsRequired();

            builder.Property(x => x.Cor)
                .IsRequired();

            builder.HasOne(x => x.Marca)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

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
