#nullable disable

using System.ComponentModel.DataAnnotations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Users.Staff;

public class EditModel : PageModel
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public EditModel(UserManager<MaxicyclesUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    [BindProperty] public InputModel Input { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);

        // Get the user if it exists.
        if (user == null) return NotFound();

        // Get a list of roles that are not customers.
        var roles = await _roleManager.Roles
            .Where(x => x.Name != "Customer")
            .Where(x => x.Name != "Admin")
            .ToListAsync();

        // Put the roles returned into a select list item.
        var rolesList = roles.Select(s => new SelectListItem
        {
            Value = s.Name,
            Text = s.Name
        }).ToList();

        // Populate the model with user details.
        Input = new InputModel
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            AddressLine1 = user.AddressLine1,
            AddressLine2 = user.AddressLine2,
            City = user.City,
            Postcode = user.Postcode,
            PhoneNumber = user.PhoneNumber,
            Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault(r => r != "Admin"),
            Roles = rolesList
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        var user = await _userManager.FindByIdAsync(Input.Id);

        if (user == null) return NotFound();

        user.FirstName = Input.FirstName;
        user.LastName = Input.LastName;
        user.AddressLine1 = Input.AddressLine1;
        user.AddressLine2 = Input.AddressLine2;
        user.City = Input.City;
        user.Postcode = Input.Postcode;
        user.PhoneNumber = Input.PhoneNumber;

        await _userManager.UpdateAsync(user);

        // Get the role that is not admin.
        var oldRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault(r => r != "Admin");

        // Remove user from current role if user has role already.
        if (oldRole != null) await _userManager.RemoveFromRoleAsync(user, oldRole);

        // Add user to new role.
        await _userManager.AddToRoleAsync(user, Input.Role);

        return RedirectToPage("./Index");
    }

    public class InputModel
    {
        [Required] public string Id { get; set; }

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

        [Required] [RegularExpression(
            @"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})",
            ErrorMessage = "Must be a valid UK Postcode")] public string Postcode { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required] public string Role { get; set; }

        public List<SelectListItem> Roles { get; set; }
    }
}