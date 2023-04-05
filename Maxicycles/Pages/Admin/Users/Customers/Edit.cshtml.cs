#nullable disable

using System.ComponentModel.DataAnnotations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class EditModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public EditModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty] public InputModel Input { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);
        ;

        if (user == null) return NotFound();

        Input = new InputModel
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            AddressLine1 = user.AddressLine1,
            AddressLine2 = user.AddressLine2,
            City = user.City,
            Postcode = user.Postcode,
            PhoneNumber = user.PhoneNumber
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

        [Required] public string Postcode { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}