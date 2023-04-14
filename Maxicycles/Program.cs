using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<MaxicyclesDbContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<MaxicyclesUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MaxicyclesDbContext>();

builder.Services.AddAuthorization(options =>
{
    // Create policies
    options.AddPolicy("RequireAccountsClerk", policy => policy.RequireRole("AccountsClerk"));
    options.AddPolicy("RequireManager", policy => policy.RequireRole("Manager"));
    options.AddPolicy("RequireStockControl", policy => policy.RequireRole("StockControl"));
});
    
builder.Services.AddRazorPages(options =>
{
    // Require role on pages.
    options.Conventions.AuthorizeFolder("/Admin/Users/Customers", "RequireAccountsClerk");
    options.Conventions.AuthorizeFolder("/Admin/Users/Staff", "RequireManager");
    options.Conventions.AuthorizeFolder("/Admin/Store", "RequireStockControl");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();