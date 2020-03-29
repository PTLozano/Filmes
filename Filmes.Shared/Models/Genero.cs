using System.Collections.Generic;

namespace Filmes.Shared.Models
{
    public class Genero
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public virtual IEnumerable<FilmeGenero> FilmeGeneros { get; set; } = new List<FilmeGenero>();
    }
}