using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class WithinFourteenDaysAttribute : ValidationAttribute
{
    
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var dateValue = (DateTime)value!;

        dateValue = dateValue.ToUniversalTime();
        
        if (DateTime.UtcNow.Date > dateValue)
        {
            return new ValidationResult("Sorry, Date must be in the future");
        }

        if (DateTime.UtcNow.AddDays(14).Date < dateValue)
        {
            return new ValidationResult("Sorry, Date must be within the next 14 days");
        }
        
        return ValidationResult.Success;
    }
}