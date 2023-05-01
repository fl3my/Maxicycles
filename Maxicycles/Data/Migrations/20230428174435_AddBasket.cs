using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBasket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84eb40e1-66ad-4889-98fb-86d6ae74eaff", "015e5689-1ee6-4e48-bd53-8b553bfb8e78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93e771b7-3739-418e-a45a-3a55680a2e94", "2ee746ef-5762-4c9b-94f9-8835f0fe4989" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ab355a1-7dd0-4e69-8162-ede0c118cfcb", "86a81e86-aa93-41d2-9a28-1dcb036d9d3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31f3e200-49bb-4afd-b2f7-a2d194731b13", "94b722d1-00ba-4b2f-9744-1acfabc5b719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ed0615c-1c6f-4ca1-a92d-1ee27e466a88", "a020a883-e709-4c39-9722-99a92d2e770b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4f6f8252-5d56-44e2-b76b-2f54f35945c7", "ae7daa8a-d867-458b-8620-91e30d4e4a37" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f3e200-49bb-4afd-b2f7-a2d194731b13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f6f8252-5d56-44e2-b76b-2f54f35945c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ab355a1-7dd0-4e69-8162-ede0c118cfcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ed0615c-1c6f-4ca1-a92d-1ee27e466a88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84eb40e1-66ad-4889-98fb-86d6ae74eaff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93e771b7-3739-418e-a45a-3a55680a2e94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "015e5689-1ee6-4e48-bd53-8b553bfb8e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ee746ef-5762-4c9b-94f9-8835f0fe4989");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86a81e86-aa93-41d2-9a28-1dcb036d9d3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94b722d1-00ba-4b2f-9744-1acfabc5b719");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a020a883-e709-4c39-9722-99a92d2e770b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae7daa8a-d867-458b-8620-91e30d4e4a37");

            migrationBuilder.CreateTable(
                name: "BasketItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    MaxicyclesUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItem_AspNetUsers_MaxicyclesUserId",
                        column: x => x.MaxicyclesUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BasketItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c308a37-41e1-4437-a42b-8179006a4e79", null, "Manager", "MANAGER" },
                    { "70dc082f-542e-4773-b38f-a08f1b3d3e2c", null, "StockControl", "STOCKCONTROL" },
                    { "a3b9333e-f072-435d-9293-dcc2ae4a9362", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "c7981b57-3a48-4087-98cc-d4cd44587e9f", null, "Customer", "CUSTOMER" },
                    { "ce504e27-f17d-4afa-b212-100da7ecf41e", null, "MediaManager", "MEDIAMANAGER" },
                    { "f1cd645b-32fe-48b6-9d70-a86637e2bd87", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bb15890-5240-4ec3-b687-bd16de1f4c9b", 0, null, null, null, "f0882549-b0ed-43d9-a85f-6af1c7a64597", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEIz69JAl6pnCDBkXrIrLTl5q63Z4XDWzR+A0OfwWJ6ILZl7ind4gFMOE1Zd2+6jI+w==", null, true, null, "ca27c05a-0239-4161-ad6f-ba3aea75c895", false, "customer@example.co.uk" },
                    { "5f7517b8-1335-4b4a-9b35-57caf1c1dd13", 0, null, null, null, "48017d68-9763-4ae6-a8ec-98221674997a", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIq7+SzFiMIJ3WUe9O6cHW114KIcwllhxKSL1h+WdauQp2XVdGnBCNvdmqUZuW5psQ==", null, true, null, "4437240b-3842-4dd7-81bd-132341598272", false, "stockControl@maxicycles.co.uk" },
                    { "82449f70-9c39-470e-a006-649c5c3f8cf5", 0, null, null, null, "f79b373a-d885-417b-b96a-e0b4ee49bf0b", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEM7gzBczo2EYabM4ttSvbuLibkv8qkGUc2vRxWtCd/229ZqLhq+TPZE9MtLK8aO68Q==", null, true, null, "d89704a5-0aa7-449f-85e7-3519d8d46bc1", false, "technician@maxicycles.co.uk" },
                    { "b0a12866-85c6-41c4-8e17-4557046d5738", 0, null, null, null, "6fd5654c-b233-47f6-8572-2005d0936768", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEOyoqIDkd65Q/UjNhkvGCjG9jIqCMuPaoO4T2ssU1kN3hV8sfCPYY+d3PTMnujbVxg==", null, true, null, "5bbc572e-0db0-41ed-b7a5-a8349423f42c", false, "manager@maxicycles.co.uk" },
                    { "b5674f84-44b6-463e-b6ec-da13dac5664d", 0, null, null, null, "6a60513d-8e38-4d0d-bf9e-4d785834f64c", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEByswbqx9DJIAcnN4D6HPID6bRoL+a8SkYM5THilJBM4HCKVGgtaQclHmNzJW2lyiQ==", null, true, null, "4bd2ae52-7c19-4650-8ba9-bc076ff56c7c", false, "accountsClerk@maxicycles.co.uk" },
                    { "d49b613f-1baa-482e-b8d7-b792e99f489e", 0, null, null, null, "ad251c6e-8d86-4f81-8f21-42453fac6f42", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEF+OiGnK1oiI8unsHMJfjJKEpSCeJszESqD5rgc1Nkmc3I0TVxHjNKg7dBzqhcATyw==", null, true, null, "5d761741-efda-49c9-b4c3-e8018c9476a8", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c7981b57-3a48-4087-98cc-d4cd44587e9f", "0bb15890-5240-4ec3-b687-bd16de1f4c9b" },
                    { "70dc082f-542e-4773-b38f-a08f1b3d3e2c", "5f7517b8-1335-4b4a-9b35-57caf1c1dd13" },
                    { "f1cd645b-32fe-48b6-9d70-a86637e2bd87", "82449f70-9c39-470e-a006-649c5c3f8cf5" },
                    { "3c308a37-41e1-4437-a42b-8179006a4e79", "b0a12866-85c6-41c4-8e17-4557046d5738" },
                    { "a3b9333e-f072-435d-9293-dcc2ae4a9362", "b5674f84-44b6-463e-b6ec-da13dac5664d" },
                    { "ce504e27-f17d-4afa-b212-100da7ecf41e", "d49b613f-1baa-482e-b8d7-b792e99f489e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_ItemId",
                table: "BasketItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_MaxicyclesUserId",
                table: "BasketItem",
                column: "MaxicyclesUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItem");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7981b57-3a48-4087-98cc-d4cd44587e9f", "0bb15890-5240-4ec3-b687-bd16de1f4c9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70dc082f-542e-4773-b38f-a08f1b3d3e2c", "5f7517b8-1335-4b4a-9b35-57caf1c1dd13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1cd645b-32fe-48b6-9d70-a86637e2bd87", "82449f70-9c39-470e-a006-649c5c3f8cf5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c308a37-41e1-4437-a42b-8179006a4e79", "b0a12866-85c6-41c4-8e17-4557046d5738" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3b9333e-f072-435d-9293-dcc2ae4a9362", "b5674f84-44b6-463e-b6ec-da13dac5664d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce504e27-f17d-4afa-b212-100da7ecf41e", "d49b613f-1baa-482e-b8d7-b792e99f489e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c308a37-41e1-4437-a42b-8179006a4e79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70dc082f-542e-4773-b38f-a08f1b3d3e2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3b9333e-f072-435d-9293-dcc2ae4a9362");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7981b57-3a48-4087-98cc-d4cd44587e9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce504e27-f17d-4afa-b212-100da7ecf41e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1cd645b-32fe-48b6-9d70-a86637e2bd87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bb15890-5240-4ec3-b687-bd16de1f4c9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f7517b8-1335-4b4a-9b35-57caf1c1dd13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82449f70-9c39-470e-a006-649c5c3f8cf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0a12866-85c6-41c4-8e17-4557046d5738");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5674f84-44b6-463e-b6ec-da13dac5664d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d49b613f-1baa-482e-b8d7-b792e99f489e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31f3e200-49bb-4afd-b2f7-a2d194731b13", null, "StockControl", "STOCKCONTROL" },
                    { "4f6f8252-5d56-44e2-b76b-2f54f35945c7", null, "Manager", "MANAGER" },
                    { "6ab355a1-7dd0-4e69-8162-ede0c118cfcb", null, "Customer", "CUSTOMER" },
                    { "7ed0615c-1c6f-4ca1-a92d-1ee27e466a88", null, "Technician", "TECHNICIAN" },
                    { "84eb40e1-66ad-4889-98fb-86d6ae74eaff", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "93e771b7-3739-418e-a45a-3a55680a2e94", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "015e5689-1ee6-4e48-bd53-8b553bfb8e78", 0, null, null, null, "bc184fe6-1078-4fee-8907-2459032bae81", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBKusnfUBWgzAL8Fr/0nl3NrvWiIyi+10gwo4Jq0l334EAqNkPsjfJGpbsyFu8i/gQ==", null, true, null, "7be5adeb-00d7-4ec2-9e7e-66badbaeb239", false, "accountsClerk@maxicycles.co.uk" },
                    { "2ee746ef-5762-4c9b-94f9-8835f0fe4989", 0, null, null, null, "80fd849a-2ef1-4f27-acbd-66ff9b6eeb5f", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIEbsjzaN+XvX/tX9B0kzauJh7BoNz7MJgD3GQ2qi9tmf1YSN4LZxBJ86bZJ0DfeKg==", null, true, null, "b22e0e57-3564-4dc9-9f13-a4b3fbec11ea", false, "mediaManager@maxicycles.co.uk" },
                    { "86a81e86-aa93-41d2-9a28-1dcb036d9d3e", 0, null, null, null, "36ff33ad-3a56-47d2-b610-f4d3170a1ce4", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEAit4UUcV74EREf5UaiUM3135zw8tm3diDFBjkeBh4sOUL3scFBMa2DyYa0rA18NIA==", null, true, null, "f90b7efd-0ce9-406d-ae99-b01b24bf4e3e", false, "customer@example.co.uk" },
                    { "94b722d1-00ba-4b2f-9744-1acfabc5b719", 0, null, null, null, "f0a8b455-86fe-4d0b-8146-516aab1cb908", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBCfSILEQJRTFaiBI+WS2H7GB3/7aUZd3UQJ8fvKH5kSPV3QbtkzHPvE+g/QTtxyaw==", null, true, null, "fcf6d82d-3cdb-4a05-bbb9-981637583548", false, "stockControl@maxicycles.co.uk" },
                    { "a020a883-e709-4c39-9722-99a92d2e770b", 0, null, null, null, "586eedb8-3b06-40eb-b47f-c8021d5dbe34", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEING4+J3ZNB0ljXz8JApC6NlR/JM0LWNBuQluzScTsVvkBNZXuTIgzKVbth4boysaw==", null, true, null, "04abce21-2f56-46bb-ae86-126dfedf3c28", false, "technician@maxicycles.co.uk" },
                    { "ae7daa8a-d867-458b-8620-91e30d4e4a37", 0, null, null, null, "6ad7261d-d836-4702-bf66-41ca0c364864", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEA4AX9bcBc7Qy4CH0vZNUeTg7HE2Oviu4jI7GE6FFK9bLsEhKN7PbvGqi81M1X0MsQ==", null, true, null, "c7c2bb26-7541-496d-a05b-df42d9f2aee0", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "84eb40e1-66ad-4889-98fb-86d6ae74eaff", "015e5689-1ee6-4e48-bd53-8b553bfb8e78" },
                    { "93e771b7-3739-418e-a45a-3a55680a2e94", "2ee746ef-5762-4c9b-94f9-8835f0fe4989" },
                    { "6ab355a1-7dd0-4e69-8162-ede0c118cfcb", "86a81e86-aa93-41d2-9a28-1dcb036d9d3e" },
                    { "31f3e200-49bb-4afd-b2f7-a2d194731b13", "94b722d1-00ba-4b2f-9744-1acfabc5b719" },
                    { "7ed0615c-1c6f-4ca1-a92d-1ee27e466a88", "a020a883-e709-4c39-9722-99a92d2e770b" },
                    { "4f6f8252-5d56-44e2-b76b-2f54f35945c7", "ae7daa8a-d867-458b-8620-91e30d4e4a37" }
                });
        }
    }
}
