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
    
    // Add the users table to the database.
    public DbSet<MaxicyclesUser> MaxicyclesUsers => Set<MaxicyclesUser>();
    
    // Add the product details tables to the database.
    public DbSet<Category> Categories { get; set; } = default!;
    
    // Add the sub categories table to the database.
    public DbSet<SubCategory> SubCategories { get; set; } = default!;
    
    // Add th Items table to the database.
    public DbSet<Item> Items { get; set; } = default!;
    public DbSet<Service> Services { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
    
    // Add the images table to the database.
    public DbSet<Image> Images { get; set; } = default!;
    
    
    // Add the basketItem table to the database.
    public DbSet<BasketItem> BasketItems { get; set; } = default!;
    public DbSet<BasketProduct> BasketProducts { get; set; } = default!;
    public DbSet<BasketService> BasketServices { get; set; } = default!;

    // Add the delivery methods table to the database.
    public DbSet<DeliveryMethod> DeliveryMethods { get; set; } = default!;
    
    // Add the order table to the database.
    public DbSet<Order> Orders { get; set; } = default!;
    
    // Add the order item table to the database.
    public DbSet<OrderItem> OrderItems { get; set; } = default!;
    public DbSet<OrderProduct> OrderProducts { get; set; } = default!;
    public DbSet<OrderService> OrderServices { get; set; } = default!;
    
    // Add the payment table to the database.
    public DbSet<Card> Cards { get; set; } = default!;
    public DbSet<Payment> Payment { get; set; } = default!;
    public DbSet<ExternalPayment> ExternalPayments { get; set; } = default!;
    
    // Add the holidays table to teh database.
    public DbSet<Holiday> Holidays { get; set; } = default!;
    
    // Add the posts table to the database.
    public DbSet<Post> Posts { get; set; } = default!;
    
    // Add the comments table to the database.
    public DbSet<Comment> Comments { get; set; } = default!;

    // Override the on model creating method to seed the data to the database.
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Seed();
        base.OnModelCreating(builder);
    }
}