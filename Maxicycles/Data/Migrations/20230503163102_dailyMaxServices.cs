using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class dailyMaxServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "DailyMaxServices",
                table: "Item",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22a236e6-013c-4c64-8499-c25f39d17a08", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "4c4b83b4-128a-4c34-8762-098ddb24e659", null, "Technician", "TECHNICIAN" },
                    { "5905122e-ace5-4c9c-a798-744e3487c110", null, "MediaManager", "MEDIAMANAGER" },
                    { "621e39d4-996f-4797-872e-6e8d1d6b0e52", null, "Customer", "CUSTOMER" },
                    { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", null, "StockControl", "STOCKCONTROL" },
                    { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a9c44fc-459c-44a7-aed0-c559ebcf01b8", 0, null, null, null, "89b9c50b-21d0-44c9-8574-73f174b3c009", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHOtb6ECDjrN4W0diFY0g6Z1LvXXEhvVD2VsHMiT1rsg22hBj0YELaqJJ0vrIRNe9g==", null, true, null, "c18e43ff-3d94-423e-a69a-852dbf7e8959", false, "accountsClerk@maxicycles.co.uk" },
                    { "94fb5237-1cc8-445e-b726-8b7892a9162e", 0, null, null, null, "ad57bf64-b4b9-42f5-9393-7af1fb697807", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMUT+pfDWnrNDjYt2WEE+82iaBdq7zdhtunSGOeyGtnuqrGysEnYMu3SIvsbIATmTA==", null, true, null, "d45da9fb-2341-4f4d-b22b-3fdff8dd8539", false, "stockControl@maxicycles.co.uk" },
                    { "a2928449-4ae1-4bab-9864-e0effe93d595", 0, null, null, null, "b53261f4-600e-431d-8da5-bc13147cd80e", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEMs8tGfSGZe5CSBsN/qqkf4IuVmkXPQbfdjpoah3aimiLVtSYDvC+StRjV0vq9qfkA==", null, true, null, "de47e1ac-7543-4f22-b29e-fddbde732c14", false, "customer@example.co.uk" },
                    { "a85aedf6-fc1a-45ed-ba3e-7026383e54cd", 0, null, null, null, "645a25c7-7072-4bf3-a46f-b95ae53f0195", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECdQy5Wyrg7auF8UokHBt2+7Hu2/HBG5zTwvOVM4CXIDJ5iUEinf+M+2x54/nylHyw==", null, true, null, "78f3f184-7f85-455e-9869-c4e707fd382a", false, "manager@maxicycles.co.uk" },
                    { "cc4f9203-b317-4127-9ae8-fd0a483696f0", 0, null, null, null, "3f64e1e3-c51d-458a-947d-afb0521e4016", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEFLIOqgStjUrdDuDXonG00yOtzEtwD3ft3rKvjV/dmfsVLMK+BIGxDlz+u1hS1/Knw==", null, true, null, "603887d3-01cc-40f3-a4e1-3afa7bfd3820", false, "technician@maxicycles.co.uk" },
                    { "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5", 0, null, null, null, "04efc441-3557-4780-926e-db876630ca30", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGM0I3+FBIoRA7e9pyYD6mDV/0L2wZQ7xrghYWDJekdyK/KHim8LpybpJsV6Fw7bpA==", null, true, null, "c0a8eb76-e2ca-4853-9ac0-2865f32909f1", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "22a236e6-013c-4c64-8499-c25f39d17a08", "0a9c44fc-459c-44a7-aed0-c559ebcf01b8" },
                    { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", "94fb5237-1cc8-445e-b726-8b7892a9162e" },
                    { "621e39d4-996f-4797-872e-6e8d1d6b0e52", "a2928449-4ae1-4bab-9864-e0effe93d595" },
                    { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", "a85aedf6-fc1a-45ed-ba3e-7026383e54cd" },
                    { "4c4b83b4-128a-4c34-8762-098ddb24e659", "cc4f9203-b317-4127-9ae8-fd0a483696f0" },
                    { "5905122e-ace5-4c9c-a798-744e3487c110", "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "22a236e6-013c-4c64-8499-c25f39d17a08", "0a9c44fc-459c-44a7-aed0-c559ebcf01b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afa21b43-4890-4054-bb7f-ea1ca3adaed8", "94fb5237-1cc8-445e-b726-8b7892a9162e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "621e39d4-996f-4797-872e-6e8d1d6b0e52", "a2928449-4ae1-4bab-9864-e0effe93d595" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef8ff52a-cb3f-4bce-8813-278cc6c23f27", "a85aedf6-fc1a-45ed-ba3e-7026383e54cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c4b83b4-128a-4c34-8762-098ddb24e659", "cc4f9203-b317-4127-9ae8-fd0a483696f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5905122e-ace5-4c9c-a798-744e3487c110", "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22a236e6-013c-4c64-8499-c25f39d17a08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4b83b4-128a-4c34-8762-098ddb24e659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5905122e-ace5-4c9c-a798-744e3487c110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "621e39d4-996f-4797-872e-6e8d1d6b0e52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa21b43-4890-4054-bb7f-ea1ca3adaed8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef8ff52a-cb3f-4bce-8813-278cc6c23f27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9c44fc-459c-44a7-aed0-c559ebcf01b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94fb5237-1cc8-445e-b726-8b7892a9162e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2928449-4ae1-4bab-9864-e0effe93d595");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a85aedf6-fc1a-45ed-ba3e-7026383e54cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc4f9203-b317-4127-9ae8-fd0a483696f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdfa7101-bfcc-441b-81e0-d9f68b6ef2c5");

            migrationBuilder.DropColumn(
                name: "DailyMaxServices",
                table: "Item");

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
        }
    }
}
