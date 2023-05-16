#nullable disable

using System.ComponentModel.DataAnnotations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Users.Staff;

public class CreateModel : PageModel
{
    private readonly IUserEmailStore<MaxicyclesUser> _emailStore;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<MaxicyclesUser> _userManager;
    private readonly IUserStore<MaxicyclesUser> _userStore;

    public CreateModel(
        UserManager<MaxicyclesUser> userManager,
        IUserStore<MaxicyclesUser> userStore, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _userStore = userStore;
        _roleManager = roleManager;
        _emailStore = GetEmailStore();
    }

    [BindProperty] public InputModel Input { get; set; }

    public async Task<IActionResult> OnGet()
    {
        // Get all the roles that are not Customer.
        var roles = await _roleManager.Roles
            .Where(x => x.Name != "Customer")
            .ToListAsync();

        // Put all of the roles in a select list input.
        var rolesList = roles.Select(s => new SelectListItem
        {
            Value = s.Name,
            Text = s.Name
        }).ToList();

        // Create a model with the roles.
        Input = new InputModel
        {
            Roles = rolesList
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // If the validation is successful, create a user.
        if (ModelState.IsValid)
        {
            var user = CreateUser();

            // Custom user properties.
            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            user.AddressLine1 = Input.AddressLine1;
            user.AddressLine2 = Input.AddressLine2;
            user.City = Input.City;
            user.Postcode = Input.Postcode;
            user.PhoneNumber = Input.PhoneNumber;

            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

            var result = await _userManager.CreateAsync(user, Input.Password);

            // If succeeded, Add the user to the role selected from the dropdown.
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Input.Role);
                return RedirectToPage("./Index");
            }

            // Display all the errors at the top of the form.
            foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
        }

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

        [Required] public string Role { get; set; }

        public List<SelectListItem> Roles { get; set; }
    }
}