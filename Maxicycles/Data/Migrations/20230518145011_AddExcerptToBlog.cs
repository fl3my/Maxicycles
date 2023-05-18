using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddExcerptToBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ebdb0d9-6d8f-4f4b-9719-2e5f3c335ab3", "13a06023-3b8d-4676-a16a-5a28b7a4a87e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11597b69-e2f7-4c3d-a8d7-acefa4606491", "3e6eaae2-0740-49ae-b6c9-4cb389d49444" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1b67cbd-69ae-4bad-b3e1-faeae94e83d4", "63af435c-2ea4-4503-9849-ed584fb39fce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbc25ab1-5047-438a-b60a-a7cca7b407e0", "66b0479d-1690-4f8f-9d9b-2dc47a1d2da3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f4dec19-9aec-428a-9481-27c8652bd6a8", "bcde1887-a699-4547-afef-b9299119c0b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "167d6a9a-bfc8-47af-9d1f-a2595daf3e7b", "fe652daf-b222-44a8-94f2-592de99cfc67" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11597b69-e2f7-4c3d-a8d7-acefa4606491");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "167d6a9a-bfc8-47af-9d1f-a2595daf3e7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ebdb0d9-6d8f-4f4b-9719-2e5f3c335ab3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f4dec19-9aec-428a-9481-27c8652bd6a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b67cbd-69ae-4bad-b3e1-faeae94e83d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc25ab1-5047-438a-b60a-a7cca7b407e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13a06023-3b8d-4676-a16a-5a28b7a4a87e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6eaae2-0740-49ae-b6c9-4cb389d49444");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63af435c-2ea4-4503-9849-ed584fb39fce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66b0479d-1690-4f8f-9d9b-2dc47a1d2da3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcde1887-a699-4547-afef-b9299119c0b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe652daf-b222-44a8-94f2-592de99cfc67");

            migrationBuilder.AddColumn<string>(
                name: "Excerpt",
                table: "Post",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0200c963-ec34-42b4-a1f0-016efb231838", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "0698c41c-4c51-46dc-80f3-e2050f974846", null, "Customer", "CUSTOMER" },
                    { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", null, "Technician", "TECHNICIAN" },
                    { "505c8516-9fa4-4df4-ae12-1fecf9577488", null, "MediaManager", "MEDIAMANAGER" },
                    { "54a072b2-ca6b-49a1-800c-62cc128eabcf", null, "Manager", "MANAGER" },
                    { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1606403c-38b4-4d95-903a-ee865708bd80", 0, null, null, null, "b2c4864a-58f5-4bcf-9e85-cc856a75f70c", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECw4v5+9G+PoVQmnrreGrOWWLaVnMsXWQjsCGnQZsm84tGcT/tVe4JF48GFpzVgGSQ==", null, true, null, "2c609753-d30c-4221-94cf-0273716242c9", false, "manager@maxicycles.co.uk" },
                    { "1d30cc47-4ae3-4688-8b08-7e2779bed5e9", 0, null, null, null, "1d967265-9c44-4af1-ab05-a805ac06c38e", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEL8kiHgFoFIEYVTfD0JK7DLEeJ6Cf7ng62wkXBqfc7f4t5550nuzTzkuK1pTzg+y8g==", null, true, null, "0a456573-39b3-4f14-a92e-bbc1f9275928", false, "accountsClerk@maxicycles.co.uk" },
                    { "5b8a5050-b678-4974-bee8-1a0c54a42704", 0, null, null, null, "a964b7ee-7cb7-4651-830b-be7ecaffb0f0", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEJPGNV8UhodHww68+2O9X+/5aI2PbNrWdb0g0swfwcIh/hqFNlgp6oUU9g2vBxawiw==", null, true, null, "620f3c85-977a-4db5-a855-39152ceeec5b", false, "customer@example.co.uk" },
                    { "9455f4f6-06e0-4601-99bc-623394af1200", 0, null, null, null, "bc91ebf1-79c7-4999-bd5c-180769d77a0e", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDT1yWo+/3GgRJw+smWlB1b6QuQipZ1gK9kf/Hq0LeieYj7spnap60wTT8s3VCE91Q==", null, true, null, "dab4790e-516e-4516-ac0f-957759f0a5b2", false, "technician@maxicycles.co.uk" },
                    { "9f595c4a-cce1-4d94-bea3-c48ca97ce911", 0, null, null, null, "3af37975-26e2-42f4-bd3b-75ae4987f3cc", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMukpeeZPJZRbLZWftMsE2aW5YaAUQ3zbOHuibPE3TBvkBqDzRjvwFTgNRb9HC/9LA==", null, true, null, "0d5845d3-1a06-4725-8e2c-8781bb4ee1e4", false, "mediaManager@maxicycles.co.uk" },
                    { "e5bc009f-9b06-47c1-b93d-9f06dc54478a", 0, null, null, null, "4da643de-6aaf-43ef-a245-aed58ce2c37f", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIOzDk8yjH+M7lsStC2BeUEZQneBkKK2iAyh6Vy0H2NKMbgl+mETrs6W4wr6wqkJIw==", null, true, null, "50d7582f-7152-46e9-8e22-2293af67716e", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54a072b2-ca6b-49a1-800c-62cc128eabcf", "1606403c-38b4-4d95-903a-ee865708bd80" },
                    { "0200c963-ec34-42b4-a1f0-016efb231838", "1d30cc47-4ae3-4688-8b08-7e2779bed5e9" },
                    { "0698c41c-4c51-46dc-80f3-e2050f974846", "5b8a5050-b678-4974-bee8-1a0c54a42704" },
                    { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", "9455f4f6-06e0-4601-99bc-623394af1200" },
                    { "505c8516-9fa4-4df4-ae12-1fecf9577488", "9f595c4a-cce1-4d94-bea3-c48ca97ce911" },
                    { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", "e5bc009f-9b06-47c1-b93d-9f06dc54478a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54a072b2-ca6b-49a1-800c-62cc128eabcf", "1606403c-38b4-4d95-903a-ee865708bd80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0200c963-ec34-42b4-a1f0-016efb231838", "1d30cc47-4ae3-4688-8b08-7e2779bed5e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0698c41c-4c51-46dc-80f3-e2050f974846", "5b8a5050-b678-4974-bee8-1a0c54a42704" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", "9455f4f6-06e0-4601-99bc-623394af1200" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "505c8516-9fa4-4df4-ae12-1fecf9577488", "9f595c4a-cce1-4d94-bea3-c48ca97ce911" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", "e5bc009f-9b06-47c1-b93d-9f06dc54478a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0200c963-ec34-42b4-a1f0-016efb231838");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0698c41c-4c51-46dc-80f3-e2050f974846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1917e3bc-fb32-44c4-b655-4b0c5af9c27f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "505c8516-9fa4-4df4-ae12-1fecf9577488");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54a072b2-ca6b-49a1-800c-62cc128eabcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb18fb07-47ea-4c35-811f-c70e7653b5b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1606403c-38b4-4d95-903a-ee865708bd80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d30cc47-4ae3-4688-8b08-7e2779bed5e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b8a5050-b678-4974-bee8-1a0c54a42704");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9455f4f6-06e0-4601-99bc-623394af1200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f595c4a-cce1-4d94-bea3-c48ca97ce911");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5bc009f-9b06-47c1-b93d-9f06dc54478a");

            migrationBuilder.DropColumn(
                name: "Excerpt",
                table: "Post");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11597b69-e2f7-4c3d-a8d7-acefa4606491", null, "MediaManager", "MEDIAMANAGER" },
                    { "167d6a9a-bfc8-47af-9d1f-a2595daf3e7b", null, "Manager", "MANAGER" },
                    { "1ebdb0d9-6d8f-4f4b-9719-2e5f3c335ab3", null, "Technician", "TECHNICIAN" },
                    { "8f4dec19-9aec-428a-9481-27c8652bd6a8", null, "Customer", "CUSTOMER" },
                    { "a1b67cbd-69ae-4bad-b3e1-faeae94e83d4", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "dbc25ab1-5047-438a-b60a-a7cca7b407e0", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13a06023-3b8d-4676-a16a-5a28b7a4a87e", 0, null, null, null, "181c0fbd-8c6f-43a3-8f93-cea7a82fd731", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDSSk4NEueDLndaGDmIwNub6iPQQKKZfDgPjbm5m+CQOZNYWjjPq5wF/x4WkMZznCQ==", null, true, null, "79a74737-e772-4827-872a-1585ef5ebef1", false, "technician@maxicycles.co.uk" },
                    { "3e6eaae2-0740-49ae-b6c9-4cb389d49444", 0, null, null, null, "d1eef792-3d97-4b43-8216-9ffe02e4e9c8", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEE+7XQykFdrE514bcxTe8EdarUz3J3p59z1/znJV5Jghd3A+ndgWCSEjNF5OrhB7bg==", null, true, null, "2a9e5f1a-26b4-4c63-a095-fdcd84d1c7fe", false, "mediaManager@maxicycles.co.uk" },
                    { "63af435c-2ea4-4503-9849-ed584fb39fce", 0, null, null, null, "21f57782-f5b5-4670-9831-d78077fb0b19", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBNxDgetD3w/JQa8QHqGLP2EapH1mw5jL6SHNpvbq9Ta6ecixPyTJBxF/J1m0VfmNQ==", null, true, null, "c6638f92-6ab0-4bd3-9b2c-6b0142882ff2", false, "accountsClerk@maxicycles.co.uk" },
                    { "66b0479d-1690-4f8f-9d9b-2dc47a1d2da3", 0, null, null, null, "624f476a-6862-4d6a-82b6-125dab244c21", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMqSsW5l2F1tCoCHAYMN1weOmo+NxYWHusSCq0uBgl/Ff5+oxnWZf0pxMALvQTNjbA==", null, true, null, "60df7bda-0143-47bb-9a1c-64946c5ef1c0", false, "stockControl@maxicycles.co.uk" },
                    { "bcde1887-a699-4547-afef-b9299119c0b1", 0, null, null, null, "fc14cafa-16ef-4568-a482-8aca08f911c2", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAECmsg0jOEkPXjnLOHux++B3FlWwd1JMTqv6O0kB1uAScUHlWlN+5NjdBSYxhwOFujQ==", null, true, null, "b627d6d5-ccfc-474e-8108-407303d954e7", false, "customer@example.co.uk" },
                    { "fe652daf-b222-44a8-94f2-592de99cfc67", 0, null, null, null, "4328439c-a187-40b3-a858-e4d8b38a6d7b", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECWu/xl3GZNAQQVckvpb2jXn4OgubWsSjktZSJapHq5+bdbhfZSZW6tCgnanvIJZ2w==", null, true, null, "097b8883-239c-4eac-a439-aaaca1819c8c", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1ebdb0d9-6d8f-4f4b-9719-2e5f3c335ab3", "13a06023-3b8d-4676-a16a-5a28b7a4a87e" },
                    { "11597b69-e2f7-4c3d-a8d7-acefa4606491", "3e6eaae2-0740-49ae-b6c9-4cb389d49444" },
                    { "a1b67cbd-69ae-4bad-b3e1-faeae94e83d4", "63af435c-2ea4-4503-9849-ed584fb39fce" },
                    { "dbc25ab1-5047-438a-b60a-a7cca7b407e0", "66b0479d-1690-4f8f-9d9b-2dc47a1d2da3" },
                    { "8f4dec19-9aec-428a-9481-27c8652bd6a8", "bcde1887-a699-4547-afef-b9299119c0b1" },
                    { "167d6a9a-bfc8-47af-9d1f-a2595daf3e7b", "fe652daf-b222-44a8-94f2-592de99cfc67" }
                });
        }
    }
}
