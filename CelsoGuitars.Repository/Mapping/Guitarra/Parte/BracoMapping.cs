using CelsoGuitars.Domain.Guitarra.Parte;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Guitarra.Parte
{
    public class BracoMapping : IEntityTypeConfiguration<Braco>
    {
        public void Configure(EntityTypeBuilder<Braco> builder)
        {
            builder.ToTable("Bracos");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.MadeiraBraco)
                .WithMany()
                .IsRequired();

            builder.HasOne(x => x.MadeiraEscala)
                .WithMany()
                .IsRequired();

            builder.Property(x => x.ComprimentoEscala)
                .IsRequired();

            builder.Property(x => x.QuantidadeTrastes)
                .IsRequired();

            builder.Property(x => x.Formato)
                .IsRequired();

            builder.Property(x => x.FormatoOutro)
                .HasMaxLength(100);

            builder.Property(x => x.RaioEscala)
                .IsRequired();

            builder.Property(x => x.JuncaoBraco)
                .IsRequired();

            builder.Property(x => x.JuncaoBracoOutro)
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
