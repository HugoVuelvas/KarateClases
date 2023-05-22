using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateClases.Shared.Modelos
{
    public class Tutor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La ocupación es obligatoria")]
        public int? Ocupacion { get; set; }
        [Required(ErrorMessage = "El telefono de emergencia es obligatorio")]
        [Phone(ErrorMessage = "Indique un numero de telefono valido")]
        public string? Telefono { get; set; }
        public virtual ICollection<Tutor>? Tutores { get; set; }
    }
}
