using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V5.Pages.Account.Manage.Internal;
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
        
        // Add the roles to the modelbuilder.
        modelBuilder.Entity<IdentityRole>().HasData(roles);
        
        // Hash the passwords.
        var hasher = new PasswordHasher<MaxicyclesUser>();
        
        // Add all the different users to a list.
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
                AddressLine1 = "Customer street",
                City = "Customer City",
                FirstName = "Customer",
                LastName = "Customerton",
                Postcode = "G4 0RF"
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
                AddressLine1 = "Stock control street",
                City = "Stockland",
                FirstName = "Stock",
                LastName = "Controllerington",
                Postcode = "G4 0RF"
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
                AddressLine1 = "Technician street",
                City = "Tech Town",
                FirstName = "Techy",
                LastName = "Techman",
                Postcode = "G4 0RF"
                
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
                AddressLine1 = "Accounts Street",
                City = "Address City",
                FirstName = "Add",
                LastName = "McDress",
                Postcode = "G4 0RF"
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
                AddressLine1 = "Media Street",
                City = "Medialand",
                FirstName = "Media",
                LastName = "Managerio",
                Postcode = "G4 0RF"
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
                AddressLine1 = "Manager Street",
                City = "Managerburgh",
                FirstName = "Man",
                LastName = "Ager",
                Postcode = "G4 0RF"
            }
        };
        
        // Add the users to the model builder.
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
        
        // Add the users to the roles.
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        // Define the parent categories.
        var categories = new List<Category>()
        {
            new()
            {
                Id=1,
                Title = "Bikes",
                Slug = "bikes"
            },
            new()
            {
                Id = 2,
                Title = "Skateboards",
                Slug = "skateboards",
            },
            new()
            {
                Id =3,
                Title = "Accessories",
                Slug = "accessories"
            },
            new()
            {
                Id= 4,
                Title = "Services",
                Slug = "services"
            }
        };

        // Add the categories to the database.
        modelBuilder.Entity<Category>().HasData(categories);

        // Add the sub categories to a list.
        var subCategories = new List<SubCategory>()
        {
            new()
            {
                Id= 1,
                Title = "Tyres",
                Slug = "tyres",
                CategoryId = categories[0].Id
            },
            new()
            {
                Id= 2,
                Title = "Complete Skateboards",
                Slug = "complete-skateboards",
                CategoryId = categories[1].Id
            },
            new()
            {
                Id =3,
                Title = "Complete Bikes",
                Slug = "complete-bikes",
                CategoryId = categories[0].Id
            },
            new()
            {
                Id= 4,
                Title = "Repairs",
                Slug = "repairs",
                CategoryId = categories[3].Id
            },
            new()
            {
                Id= 5,
                Title = "Decks",
                Slug = "decks",
                CategoryId = categories[1].Id
            },
            new()
            {
                Id = 6,
                Title = "Helmets",
                Slug = "helmets",
                CategoryId = categories[2].Id,
            },
            new()
            {
                Id = 7,
                Title = "Pads",
                Slug = "Pads",
                CategoryId = categories[2].Id,
            }
        };

        // Add the subcategories to the database.
        modelBuilder.Entity<SubCategory>().HasData(subCategories);
        
        // Add the images to a list.
        var images = new List<Image>()
        {
            new()
            {
                Id =1,
                Title = "Continental GP500 Product Photo",
                AltText = "Continental GP5000 Folding Tyres",
                ImageName = "gp5000.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id =2,
                Title = "Vittoria Rubino Pro Main",
                AltText = "Vittoria Rubino Pro G2.0 Folding Road Tyres",
                ImageName = "vittoria.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id =3,
                Title = "Schwalbe Marathon Plus Main",
                AltText = "Schwalbe Marathon Plus SmartGuard Wired MTB Tyre - 26",
                ImageName = "schwalbe.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id = 4,
                Title = "Colnago v3 Main",
                AltText = "Colnago V3 Disc Ultegra Carbon Road Bike",
                ImageName = "colnago.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id =5,
                Title = "Ridley Noah Disc 105 Main",
                AltText = "Ridley Noah Disc 105 Carbon Road Bike - 2023",
                ImageName = "ridley_noah.jpg",
                UploadedAt = DateTime.UtcNow,
            },
            new Image
            {
                Id =6,
                Title = "wizaard lighting 3.3 main",
                AltText = "Wizard Lighting 3.3 Disc Sora Road Bike",
                ImageName = "wizaard.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id = 7,
                Title = "Blind Skateboards Reaper wallpaper",
                AltText = "Blind Skateboards Reaper Wallpaper FP Youth Complete Skateboard - 7.0'' x 29''",
                ImageName = "blind-skateboards-reaper.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id = 8,
                Title = "Element Skateboards Naturalist main",
                AltText = "Element Skateboards Naturalist Complete Skateboard - 7.375'' x 31''",
                ImageName = "element-skateboards-naturalist-complete.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id = 9,
                Title = "Santa cruz iridesent dot main",
                AltText = "Santa Cruz Skateboards Iridescent Dot Complete Skateboard - 8.0'' x 31.25''",
                ImageName = "santa-cruz.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id = 10,
                Title = "Flat Tyre Repair main",
                AltText = "A bicycle with a flat tyre",
                ImageName = "flat-tyre-repair.jpg",
                UploadedAt = DateTime.UtcNow,
            },
            new Image
            {
                Id =11,
                Title = "Gear Shifting Adjustment main",
                AltText = "Gear adjusting a bicycle",
                ImageName = "gear-shifting.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new Image
            {
                Id =12,
                Title = "Brake system main",
                AltText = "Bleeding a disc bike brakes",
                ImageName ="brake-bleed.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new ()
            {
                Id = 13,
                Title = "Native OG Logo (Blue Stain) Skateboard Deck",
                AltText = "Native OG Logo (Blue Stain) Skateboard Deck 8.38",
                ImageName = "native-og-logo.jpg",
                UploadedAt = DateTime.UtcNow,
            },
            new()
            {
                Id = 14,
                Title = "Picture Show No Place Like Home Skateboard Deck ",
                AltText = "Picture Show No Place Like Home Skateboard Deck ",
                ImageName = "picture-show-no-place.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new()
            {
                Id =15,
                Title = "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25",
                AltText = "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25",
                ImageName = "toy-machine-skateboards.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new() {
                Id = 16,
                Title = "Pro-Tec Street Elbow Pads - Black/White Checker",
                AltText = "Pro-Tec Street Elbow Pads - Black/White Checker",
                ImageName="pro-tec-street-elbow-pads.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new() {
                Id = 17,
                Title = "187 Killer Pads Fly Skate Knee Pads - Black",
                AltText = "187 Killer Pads Fly Skate Knee Pads - Black",
                ImageName = "187-killer-pads.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new()
            {
                Id = 18,
                Title = "REKD Protection Pro Ramp Knee Pads - Black",
                AltText = "REKD Protection Pro Ramp Knee Pads - Black",
                ImageName = "rekd-protection-pro-ramp.jpg",
                UploadedAt = DateTime.UtcNow
            },
            new()
            {
                Id = 19,
                Title = "MET Trenta 3K Carbon MIPS Road Bike Helmet",
                AltText = "MET Trenta 3K Carbon MIPS Road Bike Helmet",
                ImageName = "trenta_3k_carbonjpg.jpg",
                UploadedAt = DateTime.UtcNow,
            },
            new()
            {
                Id = 20,
                Title = "Kask Protone WG11 Road Cycling Helmet - 2022",
                AltText = "Kask Protone WG11 Road Cycling Helmet - 2022",
                ImageName="kask_protone_wg11.jpg",
                UploadedAt = DateTime.UtcNow,
            },
            new()
            {
                Id = 21,
                Title = "MET Allroad Road Helmet",
                AltText = "MET Allroad Road Helmet",
                ImageName ="met_allroad.jpg",
                UploadedAt = DateTime.UtcNow
            }
        };

        // Add the images to the database.
        modelBuilder.Entity<Image>().HasData(images);

        // Create a list with seed products.
        var products = new List<Product>()
        {
            new()
            {
                Id =1,
                Title = "Continental GP5000 Folding Tyres",
                Description = "The new era in cycling - the best allrounder in the field, brought to a whole new performance level. Ride faster, more comfortable and with increased puncture protection. Made to make you better. Developing the Grand Prix 5000 nothing has been left to chance.",
                Slug = "continental-gp5000-folding-tyres",
                Price = 80.40M,
                Quantity = 10,
                SubCategoryId = subCategories[0].Id,
                ImageId =1,
            },
            new()
            {
                Id =2,
                Title = "Vittoria Rubino Pro G2.0 Folding Road Tyres",
                Description = "Designed for intensive training, it is equally suitable for racing events. The Rubino Pro builds on the standard Rubino platform, utilizing the same exclusive 3C Graphene compound structure, long service life, puncture protection, and sharp handling traits, but substitutes a folding bead material for reduced weight..",
                Slug = "vittoria-rubino-pro-g20-folding-road-tyres",
                Price = 45M,
                Quantity = 20,
                SubCategoryId = subCategories[0].Id,
                ImageId = 2
            },
            new()
            {
                Id =3,
                Title = "Schwalbe Marathon Plus SmartGuard Wired MTB Tyre - 26",
                Description = "The most puncture resistant MTB tyre. Now with a new dynamic profile. On the central rib it rolls easily over hard paths, while the strong outer lugs give it great off-road traction. The SmartGuard provides superior puncture protection.",
                Slug = "schwalbe-marathon-plus-smartguard",
                Price = 23.50M,
                Quantity = 4,
                SubCategoryId = subCategories[0].Id,
                ImageId = 3
            },
            new()
            {
                Id =4,
                Title = "Colnago V3 Disc Ultegra Carbon Road Bike",
                Description = "When Colnago developed the V3 they thought of all those cyclists who want to get the most out of their investment. Quality carbon and fittings designed to offer an excellent level of performance and contain costs and make V3 a perfectly balanced bike from every point of view. It blends technical solutions that aim at lightness with aerodynamic details. The lines are clean and essential,  it can be fitted with tyres up to 28mm wide. V3 is available in eight sizes and only with disc brakes.",
                Slug = "colnago-v3-disc-ultegra-carbon-road-bike",
                Price = 2800M,
                Quantity = 2,
                SubCategoryId = subCategories[2].Id,
                ImageId =4
            },
            new()
            {
                Id =5,
                Title = "Ridley Noah Disc 105 Carbon Road Bike - 2023",
                Description = "The Noah is both a top aero bike as well as a continuously evolving technological masterpiece. Originally developed as the ultimate sprint bike for team Lotto, it has since incorporated all-round qualities. While it continues to win sprints, it now shines on the cobblestones around Roubaix as well. Thanks to advanced aero-optimized technology combined with of in-depth wind tunnel testing, the Noah is world class in aerodynamics. All tubing, from fork to rear triangle, have an optimized NACA profile. Cables are cleverly integrated into the handlebar/stem. While the Noah may defy wind, it remains a lightweight road bike that's exceptionally comfortable. The Noah Disc has all the same technologies and ride qualities of its big brother, the Noah Fast Disc Caleb Ewan's favourite road bike, but is more budget-friendly.",
                Slug = "ridley-noah-disc-105",
                Price = 3699M,
                Quantity = 2,
                SubCategoryId = subCategories[2].Id,
                ImageId =5,
            },
            new()
            {
                Id =6,
                Title = "Wizard Lighting 3.3 Disc Sora Road Bike",
                Description = "Elevate your road riding experience with confidence and control. This versatile road bike is built on a lightweight 6061 aluminium frame and Shimano components that can handle anything in its path. The Lighting 3.3 Sora is light, fast and comfortable. The sportif geometry positions you forward enough to go hard but upright enough to go cover the miles with ease. The Lighting 3.3 is equipt with Shimano Sora R3000 9 speed drivtrain and mechanical dsic brakes help with better handling and control. Wizard bikes are apart of the Merlin Cycles LTD range, offering quality affordable bikes for all the family.",
                Slug = "wizard-lighting-33-disc",
                Price = 425M,
                Quantity = 5,
                SubCategoryId = subCategories[2].Id,
                ImageId =6
            },
            new()
            {
                Id =7,
                Title = "Blind Skateboards Reaper Wallpaper FP Youth Complete Skateboard - 7.0'' x 29''",
                Description = "The Reaper Wallpaper Complete by Blind is available in 7.0'' x 29'' . It features Tensor trucks, 51mm wheels, and is finished with griptape, bearings and bolts. This complete comes fully assembled and ready to skate straight out of the box!",
                Slug = "blind-skateboards-reaper-wallpaper-complete",
                Price = 75.99M,
                Quantity = 4,
                SubCategoryId = subCategories[1].Id,
                ImageId =7,
            },
            new()
            {
                Id =8,
                Title = "Element Skateboards Naturalist Complete Skateboard - 7.375'' x 31''",
                Description = "The Naturalist Complete by Darkstar is available in 7.375'' x 31''. It features Element trucks, 52mm wheels, and is finished with griptape, bearings and bolts. This complete comes fully assembled and ready to skate straight out of the box!",
                Slug = "element-skateboards-naturalist-complete",
                Price = 79.99M,
                Quantity = 6,
                SubCategoryId = subCategories[1].Id,
                ImageId = 8,
            },
            new()
            {
                Id =9,
                Title = "Santa Cruz Skateboards Iridescent Dot Complete Skateboard - 8.0'' x 31.25''",
                Description = "The Iridescent Dot Complete by Santa Cruz is available on an 8.0'' x 31.25'' Iridescent Dot deck. It features Bullet trucks, OJ wheels, and is finished with bearings, griptape and bolts. This complete comes fully assembled and ready to skate straight out of the box!",
                Slug = "santa-cruz-skateboards-dot-complete",
                Price = 71.99M,
                Quantity = 3,
                SubCategoryId = subCategories[1].Id,
                ImageId = 9
            },
            new()
            {
                Id =13,
                Title = "Native OG Logo (Blue Stain) Skateboard Deck 8.38''",
                Description = "OG Logo Deck 8.38'', Wide 14.25'', WB 7 Ply Canadian Maple, Colour - Yellow Stain",
                Slug = "native-og-logo-deck",
                Price = 30.39M,
                Quantity = 4,
                SubCategoryId = subCategories[4].Id,
                ImageId = 13,
            },
            new()
            {
            Id =14,
            Title = "Picture Show No Place Like Home Skateboard Deck 8.5'' ",
            Description = "No Place Like Home Deck, 8.5'' Wide, 14.5'' WB, 7-Ply Canadian Maple, Team Model",
            Slug = "picture-show-deck",
            Price = 69.99M,
            Quantity = 2,
            SubCategoryId = subCategories[4].Id,
            ImageId = 14,
        },
            new()
            {
                Id =15,
                Title = "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25''",
                Description = "Mind Control Deck, 8.25'' x 31.98'', 14.25'' WB, 7-Ply Canadian Maple, Axel Pro Model, Mind Control Graphic Series",
                Slug = "mind-control-deck",
                Price = 64.99M,
                Quantity = 2,
                SubCategoryId = subCategories[4].Id,
                ImageId = 15,
            },
            new()
            {
                Id =16,
                Title = "Pro-Tec Street Elbow Pads - Black/White Checker",
                Description = "he Street Elbow Pads by Pro-Tec are a great value pad designed to reduce impact when skating. The Street Elbow pads feature a locked in EVA foam that is designed to lock your elbow in for maximum protection, ballsitic nylon construction that resists tears and protects from skids and scrapes, a curved hard cap that allows better protection, perforated neoprene for better ventilation and adjustable velcor straps. A great value pad, it is available in Black/White checker colourway",
                Slug="pro-tec-elbow-pads",
                Price=19.99m,
                Quantity = 30,
                SubCategoryId = subCategories[6].Id,
                ImageId = 16,
            },
            new() {
                Id = 17,
                Title = "187 Killer Pads Fly Skate Knee Pads - Black",
                Description = "The Fly Knee Pads from 187 Killer Pads, is available in a black colourway, and is their slimmest and most versatile knee pad. Although its primarily designed for skateboarding, you can use these with other sports too. ",
                Slug = "fly-knee-pads",
                Price = 31.99M,
                Quantity = 10,
                SubCategoryId = subCategories[6].Id,
                ImageId = 17,
            },
            new ()
            {
                Id =18,
                Title = "REKD Protection Pro Ramp Knee Pads - Black",
                Description = "REKD Protections Pro Ramp Knee pads are designed for riders who want extra protection as well as extra comfort. Perfect for all abilities the Pro Ramp Knee pad features high density impact ramp caps, ergonomic knee recesses, dual neoprene butterfly closure and layered heavy duty EVA memory foam. These pads are available in black.",
                Slug="rekd-pro-ramp-knees",
                Price =23.96M,
                Quantity = 30,
                SubCategoryId = subCategories[6].Id,
                ImageId = 18
            },
            new()
            {
                Id =19,
                Title ="MET Trenta 3K Carbon MIPS Road Bike Helmet ",
                Description = "The MET Trenta 3K Carbon Mips® is a high performance road helmet designed with elite cyclists and worn to victory a Le Tour de France and the monuments of Liège-Bastogne-Liège and Il Lombardia. Engineered to keep your head fresh and save you energy with every pedal stroke, the MET Trenta 3K Carbon Mips® is the most advanced road cycling helmet we have ever made, now upgraded with the addition of Mips AIR®, the lightest and most advanced rotational management system.",
                Slug = "met-trenta-3k-carbon",
                Price = 180M,
                Quantity = 5,
                SubCategoryId = subCategories[5].Id,
                ImageId= 19,
            },
            new()
            {
                Id =20,
                Title = "Kask Protone WG11 Road Cycling Helmet - 2022",
                Description = "With just 215g of weight, the Kask Protone has the lowest drag and the fastest heat dissipation coefficients compared to any other ventilated helmet. Thanks to several ventilation holes and a thick padding material, heat and moisture are dissipated very fast, improving comfort and performance without giving up on safety: the top area is reinforced with an internal plastic sub-structure that increases crash protection.",
                Slug="kask-protone",
                Price = 120M,
                Quantity = 4,
                SubCategoryId = subCategories[5].Id,
                ImageId = 20,
            },
            new() {
                Id = 21,
                Title = "MET Allroad Road Helmet",
                Description = "The MET Allroad is made for those who enjoy spending time on the saddle, whether on the tarmac or on gravel routes. Sporty on one side, comfy on the other. It’s exceptionally lightweight and secure thanks to MET’s distinghuishing design.",
                Slug = "met-allroad",
                Price = 48.99m,
                Quantity = 2,
                SubCategoryId = subCategories[5].Id,
                ImageId = 21,
            }
        };

        // Add the products to the database.
        modelBuilder.Entity<Product>().HasData(products);

        // Create a list of services.
        var services = new List<Service>()
        {
            new()
            {
                Id= 10,
                Title = "Flat Tyre Repair",
                Description = "Dealing with a flat tire is a common issue that can disrupt your cycling experience. Our expert technicians are equipped to efficiently repair flat tires and get you back on the road quickly. We'll carefully inspect the tire, identify the cause of the puncture, and either patch or replace the tube as needed. Additionally, we'll examine the tire for any signs of damage or wear to ensure optimal performance and prevent future flats. Trust us to restore your tire's functionality and make your cycling adventures worry-free.",
                Slug = "flat-tyre-repair",
                Price = 20M,
                DailyMaxServices = 6,
                SubCategoryId = subCategories[3].Id,
                ImageId =10,
            },
            new()
            {
                Id =11,
                Title = "Gear Shifting Adjustment",
                Description = "Smooth and precise gear shifting is essential for an enjoyable biking experience. If you're facing issues with shifting gears, our skilled technicians can help. We'll meticulously assess your bike's drivetrain, cables, and derailleurs to identify any misalignments or issues affecting gear shifting. Our team will then make the necessary adjustments, ensuring that your gears engage seamlessly and provide optimal performance. Whether it's a minor tweak or a comprehensive adjustment, we'll work diligently to enhance your bike's shifting functionality.",
                Slug = "gear-shifting-adjustment",
                Price = 30M,
                DailyMaxServices = 10,
                SubCategoryId =subCategories[3].Id,
                ImageId =11,
            },
            new()
            {
                Id =12,
                Title = "Brake System Maintenance",
                Description = "Safety is paramount when it comes to cycling, and a well-maintained brake system is crucial for effective stopping power. Our experienced technicians specialize in comprehensive brake system maintenance. We'll inspect your brake pads, cables, and calipers, checking for any signs of wear, misalignment, or brake fluid leakage. If necessary, we'll replace worn brake pads, adjust cable tension, and align calipers to optimize braking performance. Trust us to ensure that your brakes are in top-notch condition, allowing you to ride with confidence and peace of mind.",
                Slug = "brake-system-maintenance",
                Price = 40M,
                DailyMaxServices = 2,
                SubCategoryId = subCategories[3].Id,
                ImageId = 12
            }
        };

        // Add the services to the database.
        modelBuilder.Entity<Service>().HasData(services);
        
        // Add a list of the delivery methods.
        var deliveryMethods = new List<DeliveryMethod>()
        {
            new()
            {
                Id =1,
                Title = "Free Delivery",
                Price = 0M,
                MinDaysToDeliver = 5,
                IsDaySelectable = false,
            },
            new()
            {
                Id= 2,
                Title = "Fast Delivery",
                Price = 3.99M,
                MinDaysToDeliver = 3,
                IsDaySelectable = false,
            },
            new()
            {
                Id =3,
                Title = "Any Day Delivery",
                Price = 10M,
                MinDaysToDeliver = 1,
                IsDaySelectable = true,
            }
        };
        
        // Add the delivery methods to the database.
        modelBuilder.Entity<DeliveryMethod>().HasData(deliveryMethods);
    }
}