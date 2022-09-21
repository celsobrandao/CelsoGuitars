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
                .IsRequired();

            builder.HasOne(x => x.Corpo)
                .WithMany()
                .IsRequired();

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
                .IsRequired();

            builder.HasOne(x => x.Tarraxa)
                .WithMany()
                .IsRequired();

            builder.HasOne(x => x.Traste)
                .WithMany()
                .IsRequired();

            builder.Property(x => x.Foto)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
