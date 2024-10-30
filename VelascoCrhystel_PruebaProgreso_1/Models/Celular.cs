using System.ComponentModel.DataAnnotations;

namespace VelascoCrhystel_PruebaProgreso_1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }
        [Range(2010, 2030)]
        public int Anio { get; set; }

        public double Precio { get; set; }
    }
}
