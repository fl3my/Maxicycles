using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class NoProfanityAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Get the input string.
        var input = (string)value!;

        // Create a new profanity filter object.
        var filter = new ProfanityFilter.ProfanityFilter();

        // Return an error if the string contains profanity.
        if (filter.ContainsProfanity(input))
        {
            return new ValidationResult("Sorry, your comment cannot contain profanity.");
        }
        
        // Else return success.
        return ValidationResult.Success;
    }
}