#nullable disable

using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class DeleteModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    // Inject an instance of the userManager.
    public DeleteModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty] public UserDeleteModel UserDelete { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        // Return if no id.
        if (id == null) return NotFound();

        // Find the user by id.
        var user = await _userManager.FindByIdAsync(id);

        if (user == null) return NotFound();

        // Put details into a view Model.
        UserDelete = new UserDeleteModel
        {
            Id = id,
            Username = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);

        // if user is not null, delete the user.
        if (user != null) await _userManager.DeleteAsync(user);

        return RedirectToPage("./Index");
    }

    public class UserDeleteModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}