using CelsoGuitars.Domain.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Servico
{
    public class OrdemServicoMapping : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdensServicos");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.DataEntrada)
                .IsRequired();

            builder.Property(x => x.DataInicioServico)
                .IsRequired();

            builder.Property(x => x.DataSaidaPrevista)
                .IsRequired();

            builder.Property(x => x.DataSaidaEfetiva);

            builder.HasOne(x => x.Guitarra)
                .WithMany()
                .IsRequired();

            builder.HasMany(x => x.TiposServicos)
                .WithMany(x => x.OrdensServicos);

            builder.Property(x => x.ValorPrevisto)
                .IsRequired();

            builder.Property(x => x.PercentualDesconto)
                .IsRequired();

            builder.Property(x => x.ValorEfetivo)
                .IsRequired();

            builder.Property(x => x.Observacoes)
                .HasMaxLength(4000);
        }
    }
}
