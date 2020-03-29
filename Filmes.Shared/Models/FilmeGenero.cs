namespace Filmes.Shared.Models
{
    public class FilmeGenero
    {
        public int FilmeId { get; set; }
        public virtual Filme Filme { get; set; }

        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
    }
}