using System.ComponentModel.DataAnnotations;

namespace ProyectoEducacion.Modelos
{
	public class Usuario
	{
		
			[Key]
			public int idUsuario { get; set; }

			[Required]
			[StringLength(50)]
			public string nombreUsuario { get; set; }

			[Required]
			[StringLength(100)]
			public string nombre { get; set; }

			[Required]
			[StringLength(100)]
			public string apellido { get; set; }

			[Required]
			[EmailAddress]
			[StringLength(100)]
			public string correo { get; set; }

			[Required]
			[StringLength(255)]
			public string password { get; set; }

			[Required]
			[StringLength(200)]
			public string direccion { get; set; }

			[Required]
			[Phone]
			[StringLength(20)]
			public string telefono { get; set; }

			[Required]
			[StringLength(20)]
			public string rol { get; set; } // "Estudiante" o "Docente"

			public byte[] imagenData { get; set; }


			public DateTime? fechaRegistro { get; set; } = DateTime.Now;
			public bool activo { get; set; } = true;
		
	}
}
