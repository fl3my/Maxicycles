#nullable disable

using System.ComponentModel.DataAnnotations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Users.Staff;

public class IndexModel : PageModel
{
    private readonly UserManager<MaxicyclesUser> _userManager;

    public List<UserModel> Users = new();

    public IndexModel(UserManager<MaxicyclesUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        var users = await _userManager.Users.ToListAsync();
        
        // Populate list view model with all users.
        foreach (var user in users)
        {
            // If user is a customer do not add to the list.
            if (await _userManager.IsInRoleAsync(user, "Customer")) continue;
            
            // If user is a manager do not add to the list.
            if (await _userManager.IsInRoleAsync(user, "Manager")) continue;
            
            var userModel = new UserModel
            {
                Id = user.Id,
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
            };
                
            Users.Add(userModel);
        }

        return Page();
    }

    public class UserModel
    {
        public string Id { get; set; }
        
        [Display(Name="Email")]
        public string Username { get; set; }
        
        [Display(Name="Firstname")]

        public string FirstName { get; set; }
        
        [Display(Name="Lastname")]

        public string LastName { get; set; }
        
        public string Role { get; set; }
    }
}