namespace MyApi.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
 
        Categoria Categoria { get; set;}
    }
}