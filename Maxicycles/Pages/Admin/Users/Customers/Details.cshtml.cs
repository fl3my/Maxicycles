#nullable disable

using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class DetailsModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public DetailsModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    public UserDetailModel UserDetail { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null) return NotFound();

        // Find the user if the id is not null.
        var user = await _userManager.FindByIdAsync(id);

        if (user == null) return NotFound();

        // Put user information into a view model.
        UserDetail = new UserDetailModel
        {
            Id = id,
            Username = user.UserName,
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

    public class UserDetailModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PhoneNumber { get; set; }
    }
}