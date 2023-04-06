using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SubCategory_SubcategoryId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1be2c4a1-491a-44da-b50f-3d395eb1d23c", "2177d8a5-8353-4103-8cef-f425305c0a7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abc217a3-d42a-4786-9476-cbe1ff617652", "459df4f2-9342-4e69-bd73-85a2e7297a3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1f70282-d8d3-42c3-be50-4a1c31a7be6b", "4712336d-b41c-4b9e-abff-0f70eb9761cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "747c7a56-ffbf-4dd0-a041-aa3f9ba3fd7a", "958b4a67-0ffa-4f39-b640-1e87e6e48d7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d57af1d-a038-4d5d-8243-5a9e38faca90", "e25c3bee-a345-4fcd-80b3-8c01a8ebf5a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "585c1a4b-107f-47b0-9848-4d329a3b1083", "f468f8f5-b0d8-4816-94a2-4f0b92ef134d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d57af1d-a038-4d5d-8243-5a9e38faca90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1be2c4a1-491a-44da-b50f-3d395eb1d23c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "585c1a4b-107f-47b0-9848-4d329a3b1083");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "747c7a56-ffbf-4dd0-a041-aa3f9ba3fd7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc217a3-d42a-4786-9476-cbe1ff617652");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f70282-d8d3-42c3-be50-4a1c31a7be6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2177d8a5-8353-4103-8cef-f425305c0a7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "459df4f2-9342-4e69-bd73-85a2e7297a3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4712336d-b41c-4b9e-abff-0f70eb9761cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "958b4a67-0ffa-4f39-b640-1e87e6e48d7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e25c3bee-a345-4fcd-80b3-8c01a8ebf5a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f468f8f5-b0d8-4816-94a2-4f0b92ef134d");

            migrationBuilder.RenameColumn(
                name: "SubcategoryId",
                table: "Product",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SubcategoryId",
                table: "Product",
                newName: "IX_Product_SubCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product");

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

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Product",
                newName: "SubcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SubCategoryId",
                table: "Product",
                newName: "IX_Product_SubcategoryId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d57af1d-a038-4d5d-8243-5a9e38faca90", null, "Customer", "CUSTOMER" },
                    { "1be2c4a1-491a-44da-b50f-3d395eb1d23c", null, "StockControl", "STOCKCONTROL" },
                    { "585c1a4b-107f-47b0-9848-4d329a3b1083", null, "Manager", "MANAGER" },
                    { "747c7a56-ffbf-4dd0-a041-aa3f9ba3fd7a", null, "MediaManager", "MEDIAMANAGER" },
                    { "abc217a3-d42a-4786-9476-cbe1ff617652", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "d1f70282-d8d3-42c3-be50-4a1c31a7be6b", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2177d8a5-8353-4103-8cef-f425305c0a7d", 0, null, null, null, "099303ef-96b0-4b89-923f-5354169408ef", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEO2ORw6ae09j/ZpFe++hCD4U3Nwv+XKHsnDjd/PfT2y0tbxgcSqYaxryLccrffwhzA==", null, true, null, "a328d3a1-68a4-43b3-92d6-934c677283f3", false, "stockControl@maxicycles.co.uk" },
                    { "459df4f2-9342-4e69-bd73-85a2e7297a3e", 0, null, null, null, "c35ca44c-1313-423d-8868-bb463d2ddff8", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEjYpY7w5vx5bx3xP8PcUnYCHH7dRkeLHkwHwbxIeJVXRUdMoqaltfe27H+nqxVPSA==", null, true, null, "47daeeeb-a550-40ab-8b3a-1f53805aca99", false, "accountsClerk@maxicycles.co.uk" },
                    { "4712336d-b41c-4b9e-abff-0f70eb9761cf", 0, null, null, null, "2bce4ebf-b055-4582-80c7-d8e0761ba521", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECv5/kxw4BnNTjMr0+oZF6WsChxTQIbcmpGYaRftn2FoZjP94J2ly+O9Y0XnIRJD6w==", null, true, null, "50c9fab8-d176-4f0a-b2e7-9568a55af9a3", false, "technician@maxicycles.co.uk" },
                    { "958b4a67-0ffa-4f39-b640-1e87e6e48d7a", 0, null, null, null, "18eceadf-1cae-4547-86e9-238a4ceec82e", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAED+dYLeZq4sqDY9fvH5/8oHq8W1vqz/xdngyvFE6sd+ZnFKpQRA3LqY2MseUv8zSRA==", null, true, null, "829a7d79-84af-4b54-9474-dfe67dd5495b", false, "mediaManager@maxicycles.co.uk" },
                    { "e25c3bee-a345-4fcd-80b3-8c01a8ebf5a9", 0, null, null, null, "7a02c3c5-6711-4363-a6bd-3478b221a0d7", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAECidxMP+jCiTPoWzBxcprer/auwfyWoetqM3g2o4StfDjQLMGYrA21XxDcVVyV2A7g==", null, true, null, "6ec83703-ba80-40b8-826a-f3ab9b9a16c4", false, "customer@example.co.uk" },
                    { "f468f8f5-b0d8-4816-94a2-4f0b92ef134d", 0, null, null, null, "9cc4d2ac-d5b3-4e54-b352-5b6103c50e42", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDNc2qiJaOb9vu7RxPOsAuGrMD3m+hwUzWzEfvHu9LX6filncRXZAdQ9J4iHkciewA==", null, true, null, "c0473c32-6bda-403d-bf00-22a6ff9e6e96", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1be2c4a1-491a-44da-b50f-3d395eb1d23c", "2177d8a5-8353-4103-8cef-f425305c0a7d" },
                    { "abc217a3-d42a-4786-9476-cbe1ff617652", "459df4f2-9342-4e69-bd73-85a2e7297a3e" },
                    { "d1f70282-d8d3-42c3-be50-4a1c31a7be6b", "4712336d-b41c-4b9e-abff-0f70eb9761cf" },
                    { "747c7a56-ffbf-4dd0-a041-aa3f9ba3fd7a", "958b4a67-0ffa-4f39-b640-1e87e6e48d7a" },
                    { "0d57af1d-a038-4d5d-8243-5a9e38faca90", "e25c3bee-a345-4fcd-80b3-8c01a8ebf5a9" },
                    { "585c1a4b-107f-47b0-9848-4d329a3b1083", "f468f8f5-b0d8-4816-94a2-4f0b92ef134d" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubCategory_SubcategoryId",
                table: "Product",
                column: "SubcategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
