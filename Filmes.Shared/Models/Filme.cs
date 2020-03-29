using Filmes.Shared.Enums;
using System;
using System.Collections.Generic;

namespace Filmes.Shared.Models
{
    public class Filme
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sinopse { get; set; }

        public FilmeEnums.Classificacao Classificacao { get; set; }

        public DateTime DataLancamento { get; set; }

        public virtual IEnumerable<FilmeGenero> FilmeGeneros { get; set; } = new List<FilmeGenero>();
    }
}
