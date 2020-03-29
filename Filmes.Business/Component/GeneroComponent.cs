using Filmes.Data.Context;
using Filmes.Shared.Interface;
using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmes.Business.Component
{
    public class GeneroComponent: IGeneroComponent
    {
        private readonly FilmesContext _context;

        public GeneroComponent(FilmesContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Genero>> GetAll() =>
            await _context.Genero.ToListAsync();

        public async Task<Genero> GetById(int id) =>
             await _context.Genero.FindAsync(id);

        public async Task<Genero> Insert(Genero item)
        {
            var tmp = await _context.Genero.AddAsync(item);
            await _context.SaveChangesAsync();

            return tmp.Entity;
        }

        public async Task<Genero> Update(Genero item)
        {
            _context.Genero.Update(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task Delete(int id)
        {
            Genero tmp = await GetById(id);
            await Delete(tmp);
        }

        public async Task Delete(Genero item)
        {
            _context.Genero.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
