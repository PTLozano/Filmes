using Filmes.Data.Mapping;
using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Data.Context
{
    public class FilmesContext : DbContext
    {
        public FilmesContext(DbContextOptions<FilmesContext> options) : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<FilmeGenero> FilmeGenero { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new FilmeGeneroMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
