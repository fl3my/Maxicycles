using Maxicycles.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Data;

public class MaxicyclesDbContext : IdentityDbContext
{
    public MaxicyclesDbContext(DbContextOptions<MaxicyclesDbContext> options)
        : base(options)
    {
    }

    public DbSet<MaxicyclesUser> MaxicyclesUsers => Set<MaxicyclesUser>();
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Seed();
        base.OnModelCreating(builder);
    }
    
    public DbSet<Maxicycles.Models.Category> Category { get; set; } = default!;
    
    public DbSet<Maxicycles.Models.SubCategory> SubCategory { get; set; } = default!;
}