using CelsoGuitars.Domain.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelsoGuitars.Repository.Mapping.Servico
{
    public class TipoServicoMapping : IEntityTypeConfiguration<TipoServico>
    {
        public void Configure(EntityTypeBuilder<TipoServico> builder)
        {
            builder.ToTable("TiposServicos");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Descricao)
                .HasMaxLength(4000);

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasPrecision(6, 2);

            builder.Property(x => x.MinutosExecucao)
                .IsRequired();
        }
    }
}
