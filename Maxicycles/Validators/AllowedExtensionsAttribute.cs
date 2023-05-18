using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Validators;

public class AllowedExtensionsAttribute : ValidationAttribute
{
    private readonly string[] _extensions;

    public AllowedExtensionsAttribute(string[] extensions)
    {
        _extensions = extensions;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // Check if the value is not null
        if (value is IFormFile uploadedFile)
        {
            // Get the extension.
            var extension = Path.GetExtension(uploadedFile.FileName);

            // Check if the extension is in the extensions list defined bu the user.
            if (!_extensions.Contains(extension.ToLower()))
            {
                // Return a validation error to the frontend.
                return new ValidationResult(GetErrorMessage());
            }
        }
        
        return ValidationResult.Success;
    }

    private string GetErrorMessage()
    {
        return $"Only the following file types are permitted {string.Join(", ", _extensions)}.";
    }
}