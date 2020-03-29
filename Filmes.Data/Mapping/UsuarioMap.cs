using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmes.Data.Mapping
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // PK
            builder.HasKey(k => k.Id);

            // Propriedades
            builder.Property(p => p.Login)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();
            
            builder.Property(p => p.Hash)
                .IsRequired();

            // Tabela
            builder.ToTable("TAB_USUARIO");
        }
    }
}
