using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Data.Migrations;
using Maxicycles.Models;
using Maxicycles.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Terminal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<MaxicyclesDbContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add identity framework.
builder.Services.AddDefaultIdentity<MaxicyclesUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MaxicyclesDbContext>();

builder.Services.AddAuthorization(options =>
{
    // Create Group policies.
    options.AddPolicy("RequireAdmin", policy => policy.RequireRole("Admin"));
    
    // Create combined policies.
    options.AddPolicy("RequireImagePrivileges", policy => policy.RequireRole("StockControl", "MediaManager", "Manager"));
    options.AddPolicy("RequireEditStorePrivileges", policy => policy.RequireRole("Manager", "StockControl"));
    
    // Create basic role polices.
    options.AddPolicy("RequireCustomer", policy => policy.RequireRole("Customer"));
    options.AddPolicy("RequireAccountsClerk", policy => policy.RequireRole("AccountsClerk"));
    options.AddPolicy("RequireManager", policy => policy.RequireRole("Manager"));
    options.AddPolicy("RequireStockControl", policy => policy.RequireRole("StockControl"));
    options.AddPolicy("RequireMediaManager", policy => policy.RequireRole("MediaManager"));
    options.AddPolicy("RequireTechnician", policy => policy.RequireRole("Technician"));
});
    
builder.Services.AddRazorPages(options =>
{
    // Require staff member policy to access admin folder.
    options.Conventions.AuthorizeFolder("/Admin", "RequireAdmin");

    // Create a combined policy for image editing.
    options.Conventions.AuthorizeFolder("/Admin/Images", "RequireImagePrivileges");
    
    // Create a combined policy for edit products.
    options.Conventions.AuthorizeFolder("/Admin/Store", "RequireEditStorePrivileges");

    // Require role on specific folder/pages.
    options.Conventions.AuthorizeFolder("/Admin/Users/Customers", "RequireAccountsClerk");
    options.Conventions.AuthorizeFolder("/Admin/Users/Staff", "RequireManager");
    options.Conventions.AuthorizeFolder("/Admin/Holidays", "RequireManager");
    options.Conventions.AuthorizeFolder("/Admin/Blog", "RequireMediaManager");
    options.Conventions.AuthorizeFolder("/Admin/Services", "RequireTechnician");
    
    //  Require customer role for customer actions.
    options.Conventions.AuthorizeFolder("/Basket", "RequireCustomer");
    options.Conventions.AuthorizeFolder("/Checkout", "RequireCustomer");
    options.Conventions.AuthorizeFolder("/MyOrders", "RequireCustomer");
    options.Conventions.AuthorizeFolder("/MyServices", "RequireCustomer");
});

// Allow the email sender to be injected into the project through dependancy injection.
builder.Services.AddTransient<IEmailSender, EmailSender>();

// Configure the secret key.
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

var app = builder.Build();


// This is your test secret API key.
StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];
    
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