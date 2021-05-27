using System;
using System.ComponentModel.DataAnnotations;

namespace AlmacenWeb.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
    }
}