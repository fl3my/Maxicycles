using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a60088e-3f43-4cee-81b1-8b801b09f43e", "530cfa61-53b5-416a-b035-0db137aecca7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24032058-0eb7-41b9-9da0-87409fa352f8", "659b6f67-9d5b-41fe-8758-41f78b909ee0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", "7aa0f806-552c-4693-92d9-935cafac8275" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef68838e-cb45-438a-bdd5-48e031a88a7c", "8bd3b947-dbd5-4b43-9037-9ef46badb551" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "81ba8c59-389a-41a8-b5b7-15979e872374", "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1e610396-57de-4a8a-a06d-d070f5dc70f5", "d7b2187b-a3b6-442e-b8dd-70ce72421fbe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a60088e-3f43-4cee-81b1-8b801b09f43e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e610396-57de-4a8a-a06d-d070f5dc70f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24032058-0eb7-41b9-9da0-87409fa352f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ba8c59-389a-41a8-b5b7-15979e872374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef68838e-cb45-438a-bdd5-48e031a88a7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "530cfa61-53b5-416a-b035-0db137aecca7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "659b6f67-9d5b-41fe-8758-41f78b909ee0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7aa0f806-552c-4693-92d9-935cafac8275");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bd3b947-dbd5-4b43-9037-9ef46badb551");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7b2187b-a3b6-442e-b8dd-70ce72421fbe");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    DeliveryMethodId = table.Column<int>(type: "integer", nullable: false),
                    MaxicyclesUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_MaxicyclesUserId",
                        column: x => x.MaxicyclesUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                        column: x => x.DeliveryMethodId,
                        principalTable: "DeliveryMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    LongNumber = table.Column<string>(type: "text", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AddressLine1 = table.Column<string>(type: "text", nullable: true),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    AddressLine3 = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Postcode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryMethodId",
                table: "Orders",
                column: "DeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MaxicyclesUserId",
                table: "Orders",
                column: "MaxicyclesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Orders");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a60088e-3f43-4cee-81b1-8b801b09f43e", null, "Customer", "CUSTOMER" },
                    { "1e610396-57de-4a8a-a06d-d070f5dc70f5", null, "StockControl", "STOCKCONTROL" },
                    { "24032058-0eb7-41b9-9da0-87409fa352f8", null, "Manager", "MANAGER" },
                    { "81ba8c59-389a-41a8-b5b7-15979e872374", null, "Technician", "TECHNICIAN" },
                    { "ef68838e-cb45-438a-bdd5-48e031a88a7c", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "530cfa61-53b5-416a-b035-0db137aecca7", 0, null, null, null, "d27b419f-d964-4e60-838f-11bfab1d21d5", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEC4VnqmLMyizB/452hsx+miHDhZu6j+KsK1KPCY0gntflu6wHAUYsNgYrSJkHCwisA==", null, true, null, "ca60a6ab-6e64-49b9-9953-00fde053b79b", false, "customer@example.co.uk" },
                    { "659b6f67-9d5b-41fe-8758-41f78b909ee0", 0, null, null, null, "680fe470-62a5-438f-a6c6-ebb0553a9f52", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEECPhlMHt1i8kkhoPCoKWKdPNymRC8EbwQRpcPAMbgYct/0csSlaVT4NSGhGlfqrfA==", null, true, null, "7d204845-053e-423f-973c-7d46da621d5b", false, "manager@maxicycles.co.uk" },
                    { "7aa0f806-552c-4693-92d9-935cafac8275", 0, null, null, null, "c0961d7a-0896-4be0-b546-48d914117e22", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBqyNKArzLKNIiQMI8s8r6VFA7pXswTkFpnNsmKHGgaD7LXFZDL+3CTnIGEOVaINdg==", null, true, null, "3093bd7d-f494-436f-8dc8-9cc4833d3df0", false, "mediaManager@maxicycles.co.uk" },
                    { "8bd3b947-dbd5-4b43-9037-9ef46badb551", 0, null, null, null, "8b62e72a-6f92-42c6-9d82-bdd7b5884d50", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEOrQt65N6LiI9yf2w5ic8tP7XPdbfmNpGpg3BRycx94wZ/Hqcb9oEU3mdY8ym4hOVQ==", null, true, null, "7cb65f89-dfc1-4d75-a786-926dc352f952", false, "accountsClerk@maxicycles.co.uk" },
                    { "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea", 0, null, null, null, "5778aa86-bb8b-41cc-ace8-3fc479381224", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHxuUZSaJSKBIHXmyrXl3xCpHjm0m7VncIkAIXOgp90Am3xyvozGEONyKv0Z/XGdzg==", null, true, null, "f6dc2ce1-67d0-4ddb-8caf-7c7abc510753", false, "technician@maxicycles.co.uk" },
                    { "d7b2187b-a3b6-442e-b8dd-70ce72421fbe", 0, null, null, null, "756aa394-e12a-4781-aa72-483fc17956a5", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFtLx3T905aP5pNCobspXxjvx1dfEFynFVhbegOnMYO3+B4vZRnA/cEutyF/udnzvw==", null, true, null, "85968f55-f413-4a1e-9533-b7a90bef0893", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a60088e-3f43-4cee-81b1-8b801b09f43e", "530cfa61-53b5-416a-b035-0db137aecca7" },
                    { "24032058-0eb7-41b9-9da0-87409fa352f8", "659b6f67-9d5b-41fe-8758-41f78b909ee0" },
                    { "f28d6c5c-1248-46a5-9b41-fdbcbd0b8f35", "7aa0f806-552c-4693-92d9-935cafac8275" },
                    { "ef68838e-cb45-438a-bdd5-48e031a88a7c", "8bd3b947-dbd5-4b43-9037-9ef46badb551" },
                    { "81ba8c59-389a-41a8-b5b7-15979e872374", "a1b2ea3e-233f-45b1-ae78-6d52ac3925ea" },
                    { "1e610396-57de-4a8a-a06d-d070f5dc70f5", "d7b2187b-a3b6-442e-b8dd-70ce72421fbe" }
                });
        }
    }
}
