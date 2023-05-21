using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Data;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Add the roles.
        var roles = new List<IdentityRole>()
        {
            new() {Name = "Admin", NormalizedName = "ADMIN"},
            new() {Name = "Customer", NormalizedName = "CUSTOMER"},
            new() {Name = "StockControl", NormalizedName = "STOCKCONTROL"},
            new() {Name = "Technician", NormalizedName = "TECHNICIAN"},
            new() {Name = "AccountsClerk", NormalizedName = "ACCOUNTSCLERK"},
            new() {Name = "MediaManager", NormalizedName = "MEDIAMANAGER"},
            new() {Name = "Manager", NormalizedName = "MANAGER"}
        };
        
        modelBuilder.Entity<IdentityRole>().HasData(roles);
        
        // Hash the passwords.
        var hasher = new PasswordHasher<MaxicyclesUser>();
        
        // Add the test users.
        var users = new List<MaxicyclesUser>()
        {
            new()
            {
                UserName = "customer@example.co.uk",
                Email="customer@example.co.uk", 
                NormalizedUserName = "CUSTOMER@EXAMPLE.CO.UK",
                NormalizedEmail = "CUSTOMER@EXAMPLE.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "Customer123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            },
            new()
            {
                UserName = "stockControl@maxicycles.co.uk",
                Email="stockControl@maxicycles.co.uk", 
                NormalizedUserName = "STOCKCONTROL@MAXICYCLES.CO.UK",
                NormalizedEmail = "STOCKCONTROL@MAXICYCLES.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "StockControl123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            },
            new()
            {
                UserName = "technician@maxicycles.co.uk",
                Email="technician@maxicycles.co.uk", 
                NormalizedUserName = "TECHNICIAN@MAXICYCLES.CO.UK",
                NormalizedEmail = "TECHNICIAN@MAXICYCLES.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "Technician123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            },
            new()
            {
                UserName = "accountsClerk@maxicycles.co.uk",
                Email="accountsClerk@maxicycles.co.uk", 
                NormalizedUserName = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                NormalizedEmail = "ACCOUNTSCLERK@MAXICYCLES.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "AccountsClerk123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            },
            new()
            {
                UserName = "mediaManager@maxicycles.co.uk",
                Email="mediaManager@maxicycles.co.uk", 
                NormalizedUserName = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                NormalizedEmail = "MEDIAMANAGER@MAXICYCLES.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "MediaManager123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            },
            new()
            {
                UserName = "manager@maxicycles.co.uk",
                Email="manager@maxicycles.co.uk", 
                NormalizedUserName = "MANAGER@MAXICYCLES.CO.UK",
                NormalizedEmail = "MANAGER@MAXICYCLES.CO.UK",
                PasswordHash = hasher.HashPassword(null!, "Manager123!"),
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
            }
        };

        modelBuilder.Entity<MaxicyclesUser>().HasData(users);
        
        // Add the relationships for user and roles.
        var userRoles = new List<IdentityUserRole<string>>
        {
            new()
            {
                UserId = users.First(q => q.UserName == "customer@example.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Customer").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "stockControl@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "stockControl@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "StockControl").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "technician@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "technician@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Technician").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "accountsClerk@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "accountsClerk@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "AccountsClerk").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "mediaManager@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "mediaManager@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "MediaManager").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "manager@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            },
            new()
            {
                UserId = users.First(q => q.UserName == "manager@maxicycles.co.uk").Id,
                RoleId = roles.First(q => q.Name == "Manager").Id
            }
        };

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        
    }
}