using Filmes.Data.Context;
using Filmes.Shared.Interface;
using Filmes.Shared.Models;
using Filmes.Shared.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.Business.Component
{
    public class FilmeComponent : IFilmeComponent
    {
        private readonly FilmesContext _context;

        public FilmeComponent(FilmesContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Filme>> GetAll() =>
            await _context.Filme
            .Include(i => i.FilmeGeneros)
            .ThenInclude(i => i.Genero)
            .ToListAsync();

        public async Task<Filme> GetById(int id) =>
             await _context.Filme.FindAsync(id);

        public async Task<IEnumerable<Filme>> Search(FilmeViewModel search)
        {
            var filmes = _context.Filme.ToList();

            if (search.FilmeId.HasValue)
            {
                filmes = filmes.Where(x => x.Id == search.FilmeId.Value).ToList();
            }

            if (search.GeneroId.HasValue)
            {
                var genero = _context.FilmeGenero.Where(x => x.GeneroId == search.GeneroId.Value);
                var generoIdList = genero.Select(s => s.FilmeId).ToArray();

                filmes = filmes.Where(x => generoIdList.Contains(x.Id)).ToList();
            }

            if (search.DataLancamento.HasValue)
            {
                filmes = filmes.Where(x => x.DataLancamento.Date == search.DataLancamento.Value.Date).ToList();
            }

            return filmes;
        }

        public async Task<Filme> Insert(Filme item)
        {
            var tmp = await _context.Filme.AddAsync(item);
            await _context.SaveChangesAsync();

            return tmp.Entity;
        }

        public async Task<Filme> Update(Filme item)
        {
            _context.Filme.Update(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task Delete(int id)
        {
            Filme tmp = await GetById(id);
            await Delete(tmp);
        }

        public async Task Delete(Filme item)
        {
            _context.Filme.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
