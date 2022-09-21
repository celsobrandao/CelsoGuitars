using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Guitarra.Parte
{
    public class CaptadorMapping : IEntityTypeConfiguration<Captador>
    {
        public void Configure(EntityTypeBuilder<Captador> builder)
        {
            builder.ToTable("Captadores");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.TipoCaptador)
                .IsRequired();

            builder.Property(x => x.TipoCaptadorOutro)
                .HasMaxLength(100);

            builder.Property(x => x.Resistencia)
                .IsRequired();

            builder.Property(x => x.CorCaptador)
                .IsRequired();

            builder.Property(x => x.CorCaptadorOutro)
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
