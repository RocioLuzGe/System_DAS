using System.ComponentModel.DataAnnotations;
namespace Sistema_DAS.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nombre_user { get; set; }
        public string Password { get; set; }
        public RolEnum Rol { get; set; }
        //relacion de 1 -----> *
        public virtual List<Inscripcion> Inscripciones { get; set; }
    }
}