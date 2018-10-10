using System.Collections.Generic;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Datos
{
    public interface IProductoRepositorio
    {
        Task<List<Producto>> ObtenerProductosAsincronico();
        Task<List<Producto>> ObtenerProductosPorCategoriaAsincronico(int categoriaId);
        Task<Producto> ObtenerProductoAsincronico(int id);
    }
}