using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
