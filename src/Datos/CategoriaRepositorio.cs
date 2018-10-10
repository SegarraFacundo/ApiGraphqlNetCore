using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Datos
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private List<Categoria> _categorias;

        public CategoriaRepositorio()
        {
            _categorias = new List<Categoria>{
                new Categoria()
                {
                    Id = 1,
                    Nombre = "Computadoras"
                },
                new Categoria()
                {
                    Id = 2,
                    Nombre = "Celulares"
                }
            };
        }

        public Task<List<Categoria>> CategoriasAsincronico()
        {
            return Task.FromResult(_categorias);
        }

        public Task<Categoria> ObtenerCategoriaAsincronico(int id)
        {
            return Task.FromResult(_categorias.FirstOrDefault(x => x.Id == id));
        }
    }
}