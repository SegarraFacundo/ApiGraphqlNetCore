using System.Linq;
using MyApi.Datos;
using GraphQL.Types;

namespace MyApi.Models
{
    public class CategoriaTipo : ObjectGraphType<Categoria>
    {
        public CategoriaTipo(IProductoRepositorio productoRepositorio)
        {
            Field(x => x.Id).Description("Id de la categoria");
            Field(x => x.Nombre, nullable: true).Description("Nombre de la categoría.");
 
            Field<ListGraphType<ProductoTipo>>(
                "productos", 
                resolve: context => productoRepositorio.ObtenerProductosPorCategoriaAsincronico(context.Source.Id).Result.ToList()
            );
        }
    }
}