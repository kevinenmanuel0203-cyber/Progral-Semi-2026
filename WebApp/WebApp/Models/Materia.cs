using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public int uv { get; set;}
    }
}
