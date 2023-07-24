using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepositoy
    {
        IEnumerable<Categoria> Categorias { get; }  
    }
}
