#nullable disable

using System.ComponentModel.DataAnnotations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class CreateModel : PageModel
{
    private readonly IUserEmailStore<MaxicyclesUser> _emailStore;
    private readonly UserManager<MaxicyclesUser> _userManager;
    private readonly IUserStore<MaxicyclesUser> _userStore;

    public CreateModel(
        UserManager<MaxicyclesUser> userManager,
        IUserStore<MaxicyclesUser> userStore)
    {
        _userManager = userManager;
        _userStore = userStore;
        _emailStore = GetEmailStore();
    }

    [BindProperty] public InputModel Input { get; set; }

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the model state is valid.
        if (ModelState.IsValid)
        {
            var user = CreateUser();

            // Define custom user properties.
            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            user.AddressLine1 = Input.AddressLine1;
            user.AddressLine2 = Input.AddressLine2;
            user.City = Input.City;
            user.Postcode = Input.Postcode;
            user.PhoneNumber = Input.PhoneNumber;

            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            // Store the username and email in the user store.
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

            // Create the user with a password.
            var result = await _userManager.CreateAsync(user, Input.Password);

            // Add to customer role and return to index if succeed.
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Customer");
                return RedirectToPage("./Index");
            }

            // Display all errors at top of form.
            foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
        }

        // If we got this far, something failed, redisplay form.
        return Page();
    }

    private MaxicyclesUser CreateUser()
    {
        try
        {
            return Activator.CreateInstance<MaxicyclesUser>();
        }
        catch
        {
            throw new InvalidOperationException($"Can't create an instance of '{nameof(MaxicyclesUser)}'. " +
                                                $"Ensure that '{nameof(MaxicyclesUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                                                "override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
        }
    }

    private IUserEmailStore<MaxicyclesUser> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
            throw new NotSupportedException("The default UI requires a user store with email support.");
        return (IUserEmailStore<MaxicyclesUser>)_userStore;
    }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
            MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")] public string AddressLine2 { get; set; }

        [Required] public string City { get; set; }

        [Required] public string Postcode { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}