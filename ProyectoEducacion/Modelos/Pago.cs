using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacion.Modelos
{
    public class Pago
    {

        [Key]
        public int IdPago { get; set; }

        [Required]
        public float Monto { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdEstudiante { get; set; }
    }
}
