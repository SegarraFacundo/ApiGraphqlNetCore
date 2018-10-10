using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Datos
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private List<Producto> _productos;
    
        public ProductoRepositorio()
        {
            _productos = new List<Producto>{
                new Producto()
                {
                    Id = 1,
                    CategoriaId = 1,
                    Nombre = "Apple Macbook Pro 2016",
                    Descripcion = "Touchbar, 3.2GHZ",
                    Precio = 5000
                },
                new Producto()
                {
                    Id = 2,
                    CategoriaId = 1,
                    Nombre = "Apple Macbook Air",
                    Descripcion = "2.3GHZ 8GB RAM",
                    Precio = 2000
                },
                new Producto()
                {
                    Id = 3,
                    CategoriaId = 1,
                    Nombre = "Dell XPS 13",
                    Descripcion = "3.3GHZ 12GB RAM",
                    Precio = 4000
                }
            };
        }
        public Task<Producto> ObtenerProductoAsincronico(int id)
        {
            return Task.FromResult(_productos.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Producto>> ObtenerProductosAsincronico()
        {
            return Task.FromResult(_productos);
        }

        public Task<List<Producto>> ObtenerProductosPorCategoriaAsincronico(int categoriaId)
        {
            return Task.FromResult(_productos.Where(x => x.CategoriaId == categoriaId).ToList());
        }
    }
}