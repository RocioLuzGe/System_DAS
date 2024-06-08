using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sistema_DAS.Models;
using System.Collections.Generic;

namespace Sistema_DAS.Context
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }

    }
    
}
