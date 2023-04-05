#nullable disable

using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Users.Customers;

public class DeleteModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public DeleteModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty] public UserDetailedModel UserModel { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null) return NotFound();

        var user = await _userManager.FindByIdAsync(id);

        if (user == null) return NotFound();

        UserModel = new UserDetailedModel
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

        if (user != null) await _userManager.DeleteAsync(user);

        return RedirectToPage("./Index");
    }

    public class UserDetailedModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}