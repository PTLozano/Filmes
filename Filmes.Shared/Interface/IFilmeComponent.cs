using Filmes.Shared.Models;
using Filmes.Shared.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmes.Shared.Interface
{
    public interface IFilmeComponent : ICommonComponent<Filme>
    {
        Task<IEnumerable<Filme>> Search(FilmeViewModel search);
    }
}
