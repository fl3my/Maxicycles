using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ImagePath",
                table: "Product");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12dc1573-cf5b-4a02-8883-91426b17d6d4", null, "Manager", "MANAGER" },
                    { "919c399a-c717-41be-9965-1a77c56de707", null, "Technician", "TECHNICIAN" },
                    { "aa723057-7543-44ef-836d-e5379ee7a4e6", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", null, "MediaManager", "MEDIAMANAGER" },
                    { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", null, "StockControl", "STOCKCONTROL" },
                    { "f41a7f03-9749-415e-8aa6-6a641ac7381e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46e17124-4f7e-4a33-95a1-7531a1a894b8", 0, null, null, null, "949dfa84-f2d5-4349-bb17-cc618c86089d", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECz0ayr6fzt8PM3EscodPnCnA2dkvpxHd4L+9YdC3yuznvyEqejMwS3+6N3DCA4SBg==", null, true, null, "dac691fb-1148-4a10-a636-908cbc8506d8", false, "technician@maxicycles.co.uk" },
                    { "76addc0c-9d5f-40ee-8cc2-694455bda64d", 0, null, null, null, "0ef87bb2-3391-462e-99f4-c597f1be58a4", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEHhZAuYviDMKydopvQXq4mHC20M4/eCKyCu5zF5Z8t28RagA+LwemzhbeonroCbutg==", null, true, null, "8bf471ac-a54d-4ef7-acab-2b5647ade966", false, "customer@example.co.uk" },
                    { "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17", 0, null, null, null, "79dcbf6e-2c82-4244-b9d6-41dd6bae4912", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELZ/7/IK1g24dHtnpvgBgMVlscRDCJcs098KD5k7tw0o7WXdpn5Yk6B/pz94vMWEyA==", null, true, null, "c95fcfdf-765b-4f33-b044-c7e13fa472ff", false, "stockControl@maxicycles.co.uk" },
                    { "a5c08205-5bfe-4f97-a23f-7caeca012967", 0, null, null, null, "577aa62a-76a9-4a28-8fef-64cce3dcb1e2", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKwkItv4Db4JhWz1n45CLnA4BS/sBvwHTyUCwFWdJ+KtMel3gRpZRLN5tx4U3VZnng==", null, true, null, "2c7192e1-2066-4cbb-8d20-f4bfed6aa62e", false, "accountsClerk@maxicycles.co.uk" },
                    { "b74fd7c2-840b-4e42-83d2-f99270b2d9a5", 0, null, null, null, "9915899c-3db5-4556-b514-fe2066a90fb4", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEG+UHMBbz86kMzxHR06RVj+wxFbB6Wie1w7dQWyWwbeCRGccGoqavArB7J0/KKgEJg==", null, true, null, "91cda7b8-1722-48ea-a1a9-ad61762921ca", false, "mediaManager@maxicycles.co.uk" },
                    { "e9df56c5-d794-4e4e-8122-8fda2d2c1270", 0, null, null, null, "4f891fc1-066b-401f-a09d-977e16d06c20", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMpD0fX9bH2zvKEjg0vBRigiB0+1Fev7QKT1zqfmWrdDqN5Hs88KgVts4o/C+kuK5Q==", null, true, null, "b64410b6-f790-4efe-b322-5db957908d3d", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "919c399a-c717-41be-9965-1a77c56de707", "46e17124-4f7e-4a33-95a1-7531a1a894b8" },
                    { "f41a7f03-9749-415e-8aa6-6a641ac7381e", "76addc0c-9d5f-40ee-8cc2-694455bda64d" },
                    { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17" },
                    { "aa723057-7543-44ef-836d-e5379ee7a4e6", "a5c08205-5bfe-4f97-a23f-7caeca012967" },
                    { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", "b74fd7c2-840b-4e42-83d2-f99270b2d9a5" },
                    { "12dc1573-cf5b-4a02-8883-91426b17d6d4", "e9df56c5-d794-4e4e-8122-8fda2d2c1270" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "919c399a-c717-41be-9965-1a77c56de707", "46e17124-4f7e-4a33-95a1-7531a1a894b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f41a7f03-9749-415e-8aa6-6a641ac7381e", "76addc0c-9d5f-40ee-8cc2-694455bda64d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa723057-7543-44ef-836d-e5379ee7a4e6", "a5c08205-5bfe-4f97-a23f-7caeca012967" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", "b74fd7c2-840b-4e42-83d2-f99270b2d9a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12dc1573-cf5b-4a02-8883-91426b17d6d4", "e9df56c5-d794-4e4e-8122-8fda2d2c1270" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12dc1573-cf5b-4a02-8883-91426b17d6d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "919c399a-c717-41be-9965-1a77c56de707");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa723057-7543-44ef-836d-e5379ee7a4e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f41a7f03-9749-415e-8aa6-6a641ac7381e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46e17124-4f7e-4a33-95a1-7531a1a894b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76addc0c-9d5f-40ee-8cc2-694455bda64d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5c08205-5bfe-4f97-a23f-7caeca012967");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74fd7c2-840b-4e42-83d2-f99270b2d9a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9df56c5-d794-4e4e-8122-8fda2d2c1270");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Product",
                type: "text",
                nullable: true);

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
    }
}
