using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Backend.Helpers.Validations
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string email = value.ToString();
                if (Regex.IsMatch(email, @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]{2,4}", RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Formato de Email inválido.");
                }
            }
            return null;
        }
    }
}
