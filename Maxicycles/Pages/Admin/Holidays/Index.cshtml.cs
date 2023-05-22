using Maxicycles.Data;
using Maxicycles.Data.Migrations;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Holidays;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Holiday> Holiday { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Get all holidays from the database and populate a list.
        Holiday = await _context.Holidays.ToListAsync();

        // Change utc time to local time.
        foreach (var holiday in Holiday)
        {
            holiday.Start = holiday.Start.ToLocalTime();
            holiday.End = holiday.End.ToLocalTime();

        }
    }
}