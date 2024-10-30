using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VelascoCrhystel_PruebaProgreso_1.Models
{
    public class Velasco
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Range(0.0,10.0)]
        public float Promedio { get; set; }
        [Display(Name ="Tiene Ganas de Estudiar?")]
        public bool TieneGanasEstudiar { get; set; }
        [DataType(DataType.Date)]
        public DateTime Dia { get; set; }
        public Celular? Celular { get; set; }
        [ForeignKey(nameof(Celular))]
        public int IdCelular { get; set; }

    }
}
