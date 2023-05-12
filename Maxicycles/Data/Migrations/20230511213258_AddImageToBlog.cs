using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aeda6fc2-f31a-479a-bd5b-535c3d2d5a45", "0edda849-c8df-4147-bcd3-9009032b8109" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dcd1f5c-74da-4f8f-9018-92d877be9528", "99d3842d-990c-4a7f-917f-a2f35ae96a55" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73c2f531-429c-4d96-864a-67ff69a0ab4a", "b77a9450-4916-465b-afbe-25276ca354d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a44e2a5f-f9d7-4b15-ab38-393e72caee07", "cb784eae-c626-496d-869f-8686e6355a27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c509c8f-a5c2-4c95-aa1e-dfe978934eca", "f11f8a14-c0b9-4a3a-98e5-252968a63b21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "caff0464-729c-4e66-b15b-c6a26d1805f5", "f18365a7-a77f-45f4-88df-1304e29187a7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dcd1f5c-74da-4f8f-9018-92d877be9528");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73c2f531-429c-4d96-864a-67ff69a0ab4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c509c8f-a5c2-4c95-aa1e-dfe978934eca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a44e2a5f-f9d7-4b15-ab38-393e72caee07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aeda6fc2-f31a-479a-bd5b-535c3d2d5a45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caff0464-729c-4e66-b15b-c6a26d1805f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0edda849-c8df-4147-bcd3-9009032b8109");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3842d-990c-4a7f-917f-a2f35ae96a55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b77a9450-4916-465b-afbe-25276ca354d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb784eae-c626-496d-869f-8686e6355a27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f11f8a14-c0b9-4a3a-98e5-252968a63b21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18365a7-a77f-45f4-88df-1304e29187a7");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Post",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05d7f093-d303-4cc7-aa30-372647f81cd4", null, "MediaManager", "MEDIAMANAGER" },
                    { "0ac3ea3f-c498-468a-9fb6-1740fc22922a", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "97a2f403-be15-4a35-9f5d-e3f071289e97", null, "Manager", "MANAGER" },
                    { "bf929e36-b71c-45f5-9ccb-8477237461db", null, "Technician", "TECHNICIAN" },
                    { "c968d2f4-8b14-46f3-9dfe-5c9b56e80028", null, "Customer", "CUSTOMER" },
                    { "e922dcc9-0a6b-4ffa-ad55-940973dc0788", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "67ca9f17-59c0-4c1b-bc9e-9000e76664e3", 0, null, null, null, "2859d53a-47ac-425d-8cf4-6cc9c9c50772", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHPsn7wH2TIVA8dwbsV7M9o0DF86yXV0Pn/0OsXgVpXoY/N1M97sVPOvF5oz/5AR+w==", null, true, null, "ac7c80ed-67be-4397-ab26-d6aa77191141", false, "manager@maxicycles.co.uk" },
                    { "7975971b-6901-4ab3-a84f-d1c582a256c2", 0, null, null, null, "58d74d54-0364-4098-9bc0-7fa995ddc5bb", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMl6cPm+w+whfOGObtisWc0nDVjdjqxAZiSX2oUQYpq4yDVqIJB/4j9oo7XsLfInlw==", null, true, null, "0fbdd186-f08e-4089-81bd-001c8dad1fb4", false, "stockControl@maxicycles.co.uk" },
                    { "8b45a27e-b0af-4e01-bb31-9df2ca374457", 0, null, null, null, "8ec02c4f-eb4b-457d-96f0-f4d7bbcba580", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJ8zw48d5499bmT3ViHiA3PGODGcSBhhKtEpkHeladKCIzQ/nlnIBRU+Th6ne6L2wA==", null, true, null, "99e5ffdc-c081-4d2d-859b-f738d0b1049e", false, "mediaManager@maxicycles.co.uk" },
                    { "8df23e2f-7b1f-4f6d-94fa-2e61ed0626fc", 0, null, null, null, "58c89d20-8efa-4835-8dc5-ffe99e6a01d0", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFd++wQOtJnvfk1jeguvFUR10HwdbyaX+lRwGJa5AA81A26bcqAmL/yNmLF+Vukp1g==", null, true, null, "1a7a69fd-c2df-4252-a4af-efc93e4f9dbf", false, "accountsClerk@maxicycles.co.uk" },
                    { "bbc8a4b6-92b0-4c4d-8992-d35f14911d9b", 0, null, null, null, "ade33501-efeb-44cb-ada6-83a908d6c51b", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBBpscWoHyhV+9kr5SUEthpoLWhGnp9bgaQzJWNZNw2LQe6j8GGOO5BK6Ij8B+qOwg==", null, true, null, "ba3b20f4-f29d-4b8f-8d2d-c3575eb7505f", false, "technician@maxicycles.co.uk" },
                    { "f4ed1491-544a-41c6-ac90-cd815bccfa17", 0, null, null, null, "2065ac1f-de37-4eee-b646-0da7cd1617a3", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEGyhn9Cneb4jsUcB44KutA02W38g5cW16qScrOJh82b5JsuqMyyIV4F/Wd5OHNMEpQ==", null, true, null, "6f12f611-02a9-4a7f-aa95-42f624ade25d", false, "customer@example.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "97a2f403-be15-4a35-9f5d-e3f071289e97", "67ca9f17-59c0-4c1b-bc9e-9000e76664e3" },
                    { "e922dcc9-0a6b-4ffa-ad55-940973dc0788", "7975971b-6901-4ab3-a84f-d1c582a256c2" },
                    { "05d7f093-d303-4cc7-aa30-372647f81cd4", "8b45a27e-b0af-4e01-bb31-9df2ca374457" },
                    { "0ac3ea3f-c498-468a-9fb6-1740fc22922a", "8df23e2f-7b1f-4f6d-94fa-2e61ed0626fc" },
                    { "bf929e36-b71c-45f5-9ccb-8477237461db", "bbc8a4b6-92b0-4c4d-8992-d35f14911d9b" },
                    { "c968d2f4-8b14-46f3-9dfe-5c9b56e80028", "f4ed1491-544a-41c6-ac90-cd815bccfa17" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_ImageId",
                table: "Post",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Image_ImageId",
                table: "Post",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Image_ImageId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_ImageId",
                table: "Post");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97a2f403-be15-4a35-9f5d-e3f071289e97", "67ca9f17-59c0-4c1b-bc9e-9000e76664e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e922dcc9-0a6b-4ffa-ad55-940973dc0788", "7975971b-6901-4ab3-a84f-d1c582a256c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "05d7f093-d303-4cc7-aa30-372647f81cd4", "8b45a27e-b0af-4e01-bb31-9df2ca374457" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ac3ea3f-c498-468a-9fb6-1740fc22922a", "8df23e2f-7b1f-4f6d-94fa-2e61ed0626fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf929e36-b71c-45f5-9ccb-8477237461db", "bbc8a4b6-92b0-4c4d-8992-d35f14911d9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c968d2f4-8b14-46f3-9dfe-5c9b56e80028", "f4ed1491-544a-41c6-ac90-cd815bccfa17" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05d7f093-d303-4cc7-aa30-372647f81cd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ac3ea3f-c498-468a-9fb6-1740fc22922a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97a2f403-be15-4a35-9f5d-e3f071289e97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf929e36-b71c-45f5-9ccb-8477237461db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c968d2f4-8b14-46f3-9dfe-5c9b56e80028");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e922dcc9-0a6b-4ffa-ad55-940973dc0788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67ca9f17-59c0-4c1b-bc9e-9000e76664e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7975971b-6901-4ab3-a84f-d1c582a256c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b45a27e-b0af-4e01-bb31-9df2ca374457");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8df23e2f-7b1f-4f6d-94fa-2e61ed0626fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbc8a4b6-92b0-4c4d-8992-d35f14911d9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ed1491-544a-41c6-ac90-cd815bccfa17");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Post");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dcd1f5c-74da-4f8f-9018-92d877be9528", null, "Technician", "TECHNICIAN" },
                    { "73c2f531-429c-4d96-864a-67ff69a0ab4a", null, "StockControl", "STOCKCONTROL" },
                    { "9c509c8f-a5c2-4c95-aa1e-dfe978934eca", null, "MediaManager", "MEDIAMANAGER" },
                    { "a44e2a5f-f9d7-4b15-ab38-393e72caee07", null, "Customer", "CUSTOMER" },
                    { "aeda6fc2-f31a-479a-bd5b-535c3d2d5a45", null, "Manager", "MANAGER" },
                    { "caff0464-729c-4e66-b15b-c6a26d1805f5", null, "AccountsClerk", "ACCOUNTSCLERK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0edda849-c8df-4147-bcd3-9009032b8109", 0, null, null, null, "74ac1c36-f8fc-46e0-865d-96edfe751e27", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECfFp3LlTaUkzN7dZ8QpUW3gCCp7YoCPjnBSXOMSZcqPl85eceNf0D2b0wGEV70KMg==", null, true, null, "a95e7913-54eb-4f3d-8f41-a5425895da0d", false, "manager@maxicycles.co.uk" },
                    { "99d3842d-990c-4a7f-917f-a2f35ae96a55", 0, null, null, null, "ef528604-9496-4fea-84ff-be1b3dd12bcd", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJ9u6INyk7SkE3Hv+ObQH8LKCkw00yAW/RaF/JWjcU3y2pEylPstTY5BsiPCOBL/xw==", null, true, null, "bd5c2d9e-53c2-4174-bd92-78dbb1828604", false, "technician@maxicycles.co.uk" },
                    { "b77a9450-4916-465b-afbe-25276ca354d2", 0, null, null, null, "efcc73d7-b342-4326-9f26-be26743f6fbe", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEOLaxU0LJ5z+MJXNyZp4ibJvkkI3CMwE3/U64RKitFTI4drMAoovxdpduTYT5GjMvg==", null, true, null, "36b43541-3778-4029-9bb0-5686110494d5", false, "stockControl@maxicycles.co.uk" },
                    { "cb784eae-c626-496d-869f-8686e6355a27", 0, null, null, null, "e41a5be6-5b62-4bec-908c-74f2067fb6cb", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEG2CwxRDN98spmUtA1DzoKqEfawdeNc2fTdThSDe/9ppxj5CLaC5Fbg1I7ZFSs7fbw==", null, true, null, "dac5299f-f164-421f-976d-e9379b13979b", false, "customer@example.co.uk" },
                    { "f11f8a14-c0b9-4a3a-98e5-252968a63b21", 0, null, null, null, "057a16bb-6441-4c5f-bb3a-d4956c20d4eb", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGzOrbbsbHPfdcsq5KsfOPJxeIvJpQ0VUuXOVSeEBP/DFQ8qvh75J/F6ap6e7I8WuQ==", null, true, null, "b9e47a6a-fbf2-42b6-8dc0-80969dc0a6c5", false, "mediaManager@maxicycles.co.uk" },
                    { "f18365a7-a77f-45f4-88df-1304e29187a7", 0, null, null, null, "9dec7516-7f5c-4e7d-ae94-dd66d88a4c52", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFw1yCDDvq1m+V3V0N87ou6RJFdXrb+NKP5UnCYQsxsjMXKZJrbJczcBn0dhUz2/jw==", null, true, null, "6bd42356-260c-4005-952c-e5ce668eaf16", false, "accountsClerk@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aeda6fc2-f31a-479a-bd5b-535c3d2d5a45", "0edda849-c8df-4147-bcd3-9009032b8109" },
                    { "3dcd1f5c-74da-4f8f-9018-92d877be9528", "99d3842d-990c-4a7f-917f-a2f35ae96a55" },
                    { "73c2f531-429c-4d96-864a-67ff69a0ab4a", "b77a9450-4916-465b-afbe-25276ca354d2" },
                    { "a44e2a5f-f9d7-4b15-ab38-393e72caee07", "cb784eae-c626-496d-869f-8686e6355a27" },
                    { "9c509c8f-a5c2-4c95-aa1e-dfe978934eca", "f11f8a14-c0b9-4a3a-98e5-252968a63b21" },
                    { "caff0464-729c-4e66-b15b-c6a26d1805f5", "f18365a7-a77f-45f4-88df-1304e29187a7" }
                });
        }
    }
}
