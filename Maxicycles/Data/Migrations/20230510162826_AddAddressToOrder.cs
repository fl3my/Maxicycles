using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "Payment");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Orders",
                type: "text",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "Payment",
                type: "text",
                nullable: true);

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
    }
}
