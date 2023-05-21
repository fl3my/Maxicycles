using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", "006c7039-56f4-4f95-a4b2-9fab401a9569" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", "3e2f0531-ef66-43ba-b797-932e9bdf551c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e797548d-b70b-4a76-9fe6-d174bfeea83a", "40cc3f7f-263c-40fe-a847-3436488d3bf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "038e683b-bc9d-496e-9639-dec2849dc060", "be6ec362-765f-423e-88b5-e29af14ed4f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2ab606c-14a4-4090-9b31-d5314a83edd5", "c2f5a8ee-93ec-47b2-bb00-270d455878a8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038e683b-bc9d-496e-9639-dec2849dc060");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ddb9e05-87a7-4f4a-a267-be54edb626d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1939d9-c391-4fdb-a204-0069d6b7dcb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d6bf3f1-32a6-42f7-a47a-d04469a28673");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2ab606c-14a4-4090-9b31-d5314a83edd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e797548d-b70b-4a76-9fe6-d174bfeea83a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "006c7039-56f4-4f95-a4b2-9fab401a9569");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e2f0531-ef66-43ba-b797-932e9bdf551c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40cc3f7f-263c-40fe-a847-3436488d3bf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be6ec362-765f-423e-88b5-e29af14ed4f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f5a8ee-93ec-47b2-bb00-270d455878a8");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "038e683b-bc9d-496e-9639-dec2849dc060", null, "Manager", "MANAGER" },
                    { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", null, "Customer", "CUSTOMER" },
                    { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", null, "StockControl", "STOCKCONTROL" },
                    { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", null, "MediaManager", "MEDIAMANAGER" },
                    { "c2ab606c-14a4-4090-9b31-d5314a83edd5", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "e797548d-b70b-4a76-9fe6-d174bfeea83a", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "006c7039-56f4-4f95-a4b2-9fab401a9569", 0, null, null, null, "3dc53cbf-28d1-4701-8923-2c7deb26f6fe", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEBR5YmeCftbWS1f569Ud90D1p7ti8n1c7+9clen8JdxrVna9DJ6u/WUZkZp97IODnQ==", null, true, null, "0d64d48f-33cb-447a-8941-2aee74361c43", false, "customer@example.co.uk" },
                    { "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9", 0, null, null, null, "a3325a5c-66ee-428d-8de3-0d4d85b0c582", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDqTy+WctsrPHFVUCIFZEhx2aX0EKiJ4zhF6pDT9R/y8dOmSbcmgPWoHgJOGI2mbKw==", null, true, null, "9744cead-5d78-47c9-b894-ab2da4011137", false, "mediaManager@maxicycles.co.uk" },
                    { "3e2f0531-ef66-43ba-b797-932e9bdf551c", 0, null, null, null, "b11298e0-183e-48d9-a754-51946b01bacb", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDZ5ClKe25ZWc6QO4pioB0mVlXAbemiMp/l/vuhHQLQhPV++3DlztLeWIUeUmUslBw==", null, true, null, "2a405f82-dc73-473f-a02a-d0d505cbff83", false, "stockControl@maxicycles.co.uk" },
                    { "40cc3f7f-263c-40fe-a847-3436488d3bf6", 0, null, null, null, "e99c3457-b379-446b-9a1a-12c33401fa34", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEAxpxQYmWqCBj0rIdqMGG3Lss1uVxXx6Y0cugvpWKbfTAu+KJZCRvuuLbOVpOR9VEA==", null, true, null, "6ae768e8-3e70-4a77-bf4d-ddba06f48ac6", false, "technician@maxicycles.co.uk" },
                    { "be6ec362-765f-423e-88b5-e29af14ed4f7", 0, null, null, null, "b66f6a46-0efa-4265-9c18-d1994465f841", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEF8LdtRbaZ6UxK2Xwvselhc9TKve+EFzVPnY+Gp7r2HpvfngKFj9+gtpo95r5012pQ==", null, true, null, "3bb4cfd0-c4ab-40bc-a47f-bc846fa392e7", false, "manager@maxicycles.co.uk" },
                    { "c2f5a8ee-93ec-47b2-bb00-270d455878a8", 0, null, null, null, "0c20e964-6491-4fcd-b4fe-e5892b68635f", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJT6BimJmuIHDXzEaTeheLl5M/OHA9RmFXoMsFKTiVHJg6sxZ30Yu9hu/kzRMaGBxg==", null, true, null, "bf2f48cf-301c-4c78-aae5-5bfb682538f3", false, "accountsClerk@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", "006c7039-56f4-4f95-a4b2-9fab401a9569" },
                    { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9" },
                    { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", "3e2f0531-ef66-43ba-b797-932e9bdf551c" },
                    { "e797548d-b70b-4a76-9fe6-d174bfeea83a", "40cc3f7f-263c-40fe-a847-3436488d3bf6" },
                    { "038e683b-bc9d-496e-9639-dec2849dc060", "be6ec362-765f-423e-88b5-e29af14ed4f7" },
                    { "c2ab606c-14a4-4090-9b31-d5314a83edd5", "c2f5a8ee-93ec-47b2-bb00-270d455878a8" }
                });
        }
    }
}
