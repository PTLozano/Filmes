using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Data.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            // PK
            builder.HasKey(k => k.Id);

            // Propriedades
            builder.Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Sinopse)
                .HasMaxLength(5000);

            builder.Property(p => p.Classificacao)
                .IsRequired();

            builder.Property(p => p.DataLancamento)
                .HasColumnType("DATE")
                .IsRequired();

            // Tabela
            builder.ToTable("TAB_FILME");
        }
    }
}
