#nullable disable

using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class IndexModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public List<UserIndexModel> Users = new();

    public IndexModel(UserManager<MaxicyclesUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        // Get all the user in the system that are in the role customer.
        var users = await _userManager.GetUsersInRoleAsync("Customer");

        // Populate list view model with all users.
        foreach (var userModel in users.Select(user => new UserIndexModel
                 {
                     Id = user.Id,
                     Username = user.UserName,
                     FirstName = user.FirstName,
                     LastName = user.LastName
                 }))
            Users.Add(userModel);

        return Page();
    }

    public class UserIndexModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}