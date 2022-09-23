using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Parte
{
    public class CorpoMapping : IEntityTypeConfiguration<Corpo>
    {
        public void Configure(EntityTypeBuilder<Corpo> builder)
        {
            builder.ToTable("Corpos");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.MadeiraCorpo)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.MadeiraTopo)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Cor)
                .HasMaxLength(200)
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
