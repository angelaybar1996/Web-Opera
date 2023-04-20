using System;
using System.ComponentModel.DataAnnotations;//validación personalizada



namespace OperaWebSite.Validators
{
    public class CheckFechaNacimientoValidationAttribute : ValidationAttribute
    {
        public CheckFechaNacimientoValidationAttribute()
        {
            ErrorMessage = "Solo se aceptan a partir del año 2000 en adelante!";
        }
        public override bool IsValid(object value)
        {

            if (Convert.ToDateTime(value) < new DateTime(200, 01, 01))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
