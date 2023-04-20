using System.ComponentModel.DataAnnotations;

namespace OperaWebSite.Validators
{
    public class CheckValidYearAtributte : ValidationAttribute
    {
        public CheckValidYearAtributte()
        {
            ErrorMessage = "El año debe ser mayor a 1598";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1598)
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
