using OperaWebSite.Validators;//para la clase validacion personalizada
using System.ComponentModel.DataAnnotations;//para las validaciones

namespace OperaWebSite.Models
{
    public class Opera
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Title { get; set; }

        [Required]
        public string Composer { get; set; }

        [CheckValidYearAtributte]
        public int Year { get; set; }

    }
}
