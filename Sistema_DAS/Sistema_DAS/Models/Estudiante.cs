
using System.ComponentModel.DataAnnotations;

namespace Sistema_DAS.Models
{
    public class Estudiante
    {
        [Key]
        public int Id{ get; set; }
        public string? Email { get; set; }
        public string? CI { get; set; }
        public string? Nombre { get; set; }
        public int Celular { get; set; }
        public string? Direccion { get; set; }
        //relacion de 1 -----> *
        public virtual List<Inscripcion>? Inscripciones { get; set; }

    }
}
