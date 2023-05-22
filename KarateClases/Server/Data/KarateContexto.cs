using KarateClases.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace KarateClases.Server.Data
{
    public class KarateContexto : DbContext
    {
        public KarateContexto(DbContextOptions<KarateContexto> options) : base(options)
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Dojo> Dojos { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
    }
}
