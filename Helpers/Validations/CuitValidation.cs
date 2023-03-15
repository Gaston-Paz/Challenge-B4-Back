using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Backend.Helpers.Validations
{
    public class CuitValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string cuit = value.ToString();
                if (Regex.IsMatch(cuit, @"[0-9]+-[0-9]+-[0-9]", RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Formato de CUIT inválido. Se espera un formato como el siguiente: XX-XXXXXXXX-X.");
                }
            }
            return null;
        }
    }
}
