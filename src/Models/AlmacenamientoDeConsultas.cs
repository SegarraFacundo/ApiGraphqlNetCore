using GraphQL.Types;
using MyApi.Datos;

namespace MyApi.Models
{
    public class AlmacenamientoDeConsultas : ObjectGraphType
    {
        public AlmacenamientoDeConsultas(ICategoriaRepositorio categoriaRepositorio, IProductoRepositorio productoRepositorio)
        {
            Field<CategoriaTipo>(
                "categoria",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id", Description = "Id de la categoria"}
                ),
                resolve: context => categoriaRepositorio.ObtenerCategoriaAsincronico(context.GetArgument<int>("id")).Result
            );

            Field<ProductoTipo>(
                "producto",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> {Name = "id", Description = "Id del producto"}
                ),
                resolve: context => productoRepositorio.ObtenerProductoAsincronico(context.GetArgument<int>("id")).Result
            );
}
    }
}