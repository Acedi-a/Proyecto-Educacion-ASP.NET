using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEducacion.Modelos
{
	public class Notificacion
	{
        [Key]
        public int idNotificacion { get; set; }
		[Required(ErrorMessage = "El campo tipo notificacion es obligatorio")]
		[StringLength(20, ErrorMessage = "El tipoNotificacion no cumple con los valores minimos"), MinLength(2)]
		public string tipoNotificacion { get; set; }
        public int idPago { get; set; }
		[ForeignKey(nameof(idPago))]
		public virtual Pago? Pago { get; set; }
		public int idExamen {  get; set; }
		[ForeignKey(nameof(idExamen))]
		public virtual Examen? Examen { get; set; }



	}
}
