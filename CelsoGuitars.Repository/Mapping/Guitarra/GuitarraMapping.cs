using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GuitarraModel = CelsoGuitars.Domain.Guitarra.Guitarra;

namespace CelsoGuitars.Repository.Mapping.Guitarra
{
    public class GuitarraMapping : IEntityTypeConfiguration<GuitarraModel>
    {
        public void Configure(EntityTypeBuilder<GuitarraModel> builder)
        {
            builder.ToTable("Guitarras");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Braco)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Corpo)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.ConfiguracaoCaptadores)
                .IsRequired();

            builder.Property(x => x.ConfiguracaoCaptadoresOutro)
                .HasMaxLength(100);

            builder.HasMany(x => x.Captadores)
                .WithMany(x => x.Guitarras);

            builder.HasMany(x => x.Chaveamentos)
                .WithMany(x => x.Guitarras);

            builder.HasOne(x => x.Ponte)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Tarraxa)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Traste)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Foto)
                .IsRequired()
                .HasMaxLength(500);

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
