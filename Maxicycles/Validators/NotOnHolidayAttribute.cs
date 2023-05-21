using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;

namespace Maxicycles.Validators;

public class NotOnHolidayAttribute : ValidationAttribute
{
    private string GetErrorMessage(string holidayTitle, string holidayEnd) =>
        $"Sorry, This date occurs during our " + holidayTitle + " holiday, we are back on " + holidayEnd + ".";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var context = (MaxicyclesDbContext)validationContext.GetService(typeof(MaxicyclesDbContext))!;
        var date = (DateTime)value!;

        // Loop over each holiday in context.
        foreach (var holiday in context.Holidays)
        {
            // Check if date is in the holiday window.
            if (date >= holiday.Start && date < holiday.End)
            {
                return new ValidationResult(GetErrorMessage(holiday.Title!, holiday.End.AddDays(1).ToShortDateString()));
            }
        }
        return ValidationResult.Success;
    }
}