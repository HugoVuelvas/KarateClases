using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateClases.Shared.Modelos
{
    public class Dojo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El horario es obligatorio")]
        public string? Horario { get; set; }
        public virtual ICollection<Alumno>? Alumnos { get; set; }
    }
}
