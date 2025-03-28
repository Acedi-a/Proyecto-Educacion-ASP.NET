using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoEducacion.Modelos;
namespace ProyectoEducacion.Data
{
	public class DbConexion:DbContext
	{
		public DbConexion(DbContextOptions<DbConexion> options) : base(options) { }
		public DbSet<Asistencia> Asistencia { get; set;}
		public DbSet<Calificacion> Calificacion { get; set;}
		public DbSet<Certificado> Certificado { get; set;}
		public DbSet<Curso> Curso { get; set;}
		public DbSet<Docente> Docente { get; set;}
		public DbSet<Estudiante> Estudiante { get; set;}
		public DbSet<Examen> Examen { get; set;}
		public DbSet<Horario> Horario { get; set;}
		public DbSet<Materia> Materia { get; set;}
		public DbSet<Mensaje> Mensaje { get; set;}
		public DbSet<Notificacion> Notificacion { get; set;}
		public DbSet<Pago> Pago { get; set;}
		public DbSet<Reporte> Reporte { get; set;}
		public DbSet<Usuario> Usuario { get; set;}

	}
}
