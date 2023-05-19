using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class CheckBoxRequiredAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is bool and true)
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("Please accept the terms and conditions.");
    }
}