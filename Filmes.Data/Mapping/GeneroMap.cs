using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Data.Mapping
{
    class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            // PK
            builder.HasKey(k => k.Id);

            // Propriedades
            builder.Property(p => p.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            // Tabela
            builder.ToTable("TAB_GENERO");
        }
    }
}
