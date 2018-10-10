using System.Collections.Generic;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Datos
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> CategoriasAsincronico();
        Task<Categoria> ObtenerCategoriaAsincronico(int id);
    }
}