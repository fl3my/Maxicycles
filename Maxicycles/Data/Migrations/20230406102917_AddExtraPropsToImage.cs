using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddExtraPropsToImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64", "1d90e1dc-3619-4938-ba37-4ecbe054bf90" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d1f3fa0-c484-4da4-9284-55256eb80ce0", "3c51fe3e-0eba-4b67-99d3-571198ae6f7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c", "801fd803-b4c9-4363-9ee2-a6e412766a03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08705297-472b-4d99-bc95-03acfb58eb20", "b030a19d-6df6-4d8f-b163-651a6d7009e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c3f1915-4242-4da9-9d04-a44985c9df4b", "c997fd07-20de-4c95-b5e2-cbb6e60d4caf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ff65788-989b-4e79-b635-d65e64b3ec1a", "d4045d95-de15-41af-a46a-7a4ec1eabe8a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08705297-472b-4d99-bc95-03acfb58eb20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d1f3fa0-c484-4da4-9284-55256eb80ce0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ff65788-989b-4e79-b635-d65e64b3ec1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3f1915-4242-4da9-9d04-a44985c9df4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d90e1dc-3619-4938-ba37-4ecbe054bf90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c51fe3e-0eba-4b67-99d3-571198ae6f7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "801fd803-b4c9-4363-9ee2-a6e412766a03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b030a19d-6df6-4d8f-b163-651a6d7009e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c997fd07-20de-4c95-b5e2-cbb6e60d4caf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4045d95-de15-41af-a46a-7a4ec1eabe8a");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Image",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltText",
                table: "Image",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadedAt",
                table: "Image",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10ce1258-4caa-4f60-9e38-85e2caf23a94", null, "Manager", "MANAGER" },
                    { "1296f008-90f2-4787-ab04-99fe8b8686d5", null, "MediaManager", "MEDIAMANAGER" },
                    { "41a63bec-c878-48ea-b066-0883e9b97282", null, "Customer", "CUSTOMER" },
                    { "b187a4d5-dd38-4b93-a360-0f747fd213e1", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24", null, "StockControl", "STOCKCONTROL" },
                    { "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02160236-144e-442e-b314-ede77517bb74", 0, null, null, null, "6d605e65-81ac-40d5-a63a-e5b4481eca0b", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEr/u34UYZI2K63Ln2zR1ajI+gH7SGsOxnlM7MOb1vdcJbyYUlZtIEppesbDoDUQJA==", null, true, null, "5820b5d4-f3e2-4ccd-8513-a9d439986197", false, "stockControl@maxicycles.co.uk" },
                    { "0e8817da-a6e7-42b2-8262-29ca3c18ce4b", 0, null, null, null, "e7bf6a7e-21b1-4261-8720-bdc610ff5917", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEAEuzIWyXfh1UY0u2UB1QeBvzc5yCv5erfBNROSaxPwygyTJ+d0tIPgqUoCP4MxJ4w==", null, true, null, "f5dd2e92-a6c3-41c6-a36e-97641c1cdfed", false, "manager@maxicycles.co.uk" },
                    { "36200392-931d-4557-bed5-7afd964746ab", 0, null, null, null, "ef6ee20e-17ac-45d7-8b02-86aac8e95e66", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELGWXkhd+sLGgHSWQ/wU5SE6UoQ11ITwcsDN0dDqytGlHHTNYuedyhovaB6n6btKfw==", null, true, null, "9bc2705a-77c7-4ac9-b305-65b704c90ed9", false, "accountsClerk@maxicycles.co.uk" },
                    { "72d34135-c719-4a1d-8165-541d20e33f5b", 0, null, null, null, "a93a0b37-ff8a-48da-902f-515d82bf5de1", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEACR+J2g0/q5JMQhxMg6yLauyZ2ZC9iLK7O6iY7UNaUM3WjCDuj9sVvMK90hyLL/0g==", null, true, null, "a3072e4e-e05f-42bf-b602-ccb036c8a6e8", false, "technician@maxicycles.co.uk" },
                    { "e8ba216a-403b-4784-a8f5-2b80a3282ca4", 0, null, null, null, "500d4fb8-94b9-4790-8b8e-d5c8448f7eee", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEsRdFdT9TqFhwBcLvPG4pJfbADd+CAOgzhk0Aps3pS2DNvZyVWbbudMT0bCzLnXcg==", null, true, null, "74364f02-ef30-43b9-88d6-fffac0bc54b2", false, "mediaManager@maxicycles.co.uk" },
                    { "fedc7aca-315e-4ecc-8160-9ff5fd74d521", 0, null, null, null, "043fe3f5-65ce-40fd-9b10-72d2652b9ae1", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEKRl2eJ3YuvdSMKAZD9f3D6lQ7Nhi09b4PHNyv5g8vgkzUyOCubmCUYQD9S2M/X2ig==", null, true, null, "fc176d87-fa50-4082-9e8c-ffbcf1b355df", false, "customer@example.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24", "02160236-144e-442e-b314-ede77517bb74" },
                    { "10ce1258-4caa-4f60-9e38-85e2caf23a94", "0e8817da-a6e7-42b2-8262-29ca3c18ce4b" },
                    { "b187a4d5-dd38-4b93-a360-0f747fd213e1", "36200392-931d-4557-bed5-7afd964746ab" },
                    { "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6", "72d34135-c719-4a1d-8165-541d20e33f5b" },
                    { "1296f008-90f2-4787-ab04-99fe8b8686d5", "e8ba216a-403b-4784-a8f5-2b80a3282ca4" },
                    { "41a63bec-c878-48ea-b066-0883e9b97282", "fedc7aca-315e-4ecc-8160-9ff5fd74d521" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24", "02160236-144e-442e-b314-ede77517bb74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10ce1258-4caa-4f60-9e38-85e2caf23a94", "0e8817da-a6e7-42b2-8262-29ca3c18ce4b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b187a4d5-dd38-4b93-a360-0f747fd213e1", "36200392-931d-4557-bed5-7afd964746ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6", "72d34135-c719-4a1d-8165-541d20e33f5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1296f008-90f2-4787-ab04-99fe8b8686d5", "e8ba216a-403b-4784-a8f5-2b80a3282ca4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41a63bec-c878-48ea-b066-0883e9b97282", "fedc7aca-315e-4ecc-8160-9ff5fd74d521" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10ce1258-4caa-4f60-9e38-85e2caf23a94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1296f008-90f2-4787-ab04-99fe8b8686d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41a63bec-c878-48ea-b066-0883e9b97282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b187a4d5-dd38-4b93-a360-0f747fd213e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd6b2b5f-7aac-4075-a76f-b1a5425b3f24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6776ea-0ea6-4dc7-a3f5-a9f97b313ca6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02160236-144e-442e-b314-ede77517bb74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e8817da-a6e7-42b2-8262-29ca3c18ce4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36200392-931d-4557-bed5-7afd964746ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72d34135-c719-4a1d-8165-541d20e33f5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8ba216a-403b-4784-a8f5-2b80a3282ca4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedc7aca-315e-4ecc-8160-9ff5fd74d521");

            migrationBuilder.DropColumn(
                name: "AltText",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "UploadedAt",
                table: "Image");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Image",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08705297-472b-4d99-bc95-03acfb58eb20", null, "Manager", "MANAGER" },
                    { "0d1f3fa0-c484-4da4-9284-55256eb80ce0", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "2ff65788-989b-4e79-b635-d65e64b3ec1a", null, "Technician", "TECHNICIAN" },
                    { "3c3f1915-4242-4da9-9d04-a44985c9df4b", null, "MediaManager", "MEDIAMANAGER" },
                    { "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c", null, "StockControl", "STOCKCONTROL" },
                    { "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d90e1dc-3619-4938-ba37-4ecbe054bf90", 0, null, null, null, "6716f349-81b7-45b6-870d-ab17c3d0c9d4", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAED4aLPguCBA0AYLH3r36Kl9gfHa8JAIOh4hw7uqfCjL8CaVcBsFQi5Knea0UjA8wEg==", null, true, null, "6b7c502d-899a-40ae-bd9e-853af671bd52", false, "customer@example.co.uk" },
                    { "3c51fe3e-0eba-4b67-99d3-571198ae6f7c", 0, null, null, null, "e1f9a8bc-51b2-41f8-83e1-a85d484553fd", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDUCZ3LoKEC9TyZmvIkiqk/HAQF9P9gbjP29loDoJVGaXBWhKRiGAGVbS3ZKpY02Qw==", null, true, null, "40860fb3-e0eb-45c3-89bd-b5e0a13da461", false, "accountsClerk@maxicycles.co.uk" },
                    { "801fd803-b4c9-4363-9ee2-a6e412766a03", 0, null, null, null, "6d9dd256-ff88-45f5-a152-a30a98222aac", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEK4G7FMU+j4NwDic2YGDCiL2Sef/6V1xljhZjNxyZrHwHU7BNiwGquOn3rxDtC0CwQ==", null, true, null, "535dbd53-f442-4b48-9acc-6381684fbb98", false, "stockControl@maxicycles.co.uk" },
                    { "b030a19d-6df6-4d8f-b163-651a6d7009e5", 0, null, null, null, "9689c6a1-363c-4276-bad0-634341c31adc", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEESRGoltjB36IbMWpCG/o3Q8CJkyAh8IOMAifJ6sUjWqA/ToCmVTLhPM8lbKX+roXA==", null, true, null, "1b7de680-16bd-4544-9d62-65c6b69e73e2", false, "manager@maxicycles.co.uk" },
                    { "c997fd07-20de-4c95-b5e2-cbb6e60d4caf", 0, null, null, null, "0039db32-be3c-41f9-a175-19d0d86784be", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDgmXf/xpGNUn+X7QCJQInbXJS/ce9sqT/gO2Mdr66dgX7DlaWTJE5G7sTrGy6gtTw==", null, true, null, "2ed5c784-a2b2-4900-b3fa-4797f6e04133", false, "mediaManager@maxicycles.co.uk" },
                    { "d4045d95-de15-41af-a46a-7a4ec1eabe8a", 0, null, null, null, "fe653818-a291-42f2-a016-c01b5ea9ca34", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHhq9PX28erWNeKPgs287kxxHK8Hq6SESgf4QYbg4BXOAmG0pEC6ljWZzj71kXHZXA==", null, true, null, "10c02244-5794-44a3-955c-9154846c9147", false, "technician@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ac64637f-9f3c-4a6d-8a5b-0b7d28301f64", "1d90e1dc-3619-4938-ba37-4ecbe054bf90" },
                    { "0d1f3fa0-c484-4da4-9284-55256eb80ce0", "3c51fe3e-0eba-4b67-99d3-571198ae6f7c" },
                    { "3eb4ec0e-0c5d-4e0f-8e2f-626ba8c4663c", "801fd803-b4c9-4363-9ee2-a6e412766a03" },
                    { "08705297-472b-4d99-bc95-03acfb58eb20", "b030a19d-6df6-4d8f-b163-651a6d7009e5" },
                    { "3c3f1915-4242-4da9-9d04-a44985c9df4b", "c997fd07-20de-4c95-b5e2-cbb6e60d4caf" },
                    { "2ff65788-989b-4e79-b635-d65e64b3ec1a", "d4045d95-de15-41af-a46a-7a4ec1eabe8a" }
                });
        }
    }
}
