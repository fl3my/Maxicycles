using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoveTotalPriceToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "838eafaf-019b-44ca-a386-acfca55de142", "14ac25a6-7771-4284-9acb-1c5d72369674" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7a3af63-7fa2-421d-88ab-5e7d603599a5", "1ea1452d-7d9c-4b5a-9853-90713d6486ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75e8f28e-b7aa-48b5-8d41-5329c613ea4b", "3dd92b8f-0050-4804-9890-1476a0383258" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016", "630981b0-5704-4e61-a7ed-e4bbdbb87509" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a26009ae-cbd6-409b-b0b7-6ac8452b4702", "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc800078-c380-49ec-ae46-2138300b2a28", "f652e8b0-eb90-4f09-b57e-00d6b80e1cab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75e8f28e-b7aa-48b5-8d41-5329c613ea4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "838eafaf-019b-44ca-a386-acfca55de142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26009ae-cbd6-409b-b0b7-6ac8452b4702");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7a3af63-7fa2-421d-88ab-5e7d603599a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc800078-c380-49ec-ae46-2138300b2a28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14ac25a6-7771-4284-9acb-1c5d72369674");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ea1452d-7d9c-4b5a-9853-90713d6486ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dd92b8f-0050-4804-9890-1476a0383258");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "630981b0-5704-4e61-a7ed-e4bbdbb87509");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f652e8b0-eb90-4f09-b57e-00d6b80e1cab");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Payment");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5369f3a8-aa3a-4e0d-8aec-119273fa72a6", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "570ad99a-a5db-41e1-9539-1dff3772d296", null, "MediaManager", "MEDIAMANAGER" },
                    { "7969077e-8a97-44b0-9cf3-f85a3ce929c2", null, "StockControl", "STOCKCONTROL" },
                    { "982dffe2-d5ef-46bb-8e93-1ed61b672b63", null, "Customer", "CUSTOMER" },
                    { "a5d8126a-4c86-4e12-a26e-b00c3668dd62", null, "Manager", "MANAGER" },
                    { "e69dd29a-ab21-42f2-8802-4d290158ef35", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11e8dc60-5a1c-4d75-b5c1-1d4751c48324", 0, null, null, null, "5509a073-6e01-495b-a73e-232078f907d0", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKmzQ38PgFUOWaDb9pbT27hXqtwtwojk0MBPECn964mu4Ti+n4bIXM8CFsothbmZoA==", null, true, null, "b5cd05ea-550b-4cdb-b91c-7e6b221245f5", false, "accountsClerk@maxicycles.co.uk" },
                    { "32166b04-ad96-4df9-8e81-92fdaa4835be", 0, null, null, null, "24e56528-8721-46da-96bc-e080a5b82fbb", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEAw4FJuhDuH6X8kp4mQSOs8fOE8LsoULafa9yCwpuxXffKLTAQ2S3W1TczC8iKWiRg==", null, true, null, "e3c1be7f-0b62-4e9c-a756-bc36bdb8acee", false, "customer@example.co.uk" },
                    { "454fb852-01f9-43ba-b75e-ecd1e2a6bc79", 0, null, null, null, "69ce5a67-ca09-4d7c-8735-755d2d15d4b9", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMWyl4JZhuhbG/8/LIRFDkIp7ztiIErCSD/Hfap/pTpEF5i4ehv8AJhmIirZLOEBdg==", null, true, null, "f273dbbf-e6c0-4e17-8cbf-9dc8c82241c9", false, "manager@maxicycles.co.uk" },
                    { "a8fb9901-0d1b-4b5c-9927-242ecba36586", 0, null, null, null, "a491560c-9cdb-4efe-94b4-701b0bd346d4", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDiFLp1HFoEwguFQheIEq4vBM5DgNpPsqhIbx5872j7shxZqqPxdPjItV4wFUk1bEw==", null, true, null, "ddf91faa-954a-4f14-b68b-a41c6de471bd", false, "technician@maxicycles.co.uk" },
                    { "c99d6f06-5faf-44b5-8e14-07a3f8eb6f64", 0, null, null, null, "b7bdf80e-cd33-42a3-93fd-1f6c6cf12b6b", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPJeHWZXy2e3JOYMuYyj/95rpSpgNzV+G6UapeJTZigii2qGOsvjx/3wH3FiMR1QjA==", null, true, null, "1f7a59b8-78cc-4018-a5b1-82c99d435070", false, "stockControl@maxicycles.co.uk" },
                    { "d7012d10-6ae4-478e-9b8e-67adb292b201", 0, null, null, null, "850f938d-9943-436b-9b4c-fcc8a6b36623", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFLaNxFud3afyrg76cYiPkq19YjtWUpkuD6u7ORpBztxeCZcai3oaT+ZQmtKR9La5w==", null, true, null, "b4382c7f-74b6-44d3-bcf8-2149968c0fd8", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5369f3a8-aa3a-4e0d-8aec-119273fa72a6", "11e8dc60-5a1c-4d75-b5c1-1d4751c48324" },
                    { "982dffe2-d5ef-46bb-8e93-1ed61b672b63", "32166b04-ad96-4df9-8e81-92fdaa4835be" },
                    { "a5d8126a-4c86-4e12-a26e-b00c3668dd62", "454fb852-01f9-43ba-b75e-ecd1e2a6bc79" },
                    { "e69dd29a-ab21-42f2-8802-4d290158ef35", "a8fb9901-0d1b-4b5c-9927-242ecba36586" },
                    { "7969077e-8a97-44b0-9cf3-f85a3ce929c2", "c99d6f06-5faf-44b5-8e14-07a3f8eb6f64" },
                    { "570ad99a-a5db-41e1-9539-1dff3772d296", "d7012d10-6ae4-478e-9b8e-67adb292b201" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5369f3a8-aa3a-4e0d-8aec-119273fa72a6", "11e8dc60-5a1c-4d75-b5c1-1d4751c48324" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "982dffe2-d5ef-46bb-8e93-1ed61b672b63", "32166b04-ad96-4df9-8e81-92fdaa4835be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a5d8126a-4c86-4e12-a26e-b00c3668dd62", "454fb852-01f9-43ba-b75e-ecd1e2a6bc79" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e69dd29a-ab21-42f2-8802-4d290158ef35", "a8fb9901-0d1b-4b5c-9927-242ecba36586" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7969077e-8a97-44b0-9cf3-f85a3ce929c2", "c99d6f06-5faf-44b5-8e14-07a3f8eb6f64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "570ad99a-a5db-41e1-9539-1dff3772d296", "d7012d10-6ae4-478e-9b8e-67adb292b201" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5369f3a8-aa3a-4e0d-8aec-119273fa72a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "570ad99a-a5db-41e1-9539-1dff3772d296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7969077e-8a97-44b0-9cf3-f85a3ce929c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "982dffe2-d5ef-46bb-8e93-1ed61b672b63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d8126a-4c86-4e12-a26e-b00c3668dd62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e69dd29a-ab21-42f2-8802-4d290158ef35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e8dc60-5a1c-4d75-b5c1-1d4751c48324");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32166b04-ad96-4df9-8e81-92fdaa4835be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "454fb852-01f9-43ba-b75e-ecd1e2a6bc79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8fb9901-0d1b-4b5c-9927-242ecba36586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c99d6f06-5faf-44b5-8e14-07a3f8eb6f64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7012d10-6ae4-478e-9b8e-67adb292b201");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Payment",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75e8f28e-b7aa-48b5-8d41-5329c613ea4b", null, "Customer", "CUSTOMER" },
                    { "838eafaf-019b-44ca-a386-acfca55de142", null, "Manager", "MANAGER" },
                    { "a26009ae-cbd6-409b-b0b7-6ac8452b4702", null, "StockControl", "STOCKCONTROL" },
                    { "b7a3af63-7fa2-421d-88ab-5e7d603599a5", null, "Technician", "TECHNICIAN" },
                    { "bc800078-c380-49ec-ae46-2138300b2a28", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14ac25a6-7771-4284-9acb-1c5d72369674", 0, null, null, null, "35fbc778-da54-41e3-9cb5-d091f49f273d", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHJ6Svx7vVdNZYd+erir97ZLGReMmZhyRGynxYSxYsO+OCEXzWcs498+47A/UyrzXA==", null, true, null, "fe5815e8-bab9-4d3a-86af-ff657511ada2", false, "manager@maxicycles.co.uk" },
                    { "1ea1452d-7d9c-4b5a-9853-90713d6486ca", 0, null, null, null, "9e3f1753-3455-4518-9afd-0a12309ff6bc", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJwpTV5JPPacKPGnvk25eIsAUEjkKTONxyrihmcl05fx+ygUBLmw6rcNHlvFzW/oNw==", null, true, null, "0d74bc3b-2b28-4e2d-a7eb-b947c064dffd", false, "technician@maxicycles.co.uk" },
                    { "3dd92b8f-0050-4804-9890-1476a0383258", 0, null, null, null, "b20e6381-7d96-4d39-990b-fb01bd15e481", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEAz0Dmtgjw4KM5J2Fg38El/mG1uaFHCkyfvQ2Z5hrd0JkoM5ob9tAFAtYCmQ1/3kjg==", null, true, null, "f91e618a-2ed3-4f49-95c9-a9c116610b51", false, "customer@example.co.uk" },
                    { "630981b0-5704-4e61-a7ed-e4bbdbb87509", 0, null, null, null, "9e39e2ad-77f5-408a-a3a8-50f72c734619", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELNAIqS0p0R29RlacUGApk/GoRYF7fi97vZzc7MZLVLoqd+ON9Z8QnnyMSn+BV55Cw==", null, true, null, "8c54b059-e82b-4209-b3a0-008c44221779", false, "mediaManager@maxicycles.co.uk" },
                    { "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723", 0, null, null, null, "50d76ab5-f990-4027-a602-2f2572fc0c31", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEG7Tjbyi1txV5NELm1/gY+0XzFZ3brWKOXmshZpUq1FNwMtZOMiGy1gUXz30nDodqA==", null, true, null, "1f8c2896-33e4-48ea-866a-90b218bc1cdd", false, "stockControl@maxicycles.co.uk" },
                    { "f652e8b0-eb90-4f09-b57e-00d6b80e1cab", 0, null, null, null, "e0bc9319-307d-4021-9396-4c9aba7f9532", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEH0lIj5am5JCz7Y0/UTl8VnAIA4W57OVnJbJ+LGk9mUVJiComPHosM22sTHTk3FusQ==", null, true, null, "d183d3e1-ca11-4692-ab33-16bc519f6c23", false, "accountsClerk@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "838eafaf-019b-44ca-a386-acfca55de142", "14ac25a6-7771-4284-9acb-1c5d72369674" },
                    { "b7a3af63-7fa2-421d-88ab-5e7d603599a5", "1ea1452d-7d9c-4b5a-9853-90713d6486ca" },
                    { "75e8f28e-b7aa-48b5-8d41-5329c613ea4b", "3dd92b8f-0050-4804-9890-1476a0383258" },
                    { "c2a01f94-96bb-47f0-8e9f-16cd8b4b1016", "630981b0-5704-4e61-a7ed-e4bbdbb87509" },
                    { "a26009ae-cbd6-409b-b0b7-6ac8452b4702", "df1baf0b-daf3-4d54-bd7c-1f32d4d7d723" },
                    { "bc800078-c380-49ec-ae46-2138300b2a28", "f652e8b0-eb90-4f09-b57e-00d6b80e1cab" }
                });
        }
    }
}
