using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62a0f28d-db6c-477d-a6bf-32898c7edbae", "63882faa-7b7c-4480-8d4d-06c5fc879c26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3fb2498b-2198-4599-91fd-29dd692a7ae0", "7cfd2e33-59cb-449b-83a3-094ad2aa0ecb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d1a5745-16dd-4798-97eb-b24e12fdad36", "87661ef8-56ff-4369-88f8-3e6e312351b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21120157-e8ad-459e-a6da-b68e863203b4", "919f99f6-9e7b-48bf-b64f-d0c9e5567d80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2e4825e-e4c9-4c15-9bbd-495f90d2b233", "b06641f7-3ffb-49e2-b08d-c36976f44cd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9db9addd-ed45-4da2-8e57-dcd250d9fcec", "da5b2c22-1f97-42dd-9db9-7e825185010f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21120157-e8ad-459e-a6da-b68e863203b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fb2498b-2198-4599-91fd-29dd692a7ae0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1a5745-16dd-4798-97eb-b24e12fdad36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a0f28d-db6c-477d-a6bf-32898c7edbae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9db9addd-ed45-4da2-8e57-dcd250d9fcec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e4825e-e4c9-4c15-9bbd-495f90d2b233");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63882faa-7b7c-4480-8d4d-06c5fc879c26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cfd2e33-59cb-449b-83a3-094ad2aa0ecb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87661ef8-56ff-4369-88f8-3e6e312351b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "919f99f6-9e7b-48bf-b64f-d0c9e5567d80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b06641f7-3ffb-49e2-b08d-c36976f44cd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da5b2c22-1f97-42dd-9db9-7e825185010f");

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UploadedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaxicyclesUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_AspNetUsers_MaxicyclesUserId",
                        column: x => x.MaxicyclesUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UploadedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MaxicyclesUserId = table.Column<string>(type: "text", nullable: true),
                    PostId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_MaxicyclesUserId",
                        column: x => x.MaxicyclesUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MaxicyclesUserId",
                table: "Comment",
                column: "MaxicyclesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MaxicyclesUserId",
                table: "Post",
                column: "MaxicyclesUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Post");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21120157-e8ad-459e-a6da-b68e863203b4", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "3fb2498b-2198-4599-91fd-29dd692a7ae0", null, "StockControl", "STOCKCONTROL" },
                    { "5d1a5745-16dd-4798-97eb-b24e12fdad36", null, "Customer", "CUSTOMER" },
                    { "62a0f28d-db6c-477d-a6bf-32898c7edbae", null, "Technician", "TECHNICIAN" },
                    { "9db9addd-ed45-4da2-8e57-dcd250d9fcec", null, "MediaManager", "MEDIAMANAGER" },
                    { "f2e4825e-e4c9-4c15-9bbd-495f90d2b233", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63882faa-7b7c-4480-8d4d-06c5fc879c26", 0, null, null, null, "b4ca66f7-ed5c-42df-baa8-c3a8bb439267", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJF8ArdEmZyslP8KKzBouL2AQ2N1RZM3nK/JJbjeQDUa0+zua+4xDnH/XL48jU78QA==", null, true, null, "934725ab-89d6-432f-b725-61eb59feb19f", false, "technician@maxicycles.co.uk" },
                    { "7cfd2e33-59cb-449b-83a3-094ad2aa0ecb", 0, null, null, null, "eaefa2d7-f542-4f9c-9dd7-12469da7423a", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEGC5w4ncj+dD95LNuqwmjdzLscZpbEVboEULNi2oeN3VLarTd0Y8Ls2E/iEd325lA==", null, true, null, "631cd55d-bdf8-4f56-ad19-9d46efa66d9b", false, "stockControl@maxicycles.co.uk" },
                    { "87661ef8-56ff-4369-88f8-3e6e312351b0", 0, null, null, null, "b894705b-8721-44ad-a6f5-8795b3eafe2a", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEPhdfVr06PBF9KKQS4tGFiQtnQ7tZgPO4dzLc9ajr3P9okyFbV6klEMSXnbZbRl3Ww==", null, true, null, "a2bb588c-89c6-4a1d-81aa-53acc17c93ca", false, "customer@example.co.uk" },
                    { "919f99f6-9e7b-48bf-b64f-d0c9e5567d80", 0, null, null, null, "eabda38b-96c2-49fb-a1ff-60fbbe2cdad6", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIek94gTseBJqdJNg63WnDCL/4aUpr4WLf1Rz3qNhSnZJ28xdkV3qc457+bWbsrWjA==", null, true, null, "647e967f-f92c-43ff-8129-92977b351e8c", false, "accountsClerk@maxicycles.co.uk" },
                    { "b06641f7-3ffb-49e2-b08d-c36976f44cd3", 0, null, null, null, "3a0a2e06-dcf2-44d6-ad7f-6607b4a69af2", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPtVy0GrDGOJAnyZNuBq4aUCY9NOb2DSY4NoAm8evWQPTSMygaKJCvA3B+MLMliEpg==", null, true, null, "bebeaebb-eee3-403e-8e3d-708014876cfb", false, "manager@maxicycles.co.uk" },
                    { "da5b2c22-1f97-42dd-9db9-7e825185010f", 0, null, null, null, "76b33143-b45d-4ad3-b7e8-7a6b446708a8", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHQRvOgHlHfFi0iYh/JR1ZO9KGOkMFAO3BX5IapzoV8N2l2LPTT+5on2Fzly7x7bHA==", null, true, null, "29fe63e7-6603-4fd3-9eda-95cc3d63971f", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "62a0f28d-db6c-477d-a6bf-32898c7edbae", "63882faa-7b7c-4480-8d4d-06c5fc879c26" },
                    { "3fb2498b-2198-4599-91fd-29dd692a7ae0", "7cfd2e33-59cb-449b-83a3-094ad2aa0ecb" },
                    { "5d1a5745-16dd-4798-97eb-b24e12fdad36", "87661ef8-56ff-4369-88f8-3e6e312351b0" },
                    { "21120157-e8ad-459e-a6da-b68e863203b4", "919f99f6-9e7b-48bf-b64f-d0c9e5567d80" },
                    { "f2e4825e-e4c9-4c15-9bbd-495f90d2b233", "b06641f7-3ffb-49e2-b08d-c36976f44cd3" },
                    { "9db9addd-ed45-4da2-8e57-dcd250d9fcec", "da5b2c22-1f97-42dd-9db9-7e825185010f" }
                });
        }
    }
}
