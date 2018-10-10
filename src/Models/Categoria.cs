using System.Collections.Generic;

namespace MyApi.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
 
        List<Producto> Productos { get; set; }
    }
}