using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnyDayBoolDelivery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba1c6898-02b9-4150-8f73-74f2662bca12", "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "217b48cb-4f03-42ad-98e2-4f2603caff28", "821b5523-a67b-476c-97d9-dbf5af4c47f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", "832038cc-bc69-4f5d-bb92-b36d3b52b648" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", "b4facbda-1dba-4778-b843-63e91e18abea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", "bf983f96-ed70-4f53-bb70-a9338ae238e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1654387a-e7a6-42ac-83ff-2624be5da03a", "f55618c5-73cf-4187-b04b-68592d22bb90" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1654387a-e7a6-42ac-83ff-2624be5da03a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "217b48cb-4f03-42ad-98e2-4f2603caff28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba1c6898-02b9-4150-8f73-74f2662bca12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9174668-8cd8-4ae7-bf65-c0ffe6228238");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "821b5523-a67b-476c-97d9-dbf5af4c47f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832038cc-bc69-4f5d-bb92-b36d3b52b648");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4facbda-1dba-4778-b843-63e91e18abea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf983f96-ed70-4f53-bb70-a9338ae238e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f55618c5-73cf-4187-b04b-68592d22bb90");

            migrationBuilder.AddColumn<bool>(
                name: "IsDaySelectable",
                table: "DeliveryMethods",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IsDaySelectable",
                table: "DeliveryMethods");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", null, "MediaManager", "MEDIAMANAGER" },
                    { "1654387a-e7a6-42ac-83ff-2624be5da03a", null, "Customer", "CUSTOMER" },
                    { "217b48cb-4f03-42ad-98e2-4f2603caff28", null, "StockControl", "STOCKCONTROL" },
                    { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", null, "Manager", "MANAGER" },
                    { "ba1c6898-02b9-4150-8f73-74f2662bca12", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13", 0, null, null, null, "a4ee9883-a98c-4908-8e50-2c54fda855bb", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEI/smUctNVXqHjgtf0B7NqYfSZjqqqUk5cFUukZzGCpliHWLanPbrwis/H3ZKWIZgA==", null, true, null, "d9148afd-6bb6-4af1-900e-8190e218fc74", false, "accountsClerk@maxicycles.co.uk" },
                    { "821b5523-a67b-476c-97d9-dbf5af4c47f1", 0, null, null, null, "701c9b00-2076-49b4-9436-4c8badfd0b90", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEM/T1uvXG/H7NNV29V1kM4vMo7F4Gq9j+ytIRw2yeH1bKafVgKs15SoicgfJjlTClg==", null, true, null, "6087e6e9-4d3c-4fc8-8a52-e4a57cc26eb2", false, "stockControl@maxicycles.co.uk" },
                    { "832038cc-bc69-4f5d-bb92-b36d3b52b648", 0, null, null, null, "1f1379b5-42ab-43c9-8ade-ca34347f9a26", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHvxwWocejN4DhuJA96adPmvo5EsNccu+QjEctOWfcpo2Bx9R922omEE50szOVjexw==", null, true, null, "2de60e93-0782-43ec-ab7f-960173ee8995", false, "mediaManager@maxicycles.co.uk" },
                    { "b4facbda-1dba-4778-b843-63e91e18abea", 0, null, null, null, "edcf8f00-d969-459e-a257-51ef5465cab1", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAENQWyKaTgXzSkZgbQLuQrx3k8/aSy1izdaV+0VZfs2+ovCOcvih3Fj4E5T/mIXj+Fg==", null, true, null, "55c06d30-f4e9-4416-8d30-7f91d029b27d", false, "manager@maxicycles.co.uk" },
                    { "bf983f96-ed70-4f53-bb70-a9338ae238e5", 0, null, null, null, "9cd218e9-7422-41f6-9f85-3f43286b77cd", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBLPVDDLONtRDEambXYk9ueYWo+4+wRsaxlzvy1qqrbfhGa1KAB/i3xytOsjkeNKYA==", null, true, null, "babbb7fb-0021-4c33-b25d-0d239af94f31", false, "technician@maxicycles.co.uk" },
                    { "f55618c5-73cf-4187-b04b-68592d22bb90", 0, null, null, null, "8497258d-7b5c-402f-8cf9-6a6e90de7d65", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAECZ50ufVVAU1kmatDquh9zivxu/v6+zas7AQ/DVSpMKhlqxYQDGgQFhNNENk+MFDyw==", null, true, null, "7035a32a-b45a-49d8-bcab-a6c2187d0c6b", false, "customer@example.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba1c6898-02b9-4150-8f73-74f2662bca12", "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13" },
                    { "217b48cb-4f03-42ad-98e2-4f2603caff28", "821b5523-a67b-476c-97d9-dbf5af4c47f1" },
                    { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", "832038cc-bc69-4f5d-bb92-b36d3b52b648" },
                    { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", "b4facbda-1dba-4778-b843-63e91e18abea" },
                    { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", "bf983f96-ed70-4f53-bb70-a9338ae238e5" },
                    { "1654387a-e7a6-42ac-83ff-2624be5da03a", "f55618c5-73cf-4187-b04b-68592d22bb90" }
                });
        }
    }
}
