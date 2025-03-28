using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacion.Modelos
{
    public class Calificacion
    {
        [Key]
        public int IdCalificacion { get; set; }

        [Required(ErrorMessage = "La nota es requerida")]
        [Range(0, 100, ErrorMessage = "La nota debe estar entre 0 y 100")]
        public decimal Nota { get; set; }

        [StringLength(500, ErrorMessage = "Los comentarios no pueden exceder los 500 caracteres")]
        public string Comentarios { get; set; }

        [Required(ErrorMessage = "El ID del estudiante es requerido")]
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage = "El ID del examen es requerido")]
        public int IdExamen { get; set; }

        [Required(ErrorMessage = "El ID del curso es requerido")]
        public int IdCurso { get; set; }

        [Required(ErrorMessage = "La fecha de registro es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [ForeignKey(nameof(IdEstudiante))]
        public Estudiante Estudiante { get; set; }

        [ForeignKey(nameof(IdExamen))]
        public Examen Examen { get; set; }

        [ForeignKey(nameof(IdCurso))]
        public Curso Curso { get; set; }
    }
}
