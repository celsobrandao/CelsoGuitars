using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Guitarra.Parte
{
    public class TrasteMapping : IEntityTypeConfiguration<Traste>
    {
        public void Configure(EntityTypeBuilder<Traste> builder)
        {
            builder.ToTable("Trastes");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

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
