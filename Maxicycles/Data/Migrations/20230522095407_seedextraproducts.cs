using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedextraproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", null, "Admin", "ADMIN" },
                    { "2fd42342-3bc0-427b-808b-bff1c85f6b01", null, "StockControl", "STOCKCONTROL" },
                    { "3a5ced06-aaa2-44bb-b2d1-37c1f1272dc1", null, "Customer", "CUSTOMER" },
                    { "4b18d5eb-2a4b-4461-9d00-a447372770b4", null, "Manager", "MANAGER" },
                    { "55130939-a612-47a2-9928-b34912ebc1ff", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "650781a9-1cf1-415e-b8b3-e76b46436d2d", null, "Technician", "TECHNICIAN" },
                    { "c8a78099-8947-4083-88d2-8c7f18b48584", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2792d348-49f9-4dc1-b792-ead1c921f302", 0, "Technician street", null, "Tech Town", "bdcc5704-9206-4b48-b9e1-cab56b4b6634", "MaxicyclesUser", "technician@maxicycles.co.uk", true, "Techy", "Techman", true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFFXuaCAw/klzYWXdwdXh+lZNdFEcnODHIXmZC5P3ZY1FKikg6vxwzomMUD5MwsHcw==", null, true, "G4 0RF", "0434f16d-81e5-4551-af6f-8e88fad29d1a", false, "technician@maxicycles.co.uk" },
                    { "4ca69a22-d439-4a79-a16f-4d7e4e06823d", 0, "Stock control street", null, "Stockland", "00758389-7911-44e3-a287-cea71d4405ec", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, "Stock", "Controllerington", true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMpzwuhGWoeXKWoGCRgzsZi55v/cNjHhPnImriujbO/NGSwzoUJU8e/5ZVSCS3oKXA==", null, true, "G4 0RF", "45f07d0d-afc5-4642-80b5-f949eee31b03", false, "stockControl@maxicycles.co.uk" },
                    { "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e", 0, "Accounts Street", null, "Address City", "c5cd2386-ccd4-4430-8102-ec6f37bc9442", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, "Add", "McDress", true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPrpW5eRBv/0trsmhiGvyYvv/puW9VUP7KWnS7CHpVPK+lb9V7+24kq7gl9XIYXsyw==", null, true, "G4 0RF", "71c532a3-fd6e-410d-95c2-3c5cbfef79b8", false, "accountsClerk@maxicycles.co.uk" },
                    { "94a7cbeb-2b5b-4694-9312-daaba129903e", 0, "Media Street", null, "Medialand", "f1ccd298-5ce0-4e73-bc48-4fc40eef0b4b", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, "Media", "Managerio", true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECxlQigslxZ8E1DOvi5qrv64eTLw+zooXomHOGze55ijXC31BOtqjpONM5RmxIol3Q==", null, true, "G4 0RF", "204d6208-b1bd-40f6-a10a-35e24b9de52e", false, "mediaManager@maxicycles.co.uk" },
                    { "bd987cf1-fd7d-4e11-bbf1-1218f20aa872", 0, "Manager Street", null, "Managerburgh", "67b96d98-70d8-4dcd-8d2e-d7a506af9ebb", "MaxicyclesUser", "manager@maxicycles.co.uk", true, "Man", "Ager", true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBTuDSRwBuRzVQFG3TS8alTUa6kWdzsiXSNyrobO3XRSTvdk086UlTB/DolqMcRLnw==", null, true, "G4 0RF", "61c17695-67d5-4573-ba57-cdd383c7b5c1", false, "manager@maxicycles.co.uk" },
                    { "e41c8d5e-52c9-414b-8685-8179709bb9fd", 0, "Customer street", null, "Customer City", "81d57139-c10b-45c8-bf2f-0395b7b13ed2", "MaxicyclesUser", "customer@example.co.uk", true, "Customer", "Customerton", true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEI464UE+swo3C4RUlw+dZ3Y1LR1ZcWQxJU0V/1HY4C95mgHGtAyYg0/LyMyNPjz70g==", null, true, "G4 0RF", "d8bab622-46fb-4df9-b8fe-5b48d754bdc3", false, "customer@example.co.uk" }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageName", "UploadedAt" },
                values: new object[] { "santa-cruz.jpg", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AltText", "ImageName", "Title", "UploadedAt" },
                values: new object[,]
                {
                    { 13, "Native OG Logo (Blue Stain) Skateboard Deck 8.38", "native-og-logo.jpg", "Native OG Logo (Blue Stain) Skateboard Deck", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(221) },
                    { 14, "Picture Show No Place Like Home Skateboard Deck ", "picture-show-no-place.jpg", "Picture Show No Place Like Home Skateboard Deck ", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(222) },
                    { 15, "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25", "toy-machine-skateboards.jpg", "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(223) },
                    { 16, "Pro-Tec Street Elbow Pads - Black/White Checker", "pro-tec-street-elbow-pads.jpg", "Pro-Tec Street Elbow Pads - Black/White Checker", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(224) },
                    { 17, "187 Killer Pads Fly Skate Knee Pads - Black", "187-killer-pads.jpg", "187 Killer Pads Fly Skate Knee Pads - Black", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(226) },
                    { 18, "REKD Protection Pro Ramp Knee Pads - Black", "rekd-protection-pro-ramp.jpg", "REKD Protection Pro Ramp Knee Pads - Black", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(227) },
                    { 19, "MET Trenta 3K Carbon MIPS Road Bike Helmet", "trenta_3k_carbonjpg.jpg", "MET Trenta 3K Carbon MIPS Road Bike Helmet", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(229) },
                    { 20, "Kask Protone WG11 Road Cycling Helmet - 2022", "kask_protone_wg11.jpg", "Kask Protone WG11 Road Cycling Helmet - 2022", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(230) },
                    { 21, "MET Allroad Road Helmet", "met_allroad.jpg", "MET Allroad Road Helmet", new DateTime(2023, 5, 22, 9, 54, 6, 812, DateTimeKind.Utc).AddTicks(231) }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Slug", "Title" },
                values: new object[] { "complete-skateboards", "Complete Skateboards" });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Slug", "Title" },
                values: new object[] { "complete-bikes", "Complete Bikes" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Slug", "Title" },
                values: new object[,]
                {
                    { 5, 2, "decks", "Decks" },
                    { 6, 3, "helmets", "Helmets" },
                    { 7, 3, "Pads", "Pads" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "2792d348-49f9-4dc1-b792-ead1c921f302" },
                    { "650781a9-1cf1-415e-b8b3-e76b46436d2d", "2792d348-49f9-4dc1-b792-ead1c921f302" },
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "4ca69a22-d439-4a79-a16f-4d7e4e06823d" },
                    { "2fd42342-3bc0-427b-808b-bff1c85f6b01", "4ca69a22-d439-4a79-a16f-4d7e4e06823d" },
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e" },
                    { "55130939-a612-47a2-9928-b34912ebc1ff", "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e" },
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "94a7cbeb-2b5b-4694-9312-daaba129903e" },
                    { "c8a78099-8947-4083-88d2-8c7f18b48584", "94a7cbeb-2b5b-4694-9312-daaba129903e" },
                    { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "bd987cf1-fd7d-4e11-bbf1-1218f20aa872" },
                    { "4b18d5eb-2a4b-4461-9d00-a447372770b4", "bd987cf1-fd7d-4e11-bbf1-1218f20aa872" },
                    { "3a5ced06-aaa2-44bb-b2d1-37c1f1272dc1", "e41c8d5e-52c9-414b-8685-8179709bb9fd" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discriminator", "ImageId", "Price", "Quantity", "Slug", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 13, "OG Logo Deck 8.38'', Wide 14.25'', WB 7 Ply Canadian Maple, Colour - Yellow Stain", "Product", 13, 30.39m, 4, "native-og-logo-deck", 5, "Native OG Logo (Blue Stain) Skateboard Deck 8.38''" },
                    { 14, "No Place Like Home Deck, 8.5'' Wide, 14.5'' WB, 7-Ply Canadian Maple, Team Model", "Product", 14, 69.99m, 2, "picture-show-deck", 5, "Picture Show No Place Like Home Skateboard Deck 8.5'' " },
                    { 15, "Mind Control Deck, 8.25'' x 31.98'', 14.25'' WB, 7-Ply Canadian Maple, Axel Pro Model, Mind Control Graphic Series", "Product", 15, 64.99m, 2, "mind-control-deck", 5, "Toy Machine Skateboards Axel Mind Control Skateboard Deck 8.25''" },
                    { 16, "he Street Elbow Pads by Pro-Tec are a great value pad designed to reduce impact when skating. The Street Elbow pads feature a locked in EVA foam that is designed to lock your elbow in for maximum protection, ballsitic nylon construction that resists tears and protects from skids and scrapes, a curved hard cap that allows better protection, perforated neoprene for better ventilation and adjustable velcor straps. A great value pad, it is available in Black/White checker colourway", "Product", 16, 19.99m, 30, "pro-tec-elbow-pads", 7, "Pro-Tec Street Elbow Pads - Black/White Checker" },
                    { 17, "The Fly Knee Pads from 187 Killer Pads, is available in a black colourway, and is their slimmest and most versatile knee pad. Although its primarily designed for skateboarding, you can use these with other sports too. ", "Product", 17, 31.99m, 10, "fly-knee-pads", 7, "187 Killer Pads Fly Skate Knee Pads - Black" },
                    { 18, "REKD Protections Pro Ramp Knee pads are designed for riders who want extra protection as well as extra comfort. Perfect for all abilities the Pro Ramp Knee pad features high density impact ramp caps, ergonomic knee recesses, dual neoprene butterfly closure and layered heavy duty EVA memory foam. These pads are available in black.", "Product", 18, 23.96m, 30, "rekd-pro-ramp-knees", 7, "REKD Protection Pro Ramp Knee Pads - Black" },
                    { 19, "The MET Trenta 3K Carbon Mips® is a high performance road helmet designed with elite cyclists and worn to victory a Le Tour de France and the monuments of Liège-Bastogne-Liège and Il Lombardia. Engineered to keep your head fresh and save you energy with every pedal stroke, the MET Trenta 3K Carbon Mips® is the most advanced road cycling helmet we have ever made, now upgraded with the addition of Mips AIR®, the lightest and most advanced rotational management system.", "Product", 19, 180m, 5, "met-trenta-3k-carbon", 6, "MET Trenta 3K Carbon MIPS Road Bike Helmet " },
                    { 20, "With just 215g of weight, the Kask Protone has the lowest drag and the fastest heat dissipation coefficients compared to any other ventilated helmet. Thanks to several ventilation holes and a thick padding material, heat and moisture are dissipated very fast, improving comfort and performance without giving up on safety: the top area is reinforced with an internal plastic sub-structure that increases crash protection.", "Product", 20, 120m, 4, "kask-protone", 6, "Kask Protone WG11 Road Cycling Helmet - 2022" },
                    { 21, "The MET Allroad is made for those who enjoy spending time on the saddle, whether on the tarmac or on gravel routes. Sporty on one side, comfy on the other. It’s exceptionally lightweight and secure thanks to MET’s distinghuishing design.", "Product", 21, 48.99m, 2, "met-allroad", 6, "MET Allroad Road Helmet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "2792d348-49f9-4dc1-b792-ead1c921f302" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "650781a9-1cf1-415e-b8b3-e76b46436d2d", "2792d348-49f9-4dc1-b792-ead1c921f302" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "4ca69a22-d439-4a79-a16f-4d7e4e06823d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2fd42342-3bc0-427b-808b-bff1c85f6b01", "4ca69a22-d439-4a79-a16f-4d7e4e06823d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55130939-a612-47a2-9928-b34912ebc1ff", "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "94a7cbeb-2b5b-4694-9312-daaba129903e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8a78099-8947-4083-88d2-8c7f18b48584", "94a7cbeb-2b5b-4694-9312-daaba129903e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb", "bd987cf1-fd7d-4e11-bbf1-1218f20aa872" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b18d5eb-2a4b-4461-9d00-a447372770b4", "bd987cf1-fd7d-4e11-bbf1-1218f20aa872" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a5ced06-aaa2-44bb-b2d1-37c1f1272dc1", "e41c8d5e-52c9-414b-8685-8179709bb9fd" });

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19d64e3b-b3cb-4ca3-8ff2-6778dca0f8cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd42342-3bc0-427b-808b-bff1c85f6b01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a5ced06-aaa2-44bb-b2d1-37c1f1272dc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b18d5eb-2a4b-4461-9d00-a447372770b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55130939-a612-47a2-9928-b34912ebc1ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "650781a9-1cf1-415e-b8b3-e76b46436d2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a78099-8947-4083-88d2-8c7f18b48584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2792d348-49f9-4dc1-b792-ead1c921f302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ca69a22-d439-4a79-a16f-4d7e4e06823d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79c2dce1-81e1-4b9b-8d0a-8f29692b9f4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94a7cbeb-2b5b-4694-9312-daaba129903e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd987cf1-fd7d-4e11-bbf1-1218f20aa872");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e41c8d5e-52c9-414b-8685-8179709bb9fd");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7);

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

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageName", "UploadedAt" },
                values: new object[] { "santa-cruz", new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "UploadedAt",
                value: new DateTime(2023, 5, 22, 8, 53, 26, 505, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Slug", "Title" },
                values: new object[] { "complete-decks", "Complete Decks" });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Slug", "Title" },
                values: new object[] { "road-bikes", "Road Bikes" });

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
        }
    }
}
