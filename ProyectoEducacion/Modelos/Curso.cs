using System.ComponentModel.DataAnnotations;


namespace ProyectoEducacion.Modelos
{
	public class Curso
	{
		[Key]
		public int idCurso { get; set; }

		[Required(ErrorMessage ="El campo nombreCurso es obligatorio ")]
		[StringLength(20, ErrorMessage = "El nombrecurso no cumple con los valores minimos"), MinLength(3)]
		public string nombreCurso { get; set; }
		[Required(ErrorMessage = "El campo turno es obligatorio ")]
		[StringLength(20, ErrorMessage = "El turno no cumple con los valores minimos"), MinLength(3)]
		public string turno { get; set; }



		public virtual ICollection<Estudiante> Estudiantes { get; set; }
	}
}
