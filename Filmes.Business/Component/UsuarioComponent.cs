using Filmes.Data.Context;
using Filmes.Shared.Interface;
using Filmes.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmes.Business.Component
{
    public class UsuarioComponent : IUsuarioComponent
    {
        private readonly FilmesContext _context;

        public UsuarioComponent(FilmesContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Usuario>> GetAll() =>
            await _context.Usuario.ToListAsync();

        public async Task<Usuario> GetById(int id) =>
             await _context.Usuario.FindAsync(id);

        public async Task<Usuario> Insert(Usuario item)
        {
            var tmp = await _context.Usuario.AddAsync(item);
            await _context.SaveChangesAsync();

            return tmp.Entity;
        }

        public async Task<Usuario> Update(Usuario item)
        {
            _context.Usuario.Update(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task Delete(int id)
        {
            Usuario tmp = await GetById(id);
            await Delete(tmp);
        }

        public async Task Delete(Usuario item)
        {
            _context.Usuario.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
