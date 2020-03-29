using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Data.Mapping
{
    public class FilmeGeneroMap : IEntityTypeConfiguration<FilmeGenero>
    {
        public void Configure(EntityTypeBuilder<FilmeGenero> builder)
        {
            // PK
            builder.HasKey(k => new { k.FilmeId, k.GeneroId });

            // Relacionamento
            builder.HasOne(p => p.Filme)
                .WithMany(m => m.FilmeGeneros)
                .HasForeignKey(f => f.FilmeId);

            builder.HasOne(p => p.Genero)
                .WithMany(m => m.FilmeGeneros)
                .HasForeignKey(f => f.GeneroId);

            // Index
            builder.HasIndex(i => i.FilmeId);

            builder.HasIndex(i => i.GeneroId);

            // Tabela
            builder.ToTable("TAB_FILME_GENERO");
        }
    }
}
