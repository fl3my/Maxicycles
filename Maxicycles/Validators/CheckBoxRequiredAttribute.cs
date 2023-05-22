using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class CheckBoxRequiredAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Check if the value is a boolean and is true.
        if (value is bool and true)
        {
            // return a validation success.
            return ValidationResult.Success;
        }

        return new ValidationResult("Please accept the terms and conditions.");
    }
}