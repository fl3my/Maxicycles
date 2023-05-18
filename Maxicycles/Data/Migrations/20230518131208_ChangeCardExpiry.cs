using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeCardExpiry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9e9e007-7360-4cd7-a587-ea2266e513df", "28ad6702-ef66-46d2-a3c7-21cbec07d142" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2dd289e1-a941-432e-8221-9f8d06baf6e2", "60c1e0c5-0b51-4543-94aa-b30f0b3ed3f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a02ed144-6718-4279-afdc-2273749dae35", "76ba2546-8d17-40e6-a71c-172cf7969ff7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4daa4c5d-6af3-42b8-8fbd-4f733c0a228b", "84f6e733-fa6f-468d-9232-0d447073612a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19bc2396-05d7-4327-9427-3103591a6e3e", "d0c6d6f1-035b-4047-8756-4393ddf2346e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cca9af05-477c-4f5d-960d-7dbecb3440c4", "d96bc5a7-eab1-4594-9222-a60933f100b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19bc2396-05d7-4327-9427-3103591a6e3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dd289e1-a941-432e-8221-9f8d06baf6e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4daa4c5d-6af3-42b8-8fbd-4f733c0a228b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02ed144-6718-4279-afdc-2273749dae35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9e9e007-7360-4cd7-a587-ea2266e513df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cca9af05-477c-4f5d-960d-7dbecb3440c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28ad6702-ef66-46d2-a3c7-21cbec07d142");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60c1e0c5-0b51-4543-94aa-b30f0b3ed3f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76ba2546-8d17-40e6-a71c-172cf7969ff7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f6e733-fa6f-468d-9232-0d447073612a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0c6d6f1-035b-4047-8756-4393ddf2346e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d96bc5a7-eab1-4594-9222-a60933f100b9");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Payment");

            migrationBuilder.AlterColumn<string>(
                name: "Cvv",
                table: "Payment",
                type: "character varying(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpiryMonth",
                table: "Payment",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpiryYear",
                table: "Payment",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ExpiryMonth",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ExpiryYear",
                table: "Payment");

            migrationBuilder.AlterColumn<string>(
                name: "Cvv",
                table: "Payment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Payment",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19bc2396-05d7-4327-9427-3103591a6e3e", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "2dd289e1-a941-432e-8221-9f8d06baf6e2", null, "MediaManager", "MEDIAMANAGER" },
                    { "4daa4c5d-6af3-42b8-8fbd-4f733c0a228b", null, "Customer", "CUSTOMER" },
                    { "a02ed144-6718-4279-afdc-2273749dae35", null, "StockControl", "STOCKCONTROL" },
                    { "c9e9e007-7360-4cd7-a587-ea2266e513df", null, "Manager", "MANAGER" },
                    { "cca9af05-477c-4f5d-960d-7dbecb3440c4", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28ad6702-ef66-46d2-a3c7-21cbec07d142", 0, null, null, null, "b2bc9856-7470-48da-9a4b-5562e144d1d7", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEF0TW4I/3tevmV605eiKrRFfMFAJUhQfjbKYk1HSjYgJcwUMewiWYTqIPnakyZwqzA==", null, true, null, "ecbb9805-fa6b-4e8e-9dca-c2ac58fca20f", false, "manager@maxicycles.co.uk" },
                    { "60c1e0c5-0b51-4543-94aa-b30f0b3ed3f8", 0, null, null, null, "782a93b7-6c9d-4db8-b0af-a7b04b8d3870", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEA2Pwrh26lv83ZwADcb9x30q5kckP6rD09+YmP0c/LJ9hrpUFSMJ8HLgCqmeB9lvGw==", null, true, null, "d60c4489-7853-4fa9-a631-774e3debf9a2", false, "mediaManager@maxicycles.co.uk" },
                    { "76ba2546-8d17-40e6-a71c-172cf7969ff7", 0, null, null, null, "ac94f7b7-fed3-4581-84a7-0ddde26cea43", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHsm1dBUuqo69IBIWC0i0OQeFjueMDRmlFHO6bFo5kg1bLXic+1QCSAXgLNGniTT4w==", null, true, null, "d53e8d3a-e4fe-46a0-b2ed-5a1a4f34c94b", false, "stockControl@maxicycles.co.uk" },
                    { "84f6e733-fa6f-468d-9232-0d447073612a", 0, null, null, null, "87b54002-e0ea-48cf-acff-d830f2399db0", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEPRjojeGvlzK4/OgVdTlcoajfRgQB1SigUrpSzlGKZVWVXhCIPNeHrQ39fk3i+9BSA==", null, true, null, "cf69cba9-690d-483c-b3fa-5b7dc2642876", false, "customer@example.co.uk" },
                    { "d0c6d6f1-035b-4047-8756-4393ddf2346e", 0, null, null, null, "0917beb5-d0ec-4735-ae27-6fd838036f66", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEImXtoAUL+2KFfPkmUFeFsZtPIAhp+F4CszsKOzsSn+fyJGzHVUr1amEefFoWa4odw==", null, true, null, "4d3f69f1-3e88-4b03-8f78-8dfeae4e73ed", false, "accountsClerk@maxicycles.co.uk" },
                    { "d96bc5a7-eab1-4594-9222-a60933f100b9", 0, null, null, null, "550417e2-8ed8-4eaf-8952-3031852d6a21", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIZOqUIiDjbSl40RzeJVKUHH0JCijMJY6bdEcsUMlXywIsILZ0mwrzzvqfAWnhkH+w==", null, true, null, "b79ba681-c789-4a1b-8eae-7daaf9f6bafc", false, "technician@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c9e9e007-7360-4cd7-a587-ea2266e513df", "28ad6702-ef66-46d2-a3c7-21cbec07d142" },
                    { "2dd289e1-a941-432e-8221-9f8d06baf6e2", "60c1e0c5-0b51-4543-94aa-b30f0b3ed3f8" },
                    { "a02ed144-6718-4279-afdc-2273749dae35", "76ba2546-8d17-40e6-a71c-172cf7969ff7" },
                    { "4daa4c5d-6af3-42b8-8fbd-4f733c0a228b", "84f6e733-fa6f-468d-9232-0d447073612a" },
                    { "19bc2396-05d7-4327-9427-3103591a6e3e", "d0c6d6f1-035b-4047-8756-4393ddf2346e" },
                    { "cca9af05-477c-4f5d-960d-7dbecb3440c4", "d96bc5a7-eab1-4594-9222-a60933f100b9" }
                });
        }
    }
}
