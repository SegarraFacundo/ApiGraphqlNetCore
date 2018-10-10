using MyApi.Datos;
using GraphQL.Types;

namespace MyApi.Models
{
    public class ProductoTipo : ObjectGraphType<Producto>
    {
        public ProductoTipo(ICategoriaRepositorio categoriaRepositorio)
        {
            Field(x => x.Id).Description("Id del producto.");
            Field(x => x.Nombre).Description("Nombre del producto.");
            Field(x => x.Descripcion, nullable: true).Description("Descripcion del producto.");
            Field(x => x.Precio).Description("Precio del producto.");
 
            Field<CategoriaTipo>(
                "categoria", 
                resolve: context => categoriaRepositorio.ObtenerCategoriaAsincronico(context.Source.CategoriaId).Result
             );
        }
    }
}