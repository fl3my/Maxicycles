using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoryAndSubCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6423f41-1702-44ad-bcb7-c06da436bd02", "4d684e06-c9fb-49d1-8608-182dc27142e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d33ffb99-8e00-4ac9-ae63-e55f638146c8", "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91e9e727-bd11-45ff-a743-bb7767780b71", "4f505b27-1e2c-4236-aed3-499051f806b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2c31d48-35ce-4ee6-b26a-1e79cfa64549", "588e6e14-da69-44fc-9eef-51f7af88f77e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b20d1672-a71d-4fbe-8e67-8d1607002866", "969aeccd-77a5-4158-98fd-362298815d7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e", "97ff7bcb-8f73-4899-9697-0c35692a3ccb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91e9e727-bd11-45ff-a743-bb7767780b71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20d1672-a71d-4fbe-8e67-8d1607002866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d33ffb99-8e00-4ac9-ae63-e55f638146c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2c31d48-35ce-4ee6-b26a-1e79cfa64549");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6423f41-1702-44ad-bcb7-c06da436bd02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d684e06-c9fb-49d1-8608-182dc27142e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f505b27-1e2c-4236-aed3-499051f806b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "588e6e14-da69-44fc-9eef-51f7af88f77e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "969aeccd-77a5-4158-98fd-362298815d7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97ff7bcb-8f73-4899-9697-0c35692a3ccb");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Category");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91e9e727-bd11-45ff-a743-bb7767780b71", null, "Customer", "CUSTOMER" },
                    { "b20d1672-a71d-4fbe-8e67-8d1607002866", null, "Technician", "TECHNICIAN" },
                    { "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e", null, "StockControl", "STOCKCONTROL" },
                    { "d33ffb99-8e00-4ac9-ae63-e55f638146c8", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "e2c31d48-35ce-4ee6-b26a-1e79cfa64549", null, "MediaManager", "MEDIAMANAGER" },
                    { "f6423f41-1702-44ad-bcb7-c06da436bd02", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4d684e06-c9fb-49d1-8608-182dc27142e5", 0, null, null, null, "3f0c3624-99d5-4405-8edd-04a95e95da98", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPxB+pfgfG7FxSXkJU4DkF/KifPXaX9bBCB9TIir73/8knmT+Q8IO0leH0NOVuGGwg==", null, true, null, "310c3cb4-dfbb-4c9d-a3a9-d9d7d023690f", false, "manager@maxicycles.co.uk" },
                    { "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf", 0, null, null, null, "09f899b2-fa95-40a2-be1f-514e2f53ac8d", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAENZPlQNg0Ueo0geazLLRVkhXhB75lIsgo5+NMAD5td/SzLSY3W3iNUaUyIv88EsOTA==", null, true, null, "21f1cb1e-9824-425d-90a8-0ec32a5463ef", false, "accountsClerk@maxicycles.co.uk" },
                    { "4f505b27-1e2c-4236-aed3-499051f806b7", 0, null, null, null, "ed96f118-f730-4e04-8cc7-b06bed275a94", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEN/0BDItfSE83ea1tz8Ud0jDcs+BLJSY1auoPsyTwO0jn21xFfHMuceRmW8j3huvhg==", null, true, null, "9bfe7987-07c5-4b11-8b53-2a55188269d1", false, "customer@example.co.uk" },
                    { "588e6e14-da69-44fc-9eef-51f7af88f77e", 0, null, null, null, "27a21972-89c0-4c3d-81ac-9d7266726b59", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPoPvgI9KYFI1AUooA2kNx4oOhqVQv7oE3oBnbr/rjMp37ew8BbsYOnLXaecBxfYag==", null, true, null, "73095fe1-72f1-4292-888f-bb927fed6d87", false, "mediaManager@maxicycles.co.uk" },
                    { "969aeccd-77a5-4158-98fd-362298815d7f", 0, null, null, null, "8a75b0bb-e9f1-4a4d-b262-90b20c3b5444", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKO4hVlaLbH7LuVYbKw0BYefRITXxMCU8Kh56o13y95igmbgh7bes5ox/d6Ak7DzXg==", null, true, null, "f9578329-caa3-4c2c-8d7f-a0e795e7e248", false, "technician@maxicycles.co.uk" },
                    { "97ff7bcb-8f73-4899-9697-0c35692a3ccb", 0, null, null, null, "774f1732-7707-4811-9372-9ef6af29e52e", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEC8BxZg+b75zaNAUeA/oyyuEyEsj0i/LBTJqhgeTYwD2vKi/xLv68bwvycIfZUwAlA==", null, true, null, "a22e4d5d-feb0-4501-bc3f-f5b5cfc0338e", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6423f41-1702-44ad-bcb7-c06da436bd02", "4d684e06-c9fb-49d1-8608-182dc27142e5" },
                    { "d33ffb99-8e00-4ac9-ae63-e55f638146c8", "4e87c5ae-7fea-4f44-ac7b-a894a03a9dcf" },
                    { "91e9e727-bd11-45ff-a743-bb7767780b71", "4f505b27-1e2c-4236-aed3-499051f806b7" },
                    { "e2c31d48-35ce-4ee6-b26a-1e79cfa64549", "588e6e14-da69-44fc-9eef-51f7af88f77e" },
                    { "b20d1672-a71d-4fbe-8e67-8d1607002866", "969aeccd-77a5-4158-98fd-362298815d7f" },
                    { "b2dc4fed-4016-48ff-ac49-cf11b1c8c27e", "97ff7bcb-8f73-4899-9697-0c35692a3ccb" }
                });
        }
    }
}
