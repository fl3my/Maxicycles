using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiptSentBool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "ReceiptSent",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06fb5a00-706b-42ae-ae91-d723eed3d738", null, "Technician", "TECHNICIAN" },
                    { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "b868633e-2427-4279-b3bb-e518fda88ed7", null, "Customer", "CUSTOMER" },
                    { "bb9c94fa-3017-45fe-b08f-33a330e7796e", null, "StockControl", "STOCKCONTROL" },
                    { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", null, "Manager", "MANAGER" },
                    { "ffafadce-2165-40ed-96ed-5eca19ece5e7", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22a113e6-a660-42d9-beb1-6361427aa4ee", 0, null, null, null, "07641616-8537-4d1c-a52a-02a29c7b0f4c", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGEYH9YKN+IXJ84fUvqLNpSAX6ogpwkprQc4fbZqWATIT3n/xkQTpziOnkJrGAIPxg==", null, true, null, "ea2f6926-41ee-486b-b095-02ba132978d5", false, "accountsClerk@maxicycles.co.uk" },
                    { "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e", 0, null, null, null, "a042b903-d1e8-440b-95d6-5a55546b0283", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELrB2raMGI6x7cJYevjSwUwGfBhDns5gOz+SdW5hwePNFLR6C1f3KzHmYNsNR61PBg==", null, true, null, "98565b65-d6d4-4fb9-b0fb-efa36f6cc601", false, "mediaManager@maxicycles.co.uk" },
                    { "9c5c2f64-0b60-4dc8-9739-0fe41595a012", 0, null, null, null, "04d38fc8-786e-4c32-b704-8773f3d13ff2", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEJzmHCgvAr1cmAfBzUt5QdnBOyDo9niDq3BfVb5R4Q0//W+XnBTHKIAMpAyBUht9mw==", null, true, null, "fff2b6aa-f8d1-4b17-92b8-6267d613ba4e", false, "customer@example.co.uk" },
                    { "a2eea9b2-1bbc-4263-ac92-dd84a180a768", 0, null, null, null, "7ac07322-46be-4088-bc50-befd60457351", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEE9HCmXgdKo8Xl/cs1r/2t4iTdmAgpC6wFKo23PpkCX79azAacK9atrKy/wdyqEkwQ==", null, true, null, "bcb959bf-5975-432c-ae30-09d365c7e875", false, "manager@maxicycles.co.uk" },
                    { "e0f7545b-f5f8-4445-8e8c-1823b0242259", 0, null, null, null, "69dd1990-7638-4a2d-821a-f53dbad87e01", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMunIdILzUecZbefeE7LaIwr2NgLUIpbkw4FYwCoXefh+pk67orj2e/8RDvIqSzndw==", null, true, null, "8332eb68-39f6-402c-959b-59f2f8b22f0f", false, "technician@maxicycles.co.uk" },
                    { "e7415056-2778-4cb6-a9e7-4e0db58a119d", 0, null, null, null, "fc0239ba-75cf-4833-8a47-c807e1387b8d", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGuux7RfD99/tFdQuULdMsv9fkZy1JwPBkahf2O+vi/xit6geso3xCHI+UkYD8Y5qA==", null, true, null, "e09fd68d-8d0e-4331-866a-aa36ede51fc1", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", "22a113e6-a660-42d9-beb1-6361427aa4ee" },
                    { "ffafadce-2165-40ed-96ed-5eca19ece5e7", "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e" },
                    { "b868633e-2427-4279-b3bb-e518fda88ed7", "9c5c2f64-0b60-4dc8-9739-0fe41595a012" },
                    { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", "a2eea9b2-1bbc-4263-ac92-dd84a180a768" },
                    { "06fb5a00-706b-42ae-ae91-d723eed3d738", "e0f7545b-f5f8-4445-8e8c-1823b0242259" },
                    { "bb9c94fa-3017-45fe-b08f-33a330e7796e", "e7415056-2778-4cb6-a9e7-4e0db58a119d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", "22a113e6-a660-42d9-beb1-6361427aa4ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffafadce-2165-40ed-96ed-5eca19ece5e7", "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b868633e-2427-4279-b3bb-e518fda88ed7", "9c5c2f64-0b60-4dc8-9739-0fe41595a012" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", "a2eea9b2-1bbc-4263-ac92-dd84a180a768" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06fb5a00-706b-42ae-ae91-d723eed3d738", "e0f7545b-f5f8-4445-8e8c-1823b0242259" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb9c94fa-3017-45fe-b08f-33a330e7796e", "e7415056-2778-4cb6-a9e7-4e0db58a119d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06fb5a00-706b-42ae-ae91-d723eed3d738");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b868633e-2427-4279-b3bb-e518fda88ed7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb9c94fa-3017-45fe-b08f-33a330e7796e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc629cfa-c2b7-4228-9b15-7d32938a61e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffafadce-2165-40ed-96ed-5eca19ece5e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22a113e6-a660-42d9-beb1-6361427aa4ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5c2f64-0b60-4dc8-9739-0fe41595a012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2eea9b2-1bbc-4263-ac92-dd84a180a768");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0f7545b-f5f8-4445-8e8c-1823b0242259");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7415056-2778-4cb6-a9e7-4e0db58a119d");

            migrationBuilder.DropColumn(
                name: "ReceiptSent",
                table: "Orders");

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
        }
    }
}
