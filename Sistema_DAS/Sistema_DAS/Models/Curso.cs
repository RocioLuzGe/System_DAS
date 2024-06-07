using System.ComponentModel.DataAnnotations;
namespace Sistema_DAS.Models
{
	public class Curso
	{
		[Key]
		public int Id { get; set; }
		public int Nro_Capacidad { get; set; }
		public string? Nombre_Curso { get; set; }
		public string? Nombre_Docente { get; set; }
		public string? Lugar { get; set; }
		public TipoEnum? Tipo { get; set; }
		public string Foto_url { get; set; }
		public string Video_url { get; set; }

		//relacion de 1 -----> *
		public virtual List<Inscripcion> Inscripciones { get; set; }	
	}
}
