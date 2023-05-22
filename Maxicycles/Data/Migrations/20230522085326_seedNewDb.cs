using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedNewDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "1e7a17e0-7af9-4567-bfd7-506fa617ba6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2ac09bd-7c96-4494-a6bc-5d31699e0603", "1e7a17e0-7af9-4567-bfd7-506fa617ba6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "428926e3-6ce1-457f-be1d-a4e309fca1ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "480f437a-a401-498d-979c-8b1685719d53", "428926e3-6ce1-457f-be1d-a4e309fca1ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "54145407-02fc-437f-9711-01e40db356a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9a83e79-05ad-45b6-bbe4-c25bc334cf7e", "54145407-02fc-437f-9711-01e40db356a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "75af3e1b-023f-4878-a060-6af94834a8ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "388427c6-eeaf-43d1-a0dc-193508a6e051", "75af3e1b-023f-4878-a060-6af94834a8ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8938b3d9-3d56-4be7-b7f9-3b7b0fb67104", "ad161d87-d5a0-4199-ab44-49885ff098bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "ae3579cd-9655-4857-a3a7-0e996da546e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7887de42-0a5a-47d4-bba1-fbe8adb446fc", "ae3579cd-9655-4857-a3a7-0e996da546e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0285c5eb-0494-4aa1-b687-af86b1ade8c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "388427c6-eeaf-43d1-a0dc-193508a6e051");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480f437a-a401-498d-979c-8b1685719d53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7887de42-0a5a-47d4-bba1-fbe8adb446fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8938b3d9-3d56-4be7-b7f9-3b7b0fb67104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2ac09bd-7c96-4494-a6bc-5d31699e0603");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9a83e79-05ad-45b6-bbe4-c25bc334cf7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e7a17e0-7af9-4567-bfd7-506fa617ba6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428926e3-6ce1-457f-be1d-a4e309fca1ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54145407-02fc-437f-9711-01e40db356a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75af3e1b-023f-4878-a060-6af94834a8ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad161d87-d5a0-4199-ab44-49885ff098bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae3579cd-9655-4857-a3a7-0e996da546e9");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Images",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "AltText",
                table: "Images",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0192cfde-5e83-437c-b940-bf583589d311", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "14f456a4-59c9-4f35-bedd-5c70b11f1c68", null, "Manager", "MANAGER" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", null, "Admin", "ADMIN" },
                    { "7d8b6011-6b85-4c0b-8501-4aa072818b04", null, "StockControl", "STOCKCONTROL" },
                    { "89847f87-65e8-4c51-bf88-6ff23baa2d01", null, "Technician", "TECHNICIAN" },
                    { "b5e3427c-022c-4c34-92eb-bfd62e6b04f3", null, "MediaManager", "MEDIAMANAGER" },
                    { "bba6b48d-453f-49f8-a3e3-adc09a0c154a", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00243fc5-17a2-47aa-8ad0-3925abfd0cdf", 0, "Manager Street", null, "Managerburgh", "d50714da-16c8-4bc7-b745-4f64ff3f3d1d", "MaxicyclesUser", "manager@maxicycles.co.uk", true, "Man", "Ager", true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECVDZwck6GQxT3LuPvZmQsbBtdhPQF+DRHvTEVmVRpQ81fxcNVVkGT/Vwsb4DKldOw==", null, true, "G4 0RF", "852a842b-95d1-4273-ac29-af9e14993db9", false, "manager@maxicycles.co.uk" },
                    { "04f7e273-57a9-4942-bd27-4e54d11d0022", 0, "Accounts Street", null, "Address City", "b98c4e10-2b38-4d45-afbd-210f6e3cfd47", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, "Add", "McDress", true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEH0yJ2D3XuKseWxF1ZrVmbXKnaUIzGU8OlnLW4pxNMI0ZzZNzsenDP5bt21N5VRISA==", null, true, "G4 0RF", "a9ccf708-234a-492f-8c76-00c5b7ebd54a", false, "accountsClerk@maxicycles.co.uk" },
                    { "30dd0454-3769-4170-9f71-28204a44d84d", 0, "Media Street", null, "Medialand", "abb65b35-5ad2-43a2-91e2-482b03ca25d4", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, "Media", "Managerio", true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIFSi471x07BedmZojAD9hD2mz/7vraGNM2n46Fp5V4+zec5P8WA1lVOMGZSpp1H7Q==", null, true, "G4 0RF", "194da0e9-5f7f-47bc-8f26-f8cf6de3c2f3", false, "mediaManager@maxicycles.co.uk" },
                    { "5f9446d6-75d6-4f8f-9380-3f574206e72c", 0, "Customer street", null, "Customer City", "f9869296-87e8-4eb9-927b-32ba77741f04", "MaxicyclesUser", "customer@example.co.uk", true, "Customer", "Customerton", true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEDHE5dcm+QriJxQFQFVfPqbqmnZuBuj8blL5L3uxl3yF8v/ac0rr2zP4HNFdi7VleA==", null, true, "G4 0RF", "a6d21610-d3d4-4f97-95d0-2702e88bf576", false, "customer@example.co.uk" },
                    { "da23a1fe-255e-442f-8181-2589cb10d3ad", 0, "Technician street", null, "Tech Town", "6fce9584-a78e-46a2-94d4-9eee1cba40ab", "MaxicyclesUser", "technician@maxicycles.co.uk", true, "Techy", "Techman", true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIU3guhgn97NQ5xJzepM6i0khDb5VCpT5oPYFIu/k3f7OAoHIvbUpadmTcI3NUFRyg==", null, true, "G4 0RF", "7e0581c0-5ab4-4351-a59f-9eaa5b398a28", false, "technician@maxicycles.co.uk" },
                    { "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9", 0, "Stock control street", null, "Stockland", "45a01b4f-1712-4b52-b040-b20794895e0e", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, "Stock", "Controllerington", true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIUP0p4nY4yPemLtYmgr179nhhf0iTCSyTt2GBw8OQ6XdDsIVeNxpq2lk68D1oTHrw==", null, true, "G4 0RF", "da2d0847-b13c-41a9-8268-7c2a67577e23", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, "bikes", "Bikes" },
                    { 2, "skateboards", "Skateboards" },
                    { 3, "accessories", "Accessories" },
                    { 4, "services", "Services" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryMethods",
                columns: new[] { "Id", "IsDaySelectable", "MinDaysToDeliver", "Price", "Title" },
                values: new object[,]
                {
                    { 1, false, 5, 0m, "Free Delivery" },
                    { 2, false, 3, 3.99m, "Fast Delivery" },
                    { 3, true, 1, 10m, "Any Day Delivery" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AltText", "ImageName", "Title", "UploadedAt" },
                values: new object[,]
                {
                    { 1, "Continental GP5000 Folding Tyres", "gp5000.jpg", "Continental GP500 Product Photo", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7353) },
                    { 2, "Vittoria Rubino Pro G2.0 Folding Road Tyres", "vittoria.jpg", "Vittoria Rubino Pro Main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7362) },
                    { 3, "Schwalbe Marathon Plus SmartGuard Wired MTB Tyre - 26", "schwalbe.jpg", "Schwalbe Marathon Plus Main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7364) },
                    { 4, "Colnago V3 Disc Ultegra Carbon Road Bike", "colnago.jpg", "Colnago v3 Main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7366) },
                    { 5, "Ridley Noah Disc 105 Carbon Road Bike - 2023", "ridley_noah.jpg", "Ridley Noah Disc 105 Main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7368) },
                    { 6, "Wizard Lighting 3.3 Disc Sora Road Bike", "wizaard.jpg", "wizaard lighting 3.3 main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7370) },
                    { 7, "Blind Skateboards Reaper Wallpaper FP Youth Complete Skateboard - 7.0'' x 29''", "blind-skateboards-reaper.jpg", "Blind Skateboards Reaper wallpaper", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7371) },
                    { 8, "Element Skateboards Naturalist Complete Skateboard - 7.375'' x 31''", "element-skateboards-naturalist-complete.jpg", "Element Skateboards Naturalist main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7373) },
                    { 9, "Santa Cruz Skateboards Iridescent Dot Complete Skateboard - 8.0'' x 31.25''", "santa-cruz", "Santa cruz iridesent dot main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7374) },
                    { 10, "A bicycle with a flat tyre", "flat-tyre-repair.jpg", "Flat Tyre Repair main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7376) },
                    { 11, "Gear adjusting a bicycle", "gear-shifting.jpg", "Gear Shifting Adjustment main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7377) },
                    { 12, "Bleeding a disc bike brakes", "brake-bleed.jpg", "Brake system main", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7379) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14f456a4-59c9-4f35-bedd-5c70b11f1c68", "00243fc5-17a2-47aa-8ad0-3925abfd0cdf" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "00243fc5-17a2-47aa-8ad0-3925abfd0cdf" },
                    { "0192cfde-5e83-437c-b940-bf583589d311", "04f7e273-57a9-4942-bd27-4e54d11d0022" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "04f7e273-57a9-4942-bd27-4e54d11d0022" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "30dd0454-3769-4170-9f71-28204a44d84d" },
                    { "b5e3427c-022c-4c34-92eb-bfd62e6b04f3", "30dd0454-3769-4170-9f71-28204a44d84d" },
                    { "bba6b48d-453f-49f8-a3e3-adc09a0c154a", "5f9446d6-75d6-4f8f-9380-3f574206e72c" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "da23a1fe-255e-442f-8181-2589cb10d3ad" },
                    { "89847f87-65e8-4c51-bf88-6ff23baa2d01", "da23a1fe-255e-442f-8181-2589cb10d3ad" },
                    { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9" },
                    { "7d8b6011-6b85-4c0b-8501-4aa072818b04", "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Slug", "Title" },
                values: new object[,]
                {
                    { 1, 3, "tyres", "Tyres" },
                    { 2, 2, "complete-decks", "Complete Decks" },
                    { 3, 1, "road-bikes", "Road Bikes" },
                    { 4, 4, "repairs", "Repairs" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discriminator", "ImageId", "Price", "Quantity", "Slug", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 1, "The new era in cycling - the best allrounder in the field, brought to a whole new performance level. Ride faster, more comfortable and with increased puncture protection. Made to make you better. Developing the Grand Prix 5000 nothing has been left to chance.", "Product", 1, 80.40m, 10, "continental-gp5000-folding-tyres", 1, "Continental GP5000 Folding Tyres" },
                    { 2, "Designed for intensive training, it is equally suitable for racing events. The Rubino Pro builds on the standard Rubino platform, utilizing the same exclusive 3C Graphene compound structure, long service life, puncture protection, and sharp handling traits, but substitutes a folding bead material for reduced weight..", "Product", 2, 45m, 20, "vittoria-rubino-pro-g20-folding-road-tyres", 1, "Vittoria Rubino Pro G2.0 Folding Road Tyres" },
                    { 3, "The most puncture resistant MTB tyre. Now with a new dynamic profile. On the central rib it rolls easily over hard paths, while the strong outer lugs give it great off-road traction. The SmartGuard provides superior puncture protection.", "Product", 3, 23.50m, 4, "schwalbe-marathon-plus-smartguard", 1, "Schwalbe Marathon Plus SmartGuard Wired MTB Tyre - 26" },
                    { 4, "When Colnago developed the V3 they thought of all those cyclists who want to get the most out of their investment. Quality carbon and fittings designed to offer an excellent level of performance and contain costs and make V3 a perfectly balanced bike from every point of view. It blends technical solutions that aim at lightness with aerodynamic details. The lines are clean and essential,  it can be fitted with tyres up to 28mm wide. V3 is available in eight sizes and only with disc brakes.", "Product", 4, 2800m, 2, "colnago-v3-disc-ultegra-carbon-road-bike", 3, "Colnago V3 Disc Ultegra Carbon Road Bike" },
                    { 5, "The Noah is both a top aero bike as well as a continuously evolving technological masterpiece. Originally developed as the ultimate sprint bike for team Lotto, it has since incorporated all-round qualities. While it continues to win sprints, it now shines on the cobblestones around Roubaix as well. Thanks to advanced aero-optimized technology combined with of in-depth wind tunnel testing, the Noah is world class in aerodynamics. All tubing, from fork to rear triangle, have an optimized NACA profile. Cables are cleverly integrated into the handlebar/stem. While the Noah may defy wind, it remains a lightweight road bike that's exceptionally comfortable. The Noah Disc has all the same technologies and ride qualities of its big brother, the Noah Fast Disc Caleb Ewan's favourite road bike, but is more budget-friendly.", "Product", 5, 3699m, 2, "ridley-noah-disc-105", 3, "Ridley Noah Disc 105 Carbon Road Bike - 2023" },
                    { 6, "Elevate your road riding experience with confidence and control. This versatile road bike is built on a lightweight 6061 aluminium frame and Shimano components that can handle anything in its path. The Lighting 3.3 Sora is light, fast and comfortable. The sportif geometry positions you forward enough to go hard but upright enough to go cover the miles with ease. The Lighting 3.3 is equipt with Shimano Sora R3000 9 speed drivtrain and mechanical dsic brakes help with better handling and control. Wizard bikes are apart of the Merlin Cycles LTD range, offering quality affordable bikes for all the family.", "Product", 6, 425m, 5, "wizard-lighting-33-disc", 3, "Wizard Lighting 3.3 Disc Sora Road Bike" },
                    { 7, "The Reaper Wallpaper Complete by Blind is available in 7.0'' x 29'' . It features Tensor trucks, 51mm wheels, and is finished with griptape, bearings and bolts. This complete comes fully assembled and ready to skate straight out of the box!", "Product", 7, 75.99m, 4, "blind-skateboards-reaper-wallpaper-complete", 2, "Blind Skateboards Reaper Wallpaper FP Youth Complete Skateboard - 7.0'' x 29''" },
                    { 8, "The Naturalist Complete by Darkstar is available in 7.375'' x 31''. It features Element trucks, 52mm wheels, and is finished with griptape, bearings and bolts. This complete comes fully assembled and ready to skate straight out of the box!", "Product", 7, 79.99m, 6, "element-skateboards-naturalist-complete", 2, "Element Skateboards Naturalist Complete Skateboard - 7.375'' x 31''" },
                    { 9, "The Iridescent Dot Complete by Santa Cruz is available on an 8.0'' x 31.25'' Iridescent Dot deck. It features Bullet trucks, OJ wheels, and is finished with bearings, griptape and bolts. This complete comes fully assembled and ready to skate straight out of the box!", "Product", 9, 71.99m, 3, "santa-cruz-skateboards-dot-complete", 2, "Santa Cruz Skateboards Iridescent Dot Complete Skateboard - 8.0'' x 31.25''" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DailyMaxServices", "Description", "Discriminator", "ImageId", "Price", "Slug", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 10, 6, "Dealing with a flat tire is a common issue that can disrupt your cycling experience. Our expert technicians are equipped to efficiently repair flat tires and get you back on the road quickly. We'll carefully inspect the tire, identify the cause of the puncture, and either patch or replace the tube as needed. Additionally, we'll examine the tire for any signs of damage or wear to ensure optimal performance and prevent future flats. Trust us to restore your tire's functionality and make your cycling adventures worry-free.", "Service", 10, 20m, "flat-tyre-repair", 4, "Flat Tyre Repair" },
                    { 11, 10, "Smooth and precise gear shifting is essential for an enjoyable biking experience. If you're facing issues with shifting gears, our skilled technicians can help. We'll meticulously assess your bike's drivetrain, cables, and derailleurs to identify any misalignments or issues affecting gear shifting. Our team will then make the necessary adjustments, ensuring that your gears engage seamlessly and provide optimal performance. Whether it's a minor tweak or a comprehensive adjustment, we'll work diligently to enhance your bike's shifting functionality.", "Service", 11, 30m, "gear-shifting-adjustment", 4, "Gear Shifting Adjustment" },
                    { 12, 2, "Safety is paramount when it comes to cycling, and a well-maintained brake system is crucial for effective stopping power. Our experienced technicians specialize in comprehensive brake system maintenance. We'll inspect your brake pads, cables, and calipers, checking for any signs of wear, misalignment, or brake fluid leakage. If necessary, we'll replace worn brake pads, adjust cable tension, and align calipers to optimize braking performance. Trust us to ensure that your brakes are in top-notch condition, allowing you to ride with confidence and peace of mind.", "Service", 12, 40m, "brake-system-maintenance", 4, "Brake System Maintenance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14f456a4-59c9-4f35-bedd-5c70b11f1c68", "00243fc5-17a2-47aa-8ad0-3925abfd0cdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "00243fc5-17a2-47aa-8ad0-3925abfd0cdf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0192cfde-5e83-437c-b940-bf583589d311", "04f7e273-57a9-4942-bd27-4e54d11d0022" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "04f7e273-57a9-4942-bd27-4e54d11d0022" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "30dd0454-3769-4170-9f71-28204a44d84d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b5e3427c-022c-4c34-92eb-bfd62e6b04f3", "30dd0454-3769-4170-9f71-28204a44d84d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bba6b48d-453f-49f8-a3e3-adc09a0c154a", "5f9446d6-75d6-4f8f-9380-3f574206e72c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "da23a1fe-255e-442f-8181-2589cb10d3ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89847f87-65e8-4c51-bf88-6ff23baa2d01", "da23a1fe-255e-442f-8181-2589cb10d3ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd", "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d8b6011-6b85-4c0b-8501-4aa072818b04", "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9" });

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0192cfde-5e83-437c-b940-bf583589d311");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14f456a4-59c9-4f35-bedd-5c70b11f1c68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7646f9f0-4ff4-4331-bca6-fb6a9ff64bcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d8b6011-6b85-4c0b-8501-4aa072818b04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89847f87-65e8-4c51-bf88-6ff23baa2d01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5e3427c-022c-4c34-92eb-bfd62e6b04f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba6b48d-453f-49f8-a3e3-adc09a0c154a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00243fc5-17a2-47aa-8ad0-3925abfd0cdf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04f7e273-57a9-4942-bd27-4e54d11d0022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30dd0454-3769-4170-9f71-28204a44d84d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f9446d6-75d6-4f8f-9380-3f574206e72c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da23a1fe-255e-442f-8181-2589cb10d3ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7f5ef5e-5f18-456e-bdcb-607a542fb5b9");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Images",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "AltText",
                table: "Images",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", null, "Admin", "ADMIN" },
                    { "388427c6-eeaf-43d1-a0dc-193508a6e051", null, "MediaManager", "MEDIAMANAGER" },
                    { "480f437a-a401-498d-979c-8b1685719d53", null, "Manager", "MANAGER" },
                    { "7887de42-0a5a-47d4-bba1-fbe8adb446fc", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "8938b3d9-3d56-4be7-b7f9-3b7b0fb67104", null, "Customer", "CUSTOMER" },
                    { "a2ac09bd-7c96-4494-a6bc-5d31699e0603", null, "StockControl", "STOCKCONTROL" },
                    { "a9a83e79-05ad-45b6-bbe4-c25bc334cf7e", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e7a17e0-7af9-4567-bfd7-506fa617ba6a", 0, null, null, null, "05379f8d-a8f0-4835-9dfb-24aac8f886a1", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEORiMVGHMAb8zJ6xAEY2yk97rJyVfFVPdFS6rAudIWZ/K4Eq9ZvSsUzLSqfMfTxdjA==", null, true, null, "a51dc194-1c31-48b4-a259-9d01d9faf5ce", false, "stockControl@maxicycles.co.uk" },
                    { "428926e3-6ce1-457f-be1d-a4e309fca1ac", 0, null, null, null, "8416dffc-5ab4-4f19-a7dd-3ed18b63c297", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMLF2Ra1b5p1HYhMgF1lfzCKxeQvjis0AxsAWC+hETjcxY6IbfJ7TabXrW1zfRWQxg==", null, true, null, "56a6dd31-c314-4fce-b208-ce629830f0da", false, "manager@maxicycles.co.uk" },
                    { "54145407-02fc-437f-9711-01e40db356a4", 0, null, null, null, "8d5617a5-0965-4dbb-85e8-fc397232ee90", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEL2vj85rIuCLMNlMxv64uRbaKokm1KBefHq+wfcCACR6TZZmc1OvttijmqI96m2aEg==", null, true, null, "17adb9e3-f155-4bd9-8264-270799e895b8", false, "technician@maxicycles.co.uk" },
                    { "75af3e1b-023f-4878-a060-6af94834a8ed", 0, null, null, null, "5943afe3-69b9-44bf-9619-8cc8c6004e91", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELbP77suT45JYcwMN0ysHaPQinISzSUELMmQdsYxo618H4cGBK/11xGwQZpkW+a6kw==", null, true, null, "7c7801a2-fed3-4e2d-9e43-2c98f57b8dd3", false, "mediaManager@maxicycles.co.uk" },
                    { "ad161d87-d5a0-4199-ab44-49885ff098bb", 0, null, null, null, "e0b1065d-590d-4e72-a73b-876e20ed0a08", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEPfKcGqqc+CnwDkOojwRK3wBD/i8mqU7jgO/ApE4+/5yDnoa8UT4CuVIfQH68i/sjg==", null, true, null, "3536cafb-1da2-45d8-bf5d-b32dae21cd08", false, "customer@example.co.uk" },
                    { "ae3579cd-9655-4857-a3a7-0e996da546e9", 0, null, null, null, "b2d2e56d-5b94-4a85-b069-4471f21a0300", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEAhSY2qY0bl2XS8Rts9y+LS3oKjuOyAjz0jQElRCt5j5jDqx/QMpl4w0BPAwaA4mXw==", null, true, null, "e31216cc-3f28-400f-b7da-55043bcbe595", false, "accountsClerk@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "1e7a17e0-7af9-4567-bfd7-506fa617ba6a" },
                    { "a2ac09bd-7c96-4494-a6bc-5d31699e0603", "1e7a17e0-7af9-4567-bfd7-506fa617ba6a" },
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "428926e3-6ce1-457f-be1d-a4e309fca1ac" },
                    { "480f437a-a401-498d-979c-8b1685719d53", "428926e3-6ce1-457f-be1d-a4e309fca1ac" },
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "54145407-02fc-437f-9711-01e40db356a4" },
                    { "a9a83e79-05ad-45b6-bbe4-c25bc334cf7e", "54145407-02fc-437f-9711-01e40db356a4" },
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "75af3e1b-023f-4878-a060-6af94834a8ed" },
                    { "388427c6-eeaf-43d1-a0dc-193508a6e051", "75af3e1b-023f-4878-a060-6af94834a8ed" },
                    { "8938b3d9-3d56-4be7-b7f9-3b7b0fb67104", "ad161d87-d5a0-4199-ab44-49885ff098bb" },
                    { "0285c5eb-0494-4aa1-b687-af86b1ade8c0", "ae3579cd-9655-4857-a3a7-0e996da546e9" },
                    { "7887de42-0a5a-47d4-bba1-fbe8adb446fc", "ae3579cd-9655-4857-a3a7-0e996da546e9" }
                });
        }
    }
}
