#nullable disable

using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Staff;

public class DeleteModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public DeleteModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty] public UserDeleteModel UserDelete { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);

        // Get the user from the id if not null.
        if (user == null) return NotFound();

        // Populate the model with 
        UserDelete = new UserDeleteModel
        {
            Id = id,
            Username = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);

        // Delete the user if it exists.
        if (user != null) await _userManager.DeleteAsync(user);

        return RedirectToPage("./Index");
    }

    public class UserDeleteModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}