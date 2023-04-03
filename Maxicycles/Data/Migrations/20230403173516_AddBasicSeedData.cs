using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBasicSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
