using System.ComponentModel.DataAnnotations;

namespace SemanticKernelExample01.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; }

        public string Categoria { get; set; }
    }
}
