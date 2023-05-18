using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class MaxFileSizeAttribute : ValidationAttribute
{
    private readonly int _maxFileSize;
    
    public MaxFileSizeAttribute(int maxFileSize)
    {
        _maxFileSize = maxFileSize * 1;
    }

    // Concatenated error message.
    private string GetErrorMessage()
    {
        return $"The max file size is {_maxFileSize} bytes.";
    }
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // If value is not null and a IFormFile.
        if (value is IFormFile uploadedFile)
        {
            // Check if the file length in bytes is greater than the file size set from the attribute.
            if (uploadedFile.Length > _maxFileSize)
            {
                return new ValidationResult(GetErrorMessage());
            }
        }
        return ValidationResult.Success;
    }
}