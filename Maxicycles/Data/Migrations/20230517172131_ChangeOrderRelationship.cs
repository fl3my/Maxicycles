using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOrderRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc7aafa-b44b-4fad-a67c-2888e0146738", "1af2e2e1-1557-4d70-8301-7a26c490e124" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd14969a-b0a2-43d4-beec-5630ac4a7265", "5970a0e7-1443-4931-be91-2a50b96dc8f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed3d4554-6f0f-43f9-b1f0-81c7260b168d", "92ad0f58-a9bb-4b46-bde4-f5f484c87095" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f184029-41a7-49e6-83c4-737e3e7c5c24", "c01907f7-5aa1-406e-845b-a387b53c1d70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e35efbf-0d34-4904-9481-bd55ee40c268", "ca2d2672-328e-4731-aa52-943742f87188" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4465a42-dbeb-4c8c-8b5f-791fa2ae2512", "d64d157f-6495-4fe8-ab2a-e7dcdff4c405" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e35efbf-0d34-4904-9481-bd55ee40c268");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f184029-41a7-49e6-83c4-737e3e7c5c24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4465a42-dbeb-4c8c-8b5f-791fa2ae2512");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc7aafa-b44b-4fad-a67c-2888e0146738");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3d4554-6f0f-43f9-b1f0-81c7260b168d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd14969a-b0a2-43d4-beec-5630ac4a7265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1af2e2e1-1557-4d70-8301-7a26c490e124");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5970a0e7-1443-4931-be91-2a50b96dc8f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92ad0f58-a9bb-4b46-bde4-f5f484c87095");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c01907f7-5aa1-406e-845b-a387b53c1d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca2d2672-328e-4731-aa52-943742f87188");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64d157f-6495-4fe8-ab2a-e7dcdff4c405");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryMethodId",
                table: "Orders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", null, "MediaManager", "MEDIAMANAGER" },
                    { "1654387a-e7a6-42ac-83ff-2624be5da03a", null, "Customer", "CUSTOMER" },
                    { "217b48cb-4f03-42ad-98e2-4f2603caff28", null, "StockControl", "STOCKCONTROL" },
                    { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", null, "Manager", "MANAGER" },
                    { "ba1c6898-02b9-4150-8f73-74f2662bca12", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13", 0, null, null, null, "a4ee9883-a98c-4908-8e50-2c54fda855bb", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEI/smUctNVXqHjgtf0B7NqYfSZjqqqUk5cFUukZzGCpliHWLanPbrwis/H3ZKWIZgA==", null, true, null, "d9148afd-6bb6-4af1-900e-8190e218fc74", false, "accountsClerk@maxicycles.co.uk" },
                    { "821b5523-a67b-476c-97d9-dbf5af4c47f1", 0, null, null, null, "701c9b00-2076-49b4-9436-4c8badfd0b90", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEM/T1uvXG/H7NNV29V1kM4vMo7F4Gq9j+ytIRw2yeH1bKafVgKs15SoicgfJjlTClg==", null, true, null, "6087e6e9-4d3c-4fc8-8a52-e4a57cc26eb2", false, "stockControl@maxicycles.co.uk" },
                    { "832038cc-bc69-4f5d-bb92-b36d3b52b648", 0, null, null, null, "1f1379b5-42ab-43c9-8ade-ca34347f9a26", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHvxwWocejN4DhuJA96adPmvo5EsNccu+QjEctOWfcpo2Bx9R922omEE50szOVjexw==", null, true, null, "2de60e93-0782-43ec-ab7f-960173ee8995", false, "mediaManager@maxicycles.co.uk" },
                    { "b4facbda-1dba-4778-b843-63e91e18abea", 0, null, null, null, "edcf8f00-d969-459e-a257-51ef5465cab1", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAENQWyKaTgXzSkZgbQLuQrx3k8/aSy1izdaV+0VZfs2+ovCOcvih3Fj4E5T/mIXj+Fg==", null, true, null, "55c06d30-f4e9-4416-8d30-7f91d029b27d", false, "manager@maxicycles.co.uk" },
                    { "bf983f96-ed70-4f53-bb70-a9338ae238e5", 0, null, null, null, "9cd218e9-7422-41f6-9f85-3f43286b77cd", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEBLPVDDLONtRDEambXYk9ueYWo+4+wRsaxlzvy1qqrbfhGa1KAB/i3xytOsjkeNKYA==", null, true, null, "babbb7fb-0021-4c33-b25d-0d239af94f31", false, "technician@maxicycles.co.uk" },
                    { "f55618c5-73cf-4187-b04b-68592d22bb90", 0, null, null, null, "8497258d-7b5c-402f-8cf9-6a6e90de7d65", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAECZ50ufVVAU1kmatDquh9zivxu/v6+zas7AQ/DVSpMKhlqxYQDGgQFhNNENk+MFDyw==", null, true, null, "7035a32a-b45a-49d8-bcab-a6c2187d0c6b", false, "customer@example.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba1c6898-02b9-4150-8f73-74f2662bca12", "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13" },
                    { "217b48cb-4f03-42ad-98e2-4f2603caff28", "821b5523-a67b-476c-97d9-dbf5af4c47f1" },
                    { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", "832038cc-bc69-4f5d-bb92-b36d3b52b648" },
                    { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", "b4facbda-1dba-4778-b843-63e91e18abea" },
                    { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", "bf983f96-ed70-4f53-bb70-a9338ae238e5" },
                    { "1654387a-e7a6-42ac-83ff-2624be5da03a", "f55618c5-73cf-4187-b04b-68592d22bb90" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                table: "Orders",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba1c6898-02b9-4150-8f73-74f2662bca12", "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "217b48cb-4f03-42ad-98e2-4f2603caff28", "821b5523-a67b-476c-97d9-dbf5af4c47f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc", "832038cc-bc69-4f5d-bb92-b36d3b52b648" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be", "b4facbda-1dba-4778-b843-63e91e18abea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9174668-8cd8-4ae7-bf65-c0ffe6228238", "bf983f96-ed70-4f53-bb70-a9338ae238e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1654387a-e7a6-42ac-83ff-2624be5da03a", "f55618c5-73cf-4187-b04b-68592d22bb90" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed05df6-7e19-48d2-8fb4-0ba8b06460bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1654387a-e7a6-42ac-83ff-2624be5da03a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "217b48cb-4f03-42ad-98e2-4f2603caff28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28875a7b-0195-4f9a-bd77-c9ecb3ecf9be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba1c6898-02b9-4150-8f73-74f2662bca12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9174668-8cd8-4ae7-bf65-c0ffe6228238");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27bb2d0d-9cdc-45b6-b6b1-6a308a22cc13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "821b5523-a67b-476c-97d9-dbf5af4c47f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832038cc-bc69-4f5d-bb92-b36d3b52b648");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4facbda-1dba-4778-b843-63e91e18abea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf983f96-ed70-4f53-bb70-a9338ae238e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f55618c5-73cf-4187-b04b-68592d22bb90");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryMethodId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e35efbf-0d34-4904-9481-bd55ee40c268", null, "Customer", "CUSTOMER" },
                    { "0f184029-41a7-49e6-83c4-737e3e7c5c24", null, "StockControl", "STOCKCONTROL" },
                    { "d4465a42-dbeb-4c8c-8b5f-791fa2ae2512", null, "Technician", "TECHNICIAN" },
                    { "ddc7aafa-b44b-4fad-a67c-2888e0146738", null, "Manager", "MANAGER" },
                    { "ed3d4554-6f0f-43f9-b1f0-81c7260b168d", null, "MediaManager", "MEDIAMANAGER" },
                    { "fd14969a-b0a2-43d4-beec-5630ac4a7265", null, "AccountsClerk", "ACCOUNTSCLERK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1af2e2e1-1557-4d70-8301-7a26c490e124", 0, null, null, null, "6fa76911-88fc-4cbe-a48b-b2b09427f5ad", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGAbFLap6IuWV9xMLZBoNsp4mEHqnJenj5Fcx9SXoGPfjbtOspafqcNGV9gePHjZrQ==", null, true, null, "02ddaff2-d6d7-4318-814e-a54be8ef4c3c", false, "manager@maxicycles.co.uk" },
                    { "5970a0e7-1443-4931-be91-2a50b96dc8f6", 0, null, null, null, "2251c596-9078-4eed-b88c-8abedaf61220", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECii8zyzwswUKFMrvyV4ZgHNADsjgWFLXXChVx5HYbcZoCe1UYYWu06clTe84Hk7vQ==", null, true, null, "38817149-74d8-48f1-8a50-cd54d17af3f8", false, "accountsClerk@maxicycles.co.uk" },
                    { "92ad0f58-a9bb-4b46-bde4-f5f484c87095", 0, null, null, null, "f959677b-04a7-4112-bdbd-a7b324d71d91", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEG2ATdBz70gY+UZ5fl28IpYmH5ctrCxBAt6Zy4hzLhOdQwX394I337RKUi6P7tWPWQ==", null, true, null, "b6c5f6e0-2bc9-4d8d-8bc7-e90e1aea8a90", false, "mediaManager@maxicycles.co.uk" },
                    { "c01907f7-5aa1-406e-845b-a387b53c1d70", 0, null, null, null, "664f963f-e9bd-485f-8ded-a5e0ad819368", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMl2+wbE4s0GUf7dGZ0XGAQGwzqKvk0Py0ZVKuuu2VLT2ItYYqU7rgfMbUcaJ9devg==", null, true, null, "96b3ef85-7f78-4e85-a88c-2b919e4b953f", false, "stockControl@maxicycles.co.uk" },
                    { "ca2d2672-328e-4731-aa52-943742f87188", 0, null, null, null, "f6866d92-95e1-40bb-bccb-4c6efb5fa898", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEHHcI8q1IX5z/7N2TgBiduUMArxNGEGSxNZKXSmVamyiyVooySeX6CTTSlp09omuMw==", null, true, null, "854af8b4-a602-4478-a939-ba605f801221", false, "customer@example.co.uk" },
                    { "d64d157f-6495-4fe8-ab2a-e7dcdff4c405", 0, null, null, null, "a597c710-fc54-46fe-8d46-649961961f49", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJ66eZqh8HgujLyFlcxusa2eVkx9jkUkTzUSZ7s7RmqbE3l73tsWm4/JSiYMn0tQ7g==", null, true, null, "d96ba95f-7705-49e9-bbcf-12fe64a5622b", false, "technician@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ddc7aafa-b44b-4fad-a67c-2888e0146738", "1af2e2e1-1557-4d70-8301-7a26c490e124" },
                    { "fd14969a-b0a2-43d4-beec-5630ac4a7265", "5970a0e7-1443-4931-be91-2a50b96dc8f6" },
                    { "ed3d4554-6f0f-43f9-b1f0-81c7260b168d", "92ad0f58-a9bb-4b46-bde4-f5f484c87095" },
                    { "0f184029-41a7-49e6-83c4-737e3e7c5c24", "c01907f7-5aa1-406e-845b-a387b53c1d70" },
                    { "0e35efbf-0d34-4904-9481-bd55ee40c268", "ca2d2672-328e-4731-aa52-943742f87188" },
                    { "d4465a42-dbeb-4c8c-8b5f-791fa2ae2512", "d64d157f-6495-4fe8-ab2a-e7dcdff4c405" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryMethods_DeliveryMethodId",
                table: "Orders",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
