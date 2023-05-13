using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { 
            

        }
        //TODO: ADD DBSETS: Tables of our db
        public DbSet<User>? Users { get; set; } //Creara tablas dentro de la base de datos especificada
        public DbSet<Curso>? Cursos { get; set; } //Creara tablas dentro de la base de datos especificada
    }
}
