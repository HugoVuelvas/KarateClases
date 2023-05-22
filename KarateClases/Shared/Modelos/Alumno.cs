using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateClases.Shared.Modelos
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La edad es obligatoria")]
        public int? Edad { get; set; }
        [Required(ErrorMessage = "Es necesario indicar el dojo")]
        public int? DojoId { get; set; }
        [Required(ErrorMessage = "Tiene que elegir una de las opciones")]
        public int? Genero { get; set; }
        [Required(ErrorMessage = "El alumno debe tener un grado")]
        public string? Grado { get; set; }
        public int? TutorId { get; set; }
        [Required(ErrorMessage = "El telefono de emergencia es obligatorio")]
        [Phone(ErrorMessage = "Indique un numero de telefono valido")]
        public string? Telefono { get; set; }
        public Dojo? Dojo { get; set; }
        public Tutor? Tutor { get; set; }

    }
}
