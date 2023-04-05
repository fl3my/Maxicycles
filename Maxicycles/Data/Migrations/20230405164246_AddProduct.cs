using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "732eda97-05cd-4d19-b9f9-9a23c0b1f4ac", "00004208-8a1a-4c7a-aef4-cf7df1a3e2d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2ba1dc2-4150-4faf-a115-eafe065cf18c", "07e7f470-af01-426e-9b10-9cde67dc1d2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27a2524e-17f2-4c39-8005-e0ad4b53241e", "4b534a72-dc0a-48c7-abfd-eb09ac139273" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8bd43fe8-c2e1-41ce-8b8e-19add7f32922", "9fce035b-d423-406a-91f0-4486e6345582" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "511951db-c20a-45c0-af28-817901b8af0e", "aca4f973-9729-4bbc-8e37-06f7d8704352" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c99917ad-cea7-4f90-9785-1cfbd87af7eb", "c4b18d03-b3ea-41eb-bd23-403e572cc529" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27a2524e-17f2-4c39-8005-e0ad4b53241e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "511951db-c20a-45c0-af28-817901b8af0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "732eda97-05cd-4d19-b9f9-9a23c0b1f4ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bd43fe8-c2e1-41ce-8b8e-19add7f32922");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c99917ad-cea7-4f90-9785-1cfbd87af7eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2ba1dc2-4150-4faf-a115-eafe065cf18c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00004208-8a1a-4c7a-aef4-cf7df1a3e2d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e7f470-af01-426e-9b10-9cde67dc1d2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b534a72-dc0a-48c7-abfd-eb09ac139273");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fce035b-d423-406a-91f0-4486e6345582");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aca4f973-9729-4bbc-8e37-06f7d8704352");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4b18d03-b3ea-41eb-bd23-403e572cc529");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    SubcategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubcategoryId",
                table: "Product",
                column: "SubcategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27a2524e-17f2-4c39-8005-e0ad4b53241e", null, "MediaManager", "MEDIAMANAGER" },
                    { "511951db-c20a-45c0-af28-817901b8af0e", null, "StockControl", "STOCKCONTROL" },
                    { "732eda97-05cd-4d19-b9f9-9a23c0b1f4ac", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "8bd43fe8-c2e1-41ce-8b8e-19add7f32922", null, "Technician", "TECHNICIAN" },
                    { "c99917ad-cea7-4f90-9785-1cfbd87af7eb", null, "Manager", "MANAGER" },
                    { "e2ba1dc2-4150-4faf-a115-eafe065cf18c", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00004208-8a1a-4c7a-aef4-cf7df1a3e2d8", 0, null, null, null, "2424e15a-883e-4764-a12b-4e1199fc4acf", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJxfnFsxWqDz49lvqY45JOM3jTunT6O7RKlf8kLaqIHm5r26g/2Vo6oQW/FJe29Bvg==", null, true, null, "a244c47c-1fbf-4713-80db-27f9b1030f61", false, "accountsClerk@maxicycles.co.uk" },
                    { "07e7f470-af01-426e-9b10-9cde67dc1d2e", 0, null, null, null, "ebcfa551-ef20-4c37-b494-9d6d91ae00d6", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEJRxOmDn/oiZVD5aPKAVOEjmngtoEXgb3KTspASOWLXBDGuyeANCNwTnCO0VY+ClXQ==", null, true, null, "fa4181bb-22a5-47ff-953f-6e42e0baa386", false, "customer@example.co.uk" },
                    { "4b534a72-dc0a-48c7-abfd-eb09ac139273", 0, null, null, null, "f72afbac-8dff-4bdb-89cb-86dd2fbde4c3", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKsX9ZDmO+1Zg9xaQwnqfp0bczWte2uKVBTkBVAym9ZjTrEsxSlyh39Ts7RxVFZ76w==", null, true, null, "07afcc20-03e1-469a-990b-17e37a926223", false, "mediaManager@maxicycles.co.uk" },
                    { "9fce035b-d423-406a-91f0-4486e6345582", 0, null, null, null, "c2582732-fa9f-45ad-91f5-666fd5cbcedf", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEaY4z99LkzKy/C4QlolOiAk6dWZ6ePcfnhAMpxwzc8K3NSLxp77tg4//EdTpklJAw==", null, true, null, "1384ef21-6982-4b4e-ab69-cd9380c7cb77", false, "technician@maxicycles.co.uk" },
                    { "aca4f973-9729-4bbc-8e37-06f7d8704352", 0, null, null, null, "f1626818-efad-4ff2-9cd3-8ae67cdd50c6", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPW5yNHhnDhZ+k/EVS7AzrCvSZiwKzdwumqHh3FxKQyWXl5HngFR+vhDGHfs6feUMA==", null, true, null, "5faa0222-2148-4ca0-8277-deb79032f059", false, "stockControl@maxicycles.co.uk" },
                    { "c4b18d03-b3ea-41eb-bd23-403e572cc529", 0, null, null, null, "863732d7-c243-405e-8375-58a49f78ce56", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHjMA1MHpD5Ysa/ohMVAY0V9YlkIwcuK5AtG+f5aZlkhgyZJDsp5a9OntNsx8qzBkg==", null, true, null, "1a472709-578b-4b78-840d-b3570f517bff", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "732eda97-05cd-4d19-b9f9-9a23c0b1f4ac", "00004208-8a1a-4c7a-aef4-cf7df1a3e2d8" },
                    { "e2ba1dc2-4150-4faf-a115-eafe065cf18c", "07e7f470-af01-426e-9b10-9cde67dc1d2e" },
                    { "27a2524e-17f2-4c39-8005-e0ad4b53241e", "4b534a72-dc0a-48c7-abfd-eb09ac139273" },
                    { "8bd43fe8-c2e1-41ce-8b8e-19add7f32922", "9fce035b-d423-406a-91f0-4486e6345582" },
                    { "511951db-c20a-45c0-af28-817901b8af0e", "aca4f973-9729-4bbc-8e37-06f7d8704352" },
                    { "c99917ad-cea7-4f90-9785-1cfbd87af7eb", "c4b18d03-b3ea-41eb-bd23-403e572cc529" }
                });
        }
    }
}
