using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDeliveryMethods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22a236e6-013c-4c64-8499-c25f39d17a08", "0a9c44fc-459c-44a7-aed0-c559ebcf01b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", "94fb5237-1cc8-445e-b726-8b7892a9162e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "621e39d4-996f-4797-872e-6e8d1d6b0e52", "a2928449-4ae1-4bab-9864-e0effe93d595" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", "a85aedf6-fc1a-45ed-ba3e-7026383e54cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c4b83b4-128a-4c34-8762-098ddb24e659", "cc4f9203-b317-4127-9ae8-fd0a483696f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5905122e-ace5-4c9c-a798-744e3487c110", "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22a236e6-013c-4c64-8499-c25f39d17a08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4b83b4-128a-4c34-8762-098ddb24e659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5905122e-ace5-4c9c-a798-744e3487c110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "621e39d4-996f-4797-872e-6e8d1d6b0e52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa21b43-4890-4054-bb7f-ea1ca3adaed8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef8ff52a-cb3f-4bce-8813-278cc6c23f27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9c44fc-459c-44a7-aed0-c559ebcf01b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94fb5237-1cc8-445e-b726-8b7892a9162e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2928449-4ae1-4bab-9864-e0effe93d595");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a85aedf6-fc1a-45ed-ba3e-7026383e54cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc4f9203-b317-4127-9ae8-fd0a483696f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5");

            migrationBuilder.CreateTable(
                name: "DeliveryMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MinDaysToDeliver = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a60088e-3f43-4cee-81b1-8b801b09f43e", null, "Customer", "CUSTOMER" },
                    { "1e610396-57de-4a8a-a06d-d070f5dc70f5", null, "StockControl", "STOCKCONTROL" },
                    { "24032058-0eb7-41b9-9da0-87409fa352f8", null, "Manager", "MANAGER" },
                    { "81ba8c59-389a-41a8-b5b7-15979e872374", null, "Technician", "TECHNICIAN" },
                    { "ef68838e-cb45-438a-bdd5-48e031a88a7c", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "530cfa61-53b5-416a-b035-0db137aecca7", 0, null, null, null, "d27b419f-d964-4e60-838f-11bfab1d21d5", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEC4VnqmLMyizB/452hsx+miHDhZu6j+KsK1KPCY0gntflu6wHAUYsNgYrSJkHCwisA==", null, true, null, "ca60a6ab-6e64-49b9-9953-00fde053b79b", false, "customer@example.co.uk" },
                    { "659b6f67-9d5b-41fe-8758-41f78b909ee0", 0, null, null, null, "680fe470-62a5-438f-a6c6-ebb0553a9f52", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEECPhlMHt1i8kkhoPCoKWKdPNymRC8EbwQRpcPAMbgYct/0csSlaVT4NSGhGlfqrfA==", null, true, null, "7d204845-053e-423f-973c-7d46da621d5b", false, "manager@maxicycles.co.uk" },
                    { "7aa0f806-552c-4693-92d9-935cafac8275", 0, null, null, null, "c0961d7a-0896-4be0-b546-48d914117e22", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBqyNKArzLKNIiQMI8s8r6VFA7pXswTkFpnNsmKHGgaD7LXFZDL+3CTnIGEOVaINdg==", null, true, null, "3093bd7d-f494-436f-8dc8-9cc4833d3df0", false, "mediaManager@maxicycles.co.uk" },
                    { "8bd3b947-dbd5-4b43-9037-9ef46badb551", 0, null, null, null, "8b62e72a-6f92-42c6-9d82-bdd7b5884d50", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEOrQt65N6LiI9yf2w5ic8tP7XPdbfmNpGpg3BRycx94wZ/Hqcb9oEU3mdY8ym4hOVQ==", null, true, null, "7cb65f89-dfc1-4d75-a786-926dc352f952", false, "accountsClerk@maxicycles.co.uk" },
                    { "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea", 0, null, null, null, "5778aa86-bb8b-41cc-ace8-3fc479381224", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHxuUZSaJSKBIHXmyrXl3xCpHjm0m7VncIkAIXOgp90Am3xyvozGEONyKv0Z/XGdzg==", null, true, null, "f6dc2ce1-67d0-4ddb-8caf-7c7abc510753", false, "technician@maxicycles.co.uk" },
                    { "d7b2187b-a3b6-442e-b8dd-70ce72421fbe", 0, null, null, null, "756aa394-e12a-4781-aa72-483fc17956a5", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFtLx3T905aP5pNCobspXxjvx1dfEFynFVhbegOnMYO3+B4vZRnA/cEutyF/udnzvw==", null, true, null, "85968f55-f413-4a1e-9533-b7a90bef0893", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a60088e-3f43-4cee-81b1-8b801b09f43e", "530cfa61-53b5-416a-b035-0db137aecca7" },
                    { "24032058-0eb7-41b9-9da0-87409fa352f8", "659b6f67-9d5b-41fe-8758-41f78b909ee0" },
                    { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", "7aa0f806-552c-4693-92d9-935cafac8275" },
                    { "ef68838e-cb45-438a-bdd5-48e031a88a7c", "8bd3b947-dbd5-4b43-9037-9ef46badb551" },
                    { "81ba8c59-389a-41a8-b5b7-15979e872374", "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea" },
                    { "1e610396-57de-4a8a-a06d-d070f5dc70f5", "d7b2187b-a3b6-442e-b8dd-70ce72421fbe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryMethods");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a60088e-3f43-4cee-81b1-8b801b09f43e", "530cfa61-53b5-416a-b035-0db137aecca7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24032058-0eb7-41b9-9da0-87409fa352f8", "659b6f67-9d5b-41fe-8758-41f78b909ee0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", "7aa0f806-552c-4693-92d9-935cafac8275" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef68838e-cb45-438a-bdd5-48e031a88a7c", "8bd3b947-dbd5-4b43-9037-9ef46badb551" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81ba8c59-389a-41a8-b5b7-15979e872374", "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e610396-57de-4a8a-a06d-d070f5dc70f5", "d7b2187b-a3b6-442e-b8dd-70ce72421fbe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a60088e-3f43-4cee-81b1-8b801b09f43e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e610396-57de-4a8a-a06d-d070f5dc70f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24032058-0eb7-41b9-9da0-87409fa352f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ba8c59-389a-41a8-b5b7-15979e872374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef68838e-cb45-438a-bdd5-48e031a88a7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "530cfa61-53b5-416a-b035-0db137aecca7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "659b6f67-9d5b-41fe-8758-41f78b909ee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7aa0f806-552c-4693-92d9-935cafac8275");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bd3b947-dbd5-4b43-9037-9ef46badb551");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7b2187b-a3b6-442e-b8dd-70ce72421fbe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22a236e6-013c-4c64-8499-c25f39d17a08", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "4c4b83b4-128a-4c34-8762-098ddb24e659", null, "Technician", "TECHNICIAN" },
                    { "5905122e-ace5-4c9c-a798-744e3487c110", null, "MediaManager", "MEDIAMANAGER" },
                    { "621e39d4-996f-4797-872e-6e8d1d6b0e52", null, "Customer", "CUSTOMER" },
                    { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", null, "StockControl", "STOCKCONTROL" },
                    { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a9c44fc-459c-44a7-aed0-c559ebcf01b8", 0, null, null, null, "89b9c50b-21d0-44c9-8574-73f174b3c009", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHOtb6ECDjrN4W0diFY0g6Z1LvXXEhvVD2VsHMiT1rsg22hBj0YELaqJJ0vrIRNe9g==", null, true, null, "c18e43ff-3d94-423e-a69a-852dbf7e8959", false, "accountsClerk@maxicycles.co.uk" },
                    { "94fb5237-1cc8-445e-b726-8b7892a9162e", 0, null, null, null, "ad57bf64-b4b9-42f5-9393-7af1fb697807", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMUT+pfDWnrNDjYt2WEE+82iaBdq7zdhtunSGOeyGtnuqrGysEnYMu3SIvsbIATmTA==", null, true, null, "d45da9fb-2341-4f4d-b22b-3fdff8dd8539", false, "stockControl@maxicycles.co.uk" },
                    { "a2928449-4ae1-4bab-9864-e0effe93d595", 0, null, null, null, "b53261f4-600e-431d-8da5-bc13147cd80e", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEMs8tGfSGZe5CSBsN/qqkf4IuVmkXPQbfdjpoah3aimiLVtSYDvC+StRjV0vq9qfkA==", null, true, null, "de47e1ac-7543-4f22-b29e-fddbde732c14", false, "customer@example.co.uk" },
                    { "a85aedf6-fc1a-45ed-ba3e-7026383e54cd", 0, null, null, null, "645a25c7-7072-4bf3-a46f-b95ae53f0195", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECdQy5Wyrg7auF8UokHBt2+7Hu2/HBG5zTwvOVM4CXIDJ5iUEinf+M+2x54/nylHyw==", null, true, null, "78f3f184-7f85-455e-9869-c4e707fd382a", false, "manager@maxicycles.co.uk" },
                    { "cc4f9203-b317-4127-9ae8-fd0a483696f0", 0, null, null, null, "3f64e1e3-c51d-458a-947d-afb0521e4016", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFLIOqgStjUrdDuDXonG00yOtzEtwD3ft3rKvjV/dmfsVLMK+BIGxDlz+u1hS1/Knw==", null, true, null, "603887d3-01cc-40f3-a4e1-3afa7bfd3820", false, "technician@maxicycles.co.uk" },
                    { "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5", 0, null, null, null, "04efc441-3557-4780-926e-db876630ca30", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGM0I3+FBIoRA7e9pyYD6mDV/0L2wZQ7xrghYWDJekdyK/KHim8LpybpJsV6Fw7bpA==", null, true, null, "c0a8eb76-e2ca-4853-9ac0-2865f32909f1", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "22a236e6-013c-4c64-8499-c25f39d17a08", "0a9c44fc-459c-44a7-aed0-c559ebcf01b8" },
                    { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", "94fb5237-1cc8-445e-b726-8b7892a9162e" },
                    { "621e39d4-996f-4797-872e-6e8d1d6b0e52", "a2928449-4ae1-4bab-9864-e0effe93d595" },
                    { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", "a85aedf6-fc1a-45ed-ba3e-7026383e54cd" },
                    { "4c4b83b4-128a-4c34-8762-098ddb24e659", "cc4f9203-b317-4127-9ae8-fd0a483696f0" },
                    { "5905122e-ace5-4c9c-a798-744e3487c110", "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5" }
                });
        }
    }
}
