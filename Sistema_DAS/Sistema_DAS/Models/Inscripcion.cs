using System.ComponentModel.DataAnnotations;

namespace Sistema_DAS.Models
{
    public class Inscripcion
    {
        [Key]
        public int Id { get; set; }
        public int NroRecibo { get; set; }
        public DateOnly Fecha { get; set; }
        public decimal Total { get; set; }
        //relacion de * -----> 1
        public int UsuarioId { get; set; }
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Estudiante? Estudiante { get; set; }
        public virtual Curso? Curso { get; set; }  
    }
}
