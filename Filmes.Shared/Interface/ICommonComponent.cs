using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmes.Shared.Interface
{
    public interface ICommonComponent<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Insert(TEntity item);
        Task<TEntity> Update(TEntity item);
        Task Delete(int id);
        Task Delete(TEntity item);
    }
}
