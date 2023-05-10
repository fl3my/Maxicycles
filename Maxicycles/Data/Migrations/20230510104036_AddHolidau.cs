using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHolidau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e68714c-12c0-46d3-af09-4c3ccadb743c", null, "MediaManager", "MEDIAMANAGER" },
                    { "47f8782a-066d-4dd6-888e-64a65dc4fc6e", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "8810567a-3897-4157-95d1-e7759e35c410", null, "StockControl", "STOCKCONTROL" },
                    { "f0f8cec5-c616-4023-84f6-4f0998c33b11", null, "Technician", "TECHNICIAN" },
                    { "f4df665f-3275-4e00-bc5a-cf224515fd03", null, "Manager", "MANAGER" },
                    { "fffebb40-fbd0-4a2f-a741-e41c44b70153", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "49b05646-70aa-45be-859c-e6245dc3fcec", 0, null, null, null, "0f7f9009-1873-4451-b123-50949e1eddfb", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEAtiGi4Ax2rhd/RrAQutf9WaE+YlqL/GOgUL357b3Fx9qfLzot1juvoGTOtmqLpiyA==", null, true, null, "0cb02ae1-d738-44d7-8bce-5725ccf0418d", false, "stockControl@maxicycles.co.uk" },
                    { "5707b11a-5ade-42eb-9acd-2701cae393de", 0, null, null, null, "f24a5183-b9b0-4c66-af9e-dd262a0dcdba", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEAD+C7Sk/ie/EfJBSPQ//66D19HNJqnBQRHh+PRMvaPYaY2qgHIe4pPjWR9vvmoVPQ==", null, true, null, "f7b43212-2303-4e59-83ff-5428fae046e8", false, "customer@example.co.uk" },
                    { "5adf2a57-2ac0-4952-aa31-e22c375489c5", 0, null, null, null, "887dd5bf-0181-4223-85a4-7f81a7ad016f", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJNkMbDe1JYHd16n0FIuvxhPeWYXbfvSX0SZlaF78KFP0xBKl1DkvBguIdVu69wcNA==", null, true, null, "2c3f9ae0-7813-47cf-942f-d98d3819e8d1", false, "accountsClerk@maxicycles.co.uk" },
                    { "693e39b6-7280-46b4-8281-e48b378a5433", 0, null, null, null, "b2feb40a-b8cd-479b-bb2b-624b8905f905", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPbfP8jOEp0SvM39cTQLsLgRM+f0WA/xPMrWuyKA+HtckRhCsgwW2SsVJ8pUt1NSTQ==", null, true, null, "37d17184-1d5f-41ce-b430-3cdcd7478531", false, "mediaManager@maxicycles.co.uk" },
                    { "924646b4-6b81-40d3-a242-ee6599a5eeb2", 0, null, null, null, "55fa07cf-0dcb-44d8-8807-4893e1569e8d", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECgmYsKaX/jjFSyUwv2oElSMz4duH4NOStHepzrI24bghYtQcj04hGuI8alh6CX7+w==", null, true, null, "9639962f-34aa-455f-b9a3-95436802cb2a", false, "technician@maxicycles.co.uk" },
                    { "ab47f53b-4991-473f-888c-1bf82253bee6", 0, null, null, null, "a14b1ce6-b684-42c8-a877-e959e3a8273f", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDjsluyG4+nRSDuFJS9yx1T81Uu+TmUKljBDL0nnOlmdngGk4cyCclyt6OjLcDANrQ==", null, true, null, "274dc958-e43f-4153-9fef-67e03e92c58e", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8810567a-3897-4157-95d1-e7759e35c410", "49b05646-70aa-45be-859c-e6245dc3fcec" },
                    { "fffebb40-fbd0-4a2f-a741-e41c44b70153", "5707b11a-5ade-42eb-9acd-2701cae393de" },
                    { "47f8782a-066d-4dd6-888e-64a65dc4fc6e", "5adf2a57-2ac0-4952-aa31-e22c375489c5" },
                    { "3e68714c-12c0-46d3-af09-4c3ccadb743c", "693e39b6-7280-46b4-8281-e48b378a5433" },
                    { "f0f8cec5-c616-4023-84f6-4f0998c33b11", "924646b4-6b81-40d3-a242-ee6599a5eeb2" },
                    { "f4df665f-3275-4e00-bc5a-cf224515fd03", "ab47f53b-4991-473f-888c-1bf82253bee6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8810567a-3897-4157-95d1-e7759e35c410", "49b05646-70aa-45be-859c-e6245dc3fcec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fffebb40-fbd0-4a2f-a741-e41c44b70153", "5707b11a-5ade-42eb-9acd-2701cae393de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47f8782a-066d-4dd6-888e-64a65dc4fc6e", "5adf2a57-2ac0-4952-aa31-e22c375489c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e68714c-12c0-46d3-af09-4c3ccadb743c", "693e39b6-7280-46b4-8281-e48b378a5433" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0f8cec5-c616-4023-84f6-4f0998c33b11", "924646b4-6b81-40d3-a242-ee6599a5eeb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4df665f-3275-4e00-bc5a-cf224515fd03", "ab47f53b-4991-473f-888c-1bf82253bee6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e68714c-12c0-46d3-af09-4c3ccadb743c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47f8782a-066d-4dd6-888e-64a65dc4fc6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8810567a-3897-4157-95d1-e7759e35c410");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f8cec5-c616-4023-84f6-4f0998c33b11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4df665f-3275-4e00-bc5a-cf224515fd03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fffebb40-fbd0-4a2f-a741-e41c44b70153");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49b05646-70aa-45be-859c-e6245dc3fcec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5707b11a-5ade-42eb-9acd-2701cae393de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5adf2a57-2ac0-4952-aa31-e22c375489c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e39b6-7280-46b4-8281-e48b378a5433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "924646b4-6b81-40d3-a242-ee6599a5eeb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab47f53b-4991-473f-888c-1bf82253bee6");

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
    }
}
