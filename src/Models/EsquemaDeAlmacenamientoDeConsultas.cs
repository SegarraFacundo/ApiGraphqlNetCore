using System;
using GraphQL.Types;

namespace MyApi.Models
{
    public class EsquemaDeAlmacenamientoDeConsultas : Schema
    {
        public EsquemaDeAlmacenamientoDeConsultas(Func<Type, GraphType> resolveType)
            : base(resolveType)
        {
            Query = (AlmacenamientoDeConsultas)resolveType(typeof(AlmacenamientoDeConsultas));
        }
    }
}