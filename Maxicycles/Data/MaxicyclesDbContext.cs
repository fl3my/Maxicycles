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
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Seed();
        base.OnModelCreating(builder);
    }
    
    public DbSet<MaxicyclesUser> MaxicyclesUsers => Set<MaxicyclesUser>();
    public DbSet<Maxicycles.Models.Category> Category { get; set; } = default!;
    public DbSet<Maxicycles.Models.SubCategory> SubCategory { get; set; } = default!;
    public DbSet<Maxicycles.Models.Item> Item { get; set; } = default!;
    public DbSet<Maxicycles.Models.Service> Service { get; set; } = default!;
    public DbSet<Maxicycles.Models.Product> Product { get; set; } = default!;
    public DbSet<Maxicycles.Models.Image> Image { get; set; } = default!;
    public DbSet<Maxicycles.Models.BasketItem> BasketItem { get; set; } = default!;
    public DbSet<Maxicycles.Models.BasketProduct> BasketProduct { get; set; } = default!;
    public DbSet<Maxicycles.Models.BasketService> BasketService { get; set; } = default!;

}