using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBasketLine : Migration
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
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    MaxicyclesUserId = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    { "16200b7e-90ee-4bbf-8d75-d90a8c8b3f77", null, "Manager", "MANAGER" },
                    { "22bf8ca0-ecfe-49d6-b19d-e30dbb182795", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "288eb8d9-2007-4be6-8260-dafa5decf3d3", null, "Customer", "CUSTOMER" },
                    { "cb875469-fd2d-40ef-9444-b262e5b5536c", null, "MediaManager", "MEDIAMANAGER" },
                    { "ccdff53e-7300-4bc1-b57c-e96fc51fdbf9", null, "Technician", "TECHNICIAN" },
                    { "e1562df6-88b9-4f8e-97a4-a32a003726b2", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0977fe38-e966-4c3c-9ed2-baa211dc8370", 0, null, null, null, "5b618e49-0e70-4938-9124-1ff050871632", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIUd/OvCuraJRJyTwHyrbwLG8Mq9+kcUibN9mZ49UOkwRDRDUBK+KPM63RA6j4NWJQ==", null, true, null, "9089143f-6221-490f-a169-141a96016df7", false, "manager@maxicycles.co.uk" },
                    { "2ffce15e-50f1-4725-a2b6-e15d3918fe4d", 0, null, null, null, "c2ef8239-9392-4ed3-9c77-01febcd4e94d", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEMv/QvdHbLUfDOXz/ee+h3i3X5aYppX1meIgb4oqqOII6MzBKupcstK+lYARpaVxLQ==", null, true, null, "fcb77b34-8eff-4b6b-8008-73828583b200", false, "customer@example.co.uk" },
                    { "74dc088b-197d-4aed-9c25-2115ad842e4b", 0, null, null, null, "d9019232-131e-44ac-91b8-45df8517191c", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJhBJPSmcGvK8BCI4CVsQI5sV1k9KyU9kopAt0STkWQiL286wtbvQY3DUHYocI1YaQ==", null, true, null, "e1a21652-630a-4848-9f46-4f52eb9b4185", false, "accountsClerk@maxicycles.co.uk" },
                    { "a5bc14f1-024f-4524-a63f-5d22d560b93c", 0, null, null, null, "76f12742-b0fc-4d21-a280-1393f0a1b43e", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMcDCO7c8eytgqUXHT4BzDwPw5wLxpjU5CYRrDeOIeXQS2sMRfHkLyx4rBEitVTHDw==", null, true, null, "f07656a0-71b3-4890-aec7-c8bf10256270", false, "mediaManager@maxicycles.co.uk" },
                    { "a96986e8-108c-4a5e-aa27-482fb52cb4e3", 0, null, null, null, "a98366b0-476b-4581-9209-d7189139734e", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKFsRN9S/rzTcv53SN1zh1zArmfNr3rmP9S2BGaHHTLfCFj0dRwVXRBaiFegjVB7Rg==", null, true, null, "31ae5c34-0e09-4f62-8f4a-f54f8a69b4d4", false, "technician@maxicycles.co.uk" },
                    { "cda12566-084b-44d6-aeb5-b9b930749bf0", 0, null, null, null, "ec916bea-adc7-4cb0-aad9-c26da24cf9b2", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEM72gQx3xJnPeks99zpvi/fq9qEtZR9GGLLRfOfEXjHOC4NKsArjOB31TQWSYF8IWQ==", null, true, null, "14c50d49-6e37-4d9e-9044-208552fa9c0f", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "16200b7e-90ee-4bbf-8d75-d90a8c8b3f77", "0977fe38-e966-4c3c-9ed2-baa211dc8370" },
                    { "288eb8d9-2007-4be6-8260-dafa5decf3d3", "2ffce15e-50f1-4725-a2b6-e15d3918fe4d" },
                    { "22bf8ca0-ecfe-49d6-b19d-e30dbb182795", "74dc088b-197d-4aed-9c25-2115ad842e4b" },
                    { "cb875469-fd2d-40ef-9444-b262e5b5536c", "a5bc14f1-024f-4524-a63f-5d22d560b93c" },
                    { "ccdff53e-7300-4bc1-b57c-e96fc51fdbf9", "a96986e8-108c-4a5e-aa27-482fb52cb4e3" },
                    { "e1562df6-88b9-4f8e-97a4-a32a003726b2", "cda12566-084b-44d6-aeb5-b9b930749bf0" }
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
                keyValues: new object[] { "16200b7e-90ee-4bbf-8d75-d90a8c8b3f77", "0977fe38-e966-4c3c-9ed2-baa211dc8370" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "288eb8d9-2007-4be6-8260-dafa5decf3d3", "2ffce15e-50f1-4725-a2b6-e15d3918fe4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22bf8ca0-ecfe-49d6-b19d-e30dbb182795", "74dc088b-197d-4aed-9c25-2115ad842e4b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb875469-fd2d-40ef-9444-b262e5b5536c", "a5bc14f1-024f-4524-a63f-5d22d560b93c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ccdff53e-7300-4bc1-b57c-e96fc51fdbf9", "a96986e8-108c-4a5e-aa27-482fb52cb4e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1562df6-88b9-4f8e-97a4-a32a003726b2", "cda12566-084b-44d6-aeb5-b9b930749bf0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16200b7e-90ee-4bbf-8d75-d90a8c8b3f77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22bf8ca0-ecfe-49d6-b19d-e30dbb182795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "288eb8d9-2007-4be6-8260-dafa5decf3d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb875469-fd2d-40ef-9444-b262e5b5536c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccdff53e-7300-4bc1-b57c-e96fc51fdbf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1562df6-88b9-4f8e-97a4-a32a003726b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0977fe38-e966-4c3c-9ed2-baa211dc8370");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ffce15e-50f1-4725-a2b6-e15d3918fe4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74dc088b-197d-4aed-9c25-2115ad842e4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5bc14f1-024f-4524-a63f-5d22d560b93c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a96986e8-108c-4a5e-aa27-482fb52cb4e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cda12566-084b-44d6-aeb5-b9b930749bf0");

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
