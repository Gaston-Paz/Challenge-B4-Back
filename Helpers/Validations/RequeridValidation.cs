using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Backend.Helpers.Validations
{
    public class RequiredValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null && value.ToString() != "")
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"El campo {validationContext.MemberName} es obligatorio.");
            }
        }
    }
}