using System;
//validaciones
using System.ComponentModel.DataAnnotations;
//validacion personalizada
using OperaWebSite.Validators;



namespace OperaWebSite.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es un campo obligatorio")]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Dni { get; set; }
        public string Legajo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckFechaNacimientoValidation]
        public DateTime FechaNacimiento { get; set; }
        public string Titulo { get; set; }
    }
}
