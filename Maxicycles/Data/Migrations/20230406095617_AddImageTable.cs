using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e37183a5-3e8b-4fe2-a345-5adba6875291", "01239541-bb62-4795-a274-751a765f7b91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bc6099b-4beb-42a3-97c9-dde0d7f52463", "0c97a4ce-9599-40e8-9e9f-049412b33eee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24de28c4-22e5-46f4-a839-7ae36a55b380", "649645e4-cdfd-448e-960f-c506a72f6186" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "16ab2839-40d9-43ce-9694-f51cf0f7c192", "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac67caff-32b6-432a-8a1f-bd0814587590", "9baf8e49-2ce1-4dfb-a624-2cee4c007971" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d10ac94-9669-4cd4-8d3e-251ea4c4869f", "d468a07f-4262-4e4a-a595-dc3a5e146d5d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16ab2839-40d9-43ce-9694-f51cf0f7c192");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24de28c4-22e5-46f4-a839-7ae36a55b380");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d10ac94-9669-4cd4-8d3e-251ea4c4869f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bc6099b-4beb-42a3-97c9-dde0d7f52463");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac67caff-32b6-432a-8a1f-bd0814587590");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e37183a5-3e8b-4fe2-a345-5adba6875291");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01239541-bb62-4795-a274-751a765f7b91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c97a4ce-9599-40e8-9e9f-049412b33eee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "649645e4-cdfd-448e-960f-c506a72f6186");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9baf8e49-2ce1-4dfb-a624-2cee4c007971");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d468a07f-4262-4e4a-a595-dc3a5e146d5d");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    ImageName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_ImageId",
                table: "Product",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Image_ImageId",
                table: "Product",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Image_ImageId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Product_ImageId",
                table: "Product");

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

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Product");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16ab2839-40d9-43ce-9694-f51cf0f7c192", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "24de28c4-22e5-46f4-a839-7ae36a55b380", null, "MediaManager", "MEDIAMANAGER" },
                    { "7d10ac94-9669-4cd4-8d3e-251ea4c4869f", null, "Manager", "MANAGER" },
                    { "9bc6099b-4beb-42a3-97c9-dde0d7f52463", null, "Technician", "TECHNICIAN" },
                    { "ac67caff-32b6-432a-8a1f-bd0814587590", null, "Customer", "CUSTOMER" },
                    { "e37183a5-3e8b-4fe2-a345-5adba6875291", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01239541-bb62-4795-a274-751a765f7b91", 0, null, null, null, "7618fdd0-7851-4253-9407-c00ef4413998", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECMQsDGmAoqJ0V/9FfOB+b1uWngTZMdMkMOaNU7qgDE0WkxUOYONZOKy856qRfey7A==", null, true, null, "66cd2236-15da-4d75-ae3f-d312e8577709", false, "stockControl@maxicycles.co.uk" },
                    { "0c97a4ce-9599-40e8-9e9f-049412b33eee", 0, null, null, null, "ac9bfe48-82f8-476b-84f9-eb6a4962aeab", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDMsAHNrIcnguF5xa53P63KkcScZ0XoOrrbiKcjoSMi8VKimOOCi9vjJr8HdP3Ia/w==", null, true, null, "33c5ec47-c9c5-455b-ad23-abd97df2e43a", false, "technician@maxicycles.co.uk" },
                    { "649645e4-cdfd-448e-960f-c506a72f6186", 0, null, null, null, "1df6639c-855d-420b-a4a6-6fff61b3683c", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKtQXfZdLUDxQNEm4gBESyWUMo/JwNvf+0vCHrmBF98m3Y3u1w2LS7Jh3XUJG2JfQw==", null, true, null, "441cae6c-f2be-402e-85e3-79054eb65bcd", false, "mediaManager@maxicycles.co.uk" },
                    { "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb", 0, null, null, null, "96d875a4-9421-44f6-a3d3-99bce7cdc5e0", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECRifxvCUE57LFwwSxtFomqgEgLmCsiVTNkVHhXDsPJk20x2HkDeciUT9I/7dPcQ7w==", null, true, null, "d74e4cdd-0f0c-4126-ab2f-343c2257bccc", false, "accountsClerk@maxicycles.co.uk" },
                    { "9baf8e49-2ce1-4dfb-a624-2cee4c007971", 0, null, null, null, "d03263ed-1d7a-4b86-a78c-c6affab790ee", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEGSL8zn9qay081agLn1PdrEPYcdHSFd1D8IiNgVr3kl7TC9D9aSblHw5cdN7kJYMGg==", null, true, null, "8852c8fa-ab07-49a8-991d-eca92e76292d", false, "customer@example.co.uk" },
                    { "d468a07f-4262-4e4a-a595-dc3a5e146d5d", 0, null, null, null, "f2e039f7-e014-4b30-bc98-ee3b79e726ad", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJjfBxjVbnsmKWCb9IT/SBlomjpbm0MmZ7xUTFmwjfBCWTj9Jo8w45nflTE/a6RpPA==", null, true, null, "a33e8ac2-feb1-443b-9f1f-77a8cd47e7d5", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e37183a5-3e8b-4fe2-a345-5adba6875291", "01239541-bb62-4795-a274-751a765f7b91" },
                    { "9bc6099b-4beb-42a3-97c9-dde0d7f52463", "0c97a4ce-9599-40e8-9e9f-049412b33eee" },
                    { "24de28c4-22e5-46f4-a839-7ae36a55b380", "649645e4-cdfd-448e-960f-c506a72f6186" },
                    { "16ab2839-40d9-43ce-9694-f51cf0f7c192", "8e0ea4e8-926c-4291-b6f2-0a2defddf7bb" },
                    { "ac67caff-32b6-432a-8a1f-bd0814587590", "9baf8e49-2ce1-4dfb-a624-2cee4c007971" },
                    { "7d10ac94-9669-4cd4-8d3e-251ea4c4869f", "d468a07f-4262-4e4a-a595-dc3a5e146d5d" }
                });
        }
    }
}
