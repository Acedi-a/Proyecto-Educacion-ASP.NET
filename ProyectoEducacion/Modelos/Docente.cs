using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacion.Modelos
{
	public class Docente : Usuario
	{
		

			public Docente()
			{
				rol = "Docente";
			}
			[Required(ErrorMessage = "El campo especialidad es obligatorio ")]
			[StringLength(50)]
			public string especialidad { get; set; }
		
	}
}
