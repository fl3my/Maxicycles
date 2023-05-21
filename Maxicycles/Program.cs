using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
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

builder.Services.AddDefaultIdentity<MaxicyclesUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MaxicyclesDbContext>();

builder.Services.AddAuthorization(options =>
{
    // Create Group policies.
    options.AddPolicy("RequireAdmin", policy => policy.RequireRole("Admin"));
    options.AddPolicy("RequireImagePrivileges", policy => policy.RequireRole("StockControl, MediaManager"));
    options.AddPolicy("RequireStoreEditPrivileges", policy => policy.RequireRole("StockControl, Admin"));
    
    // Create basic role polices.
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
    
    // Require role on specific folder/pages.
    options.Conventions.AuthorizeFolder("/Admin/Users/Customers", "RequireAccountsClerk");
    options.Conventions.AuthorizeFolder("/Admin/Users/Staff", "RequireManager");
    options.Conventions.AuthorizeFolder("/Admin/Holidays", "RequireManager");
    options.Conventions.AuthorizeFolder("/Admin/Blog", "RequireMediaManager");
    options.Conventions.AuthorizeFolder("/Admin/Services", "RequireTechnician");
    
    // Require image privileges to add or delete images.
    options.Conventions.AuthorizeFolder("/Admin/Images", "RequireImagePrivileges");
    
    // Require store edit privileges to add or delete images.
    options.Conventions.AuthorizeFolder("/Admin/Store", "RequireStoreEditPrivileges");
});

builder.Services.AddTransient<IEmailSender, EmailSender>();
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