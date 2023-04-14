using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Image_ImageId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "129ef3ac-e6e8-42c1-812b-a7818847a291", "15817b5e-5f35-405b-b597-8833d5cdaf97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3617116d-7478-40c5-9b55-ee76a168dbbd", "2975da83-2f4a-4dd9-9cba-3ef05458d06c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d34a2bfa-c7ac-4637-b907-e6ab12d02616", "4826daca-d5e6-4ea8-8146-d990ad0b0121" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e237cc6b-ef44-4f9f-af0d-7ab8b021c93d", "73075082-f0fc-4c62-a700-4bac9490f6ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7990ba52-d4b3-4c5c-a22a-a801ebf61c76", "df1aaadb-a8d5-46b4-a642-e84601fa8e5d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc5e4c67-36c1-44b4-a1b7-c3fa8122672c", "f86e58e4-7aa9-4320-aa53-89f36104e70b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "129ef3ac-e6e8-42c1-812b-a7818847a291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3617116d-7478-40c5-9b55-ee76a168dbbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7990ba52-d4b3-4c5c-a22a-a801ebf61c76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc5e4c67-36c1-44b4-a1b7-c3fa8122672c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d34a2bfa-c7ac-4637-b907-e6ab12d02616");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e237cc6b-ef44-4f9f-af0d-7ab8b021c93d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15817b5e-5f35-405b-b597-8833d5cdaf97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2975da83-2f4a-4dd9-9cba-3ef05458d06c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4826daca-d5e6-4ea8-8146-d990ad0b0121");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73075082-f0fc-4c62-a700-4bac9490f6ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df1aaadb-a8d5-46b4-a642-e84601fa8e5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f86e58e4-7aa9-4320-aa53-89f36104e70b");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SubCategoryId",
                table: "Item",
                newName: "IX_Item_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ImageId",
                table: "Item",
                newName: "IX_Item_ImageId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Item",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Item",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Item",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Item",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Item",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fa55a41-8b2b-4d96-983c-06b8fca14986", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "8f37aa59-95a5-4671-95bc-c2fec36733fa", null, "Customer", "CUSTOMER" },
                    { "c98ea3be-cdfb-4661-83da-bb2cc45b40a9", null, "Manager", "MANAGER" },
                    { "cb851369-8a3b-4a45-9819-ae081df08344", null, "StockControl", "STOCKCONTROL" },
                    { "d7106305-da8b-45d7-8a10-e8693c069bab", null, "Technician", "TECHNICIAN" },
                    { "f96dea24-ffff-454c-9827-77c021c3ffbd", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "044081eb-b723-42a9-88b2-4dced2a94a5e", 0, null, null, null, "790c5d7a-95aa-4d0c-baa6-f922f01bdf5a", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAELVCB88oaNrfCSyjdpTCXJvSKDBm7wf13QZ6AlUnDy4EAUl5Kii1Ma6zLigLk4EWVA==", null, true, null, "81e475b0-51bd-4888-8641-4da8235d44c6", false, "customer@example.co.uk" },
                    { "11e75c91-e496-4597-84eb-17d21f6a7ad5", 0, null, null, null, "08a763a7-8320-4520-bfc4-e4ac6332cacd", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGnZkkgzVkxqeYg/WC3GkFwDO5ZCJTXtRsjKVF1/jMLGTSi7bm91YMw9vx63X/qL2w==", null, true, null, "5d22a72c-5a6f-4d59-b542-429ccdaaa31f", false, "accountsClerk@maxicycles.co.uk" },
                    { "23ba5a85-fde3-48b3-b1f9-afda76d77f78", 0, null, null, null, "9db10d7e-84b1-48cc-84b1-edfd32c36a98", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAENA5ix56LSErDi/JiQCxpoLitQSfi65LrjqQ/Qfg3SK2cg468DWZ4OAZ22Rw9oKZ8w==", null, true, null, "a8e944e0-f83f-4b0a-a9f7-4366c705643e", false, "manager@maxicycles.co.uk" },
                    { "2a6433be-959d-44c8-91be-013087a4d655", 0, null, null, null, "99844f95-61b9-4304-adf1-f517bf8e3b86", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEG+3moNTSPGR0HVLDeKZEGrBCqgSl4DmYk0Rm5DBFrVm3Xi03bRz6ree5h0dIzSwmA==", null, true, null, "c2ef5b7d-b964-4be3-aa67-66d7469ae408", false, "stockControl@maxicycles.co.uk" },
                    { "678de816-8d7c-4cae-91bc-1b1232c108da", 0, null, null, null, "f9663902-1053-4d78-a5ca-8b695aba8268", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJW6fx50VWeDEkT+k2/HwIomjz8xQTrXnCBz5T0Q5RMCh+Pdjb6kc/2PbpgxRbuG/Q==", null, true, null, "fefabd1c-653a-426f-aab0-3f7ff32123e8", false, "mediaManager@maxicycles.co.uk" },
                    { "7814a923-0a89-40d8-96ee-a4c9533fb175", 0, null, null, null, "89d249c6-8dec-4cee-903e-2e480d180c5d", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEwTyr9EbbESVtc4ODMyUG2ncL5218IK/EN+UDGKwA6GVviyLRgLqOSey3mP+roVNQ==", null, true, null, "c2ad8e38-2cf5-41fe-80f3-3be15a6fe4aa", false, "technician@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8f37aa59-95a5-4671-95bc-c2fec36733fa", "044081eb-b723-42a9-88b2-4dced2a94a5e" },
                    { "5fa55a41-8b2b-4d96-983c-06b8fca14986", "11e75c91-e496-4597-84eb-17d21f6a7ad5" },
                    { "c98ea3be-cdfb-4661-83da-bb2cc45b40a9", "23ba5a85-fde3-48b3-b1f9-afda76d77f78" },
                    { "cb851369-8a3b-4a45-9819-ae081df08344", "2a6433be-959d-44c8-91be-013087a4d655" },
                    { "f96dea24-ffff-454c-9827-77c021c3ffbd", "678de816-8d7c-4cae-91bc-1b1232c108da" },
                    { "d7106305-da8b-45d7-8a10-e8693c069bab", "7814a923-0a89-40d8-96ee-a4c9533fb175" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Image_ImageId",
                table: "Item",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_SubCategory_SubCategoryId",
                table: "Item",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Image_ImageId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_SubCategory_SubCategoryId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f37aa59-95a5-4671-95bc-c2fec36733fa", "044081eb-b723-42a9-88b2-4dced2a94a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fa55a41-8b2b-4d96-983c-06b8fca14986", "11e75c91-e496-4597-84eb-17d21f6a7ad5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c98ea3be-cdfb-4661-83da-bb2cc45b40a9", "23ba5a85-fde3-48b3-b1f9-afda76d77f78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb851369-8a3b-4a45-9819-ae081df08344", "2a6433be-959d-44c8-91be-013087a4d655" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f96dea24-ffff-454c-9827-77c021c3ffbd", "678de816-8d7c-4cae-91bc-1b1232c108da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7106305-da8b-45d7-8a10-e8693c069bab", "7814a923-0a89-40d8-96ee-a4c9533fb175" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fa55a41-8b2b-4d96-983c-06b8fca14986");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f37aa59-95a5-4671-95bc-c2fec36733fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c98ea3be-cdfb-4661-83da-bb2cc45b40a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb851369-8a3b-4a45-9819-ae081df08344");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7106305-da8b-45d7-8a10-e8693c069bab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f96dea24-ffff-454c-9827-77c021c3ffbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "044081eb-b723-42a9-88b2-4dced2a94a5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11e75c91-e496-4597-84eb-17d21f6a7ad5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23ba5a85-fde3-48b3-b1f9-afda76d77f78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6433be-959d-44c8-91be-013087a4d655");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "678de816-8d7c-4cae-91bc-1b1232c108da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7814a923-0a89-40d8-96ee-a4c9533fb175");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Item_SubCategoryId",
                table: "Product",
                newName: "IX_Product_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ImageId",
                table: "Product",
                newName: "IX_Product_ImageId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Product",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "129ef3ac-e6e8-42c1-812b-a7818847a291", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "3617116d-7478-40c5-9b55-ee76a168dbbd", null, "MediaManager", "MEDIAMANAGER" },
                    { "7990ba52-d4b3-4c5c-a22a-a801ebf61c76", null, "Customer", "CUSTOMER" },
                    { "cc5e4c67-36c1-44b4-a1b7-c3fa8122672c", null, "StockControl", "STOCKCONTROL" },
                    { "d34a2bfa-c7ac-4637-b907-e6ab12d02616", null, "Manager", "MANAGER" },
                    { "e237cc6b-ef44-4f9f-af0d-7ab8b021c93d", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15817b5e-5f35-405b-b597-8833d5cdaf97", 0, null, null, null, "2b065bf4-f55f-43fb-b134-e07eb641a583", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHF0f2S3jdSB99pCkxNd4s+k6wClPfLmV7JKBUTBekc8LrEJxcHW6xCAyfR/8q0ZDA==", null, true, null, "057294c2-bb15-493a-b8d0-f1501c9b0039", false, "accountsClerk@maxicycles.co.uk" },
                    { "2975da83-2f4a-4dd9-9cba-3ef05458d06c", 0, null, null, null, "6e45a017-0be8-4bf2-902a-6001f74385a2", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELb3QYC2jvjcANJMUcQV68wuW3Yr9tNX5ymMeqhG2rLQGNdQ0FVVnGoQ9o9dOxojbg==", null, true, null, "e2402d7f-c359-4911-8f17-6a7e9672e932", false, "mediaManager@maxicycles.co.uk" },
                    { "4826daca-d5e6-4ea8-8146-d990ad0b0121", 0, null, null, null, "5742baab-75f6-466e-ac02-98e95a1b75e5", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEpPvYeuLTXhEiKNbOKaxPaE/H7IUJITdRv6tU8y0PSnMfZh07ygIfPpBfi1ZvlfEg==", null, true, null, "9a7cc61a-4d5c-41ee-8817-ee77efd698c9", false, "manager@maxicycles.co.uk" },
                    { "73075082-f0fc-4c62-a700-4bac9490f6ea", 0, null, null, null, "4357acc4-a196-4ccb-be4e-af09eb36959a", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHr7L6OMtjPQQ7pmThZn6UUQnXANwl0CLoIfzsPOCL7TaUZOdU5T4rs71+3A+VxL5g==", null, true, null, "e0b5275c-859b-4b36-a8fc-267edcc02c97", false, "technician@maxicycles.co.uk" },
                    { "df1aaadb-a8d5-46b4-a642-e84601fa8e5d", 0, null, null, null, "5118488b-5063-40b0-82ce-38d00c7924dd", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEP5zfz/d1djAIDY9j6FzKBtnTUv3k/VnwbPi1HL4he6F3i35w/p8KwnC6D5SZb9zNA==", null, true, null, "1b6d0fd2-9bac-44a2-9ffa-f935f12b43dd", false, "customer@example.co.uk" },
                    { "f86e58e4-7aa9-4320-aa53-89f36104e70b", 0, null, null, null, "ddfd9ae6-bbd4-4170-b4a6-5336935196eb", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEPo+F8RvLbDfSFkMnx3yg/AU7XSt9XWiTGj9iGELkEkdXRI6GCoQpYKxznN5m0TJtA==", null, true, null, "e6b19826-b7e2-4d9d-8409-03f9d064d597", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "129ef3ac-e6e8-42c1-812b-a7818847a291", "15817b5e-5f35-405b-b597-8833d5cdaf97" },
                    { "3617116d-7478-40c5-9b55-ee76a168dbbd", "2975da83-2f4a-4dd9-9cba-3ef05458d06c" },
                    { "d34a2bfa-c7ac-4637-b907-e6ab12d02616", "4826daca-d5e6-4ea8-8146-d990ad0b0121" },
                    { "e237cc6b-ef44-4f9f-af0d-7ab8b021c93d", "73075082-f0fc-4c62-a700-4bac9490f6ea" },
                    { "7990ba52-d4b3-4c5c-a22a-a801ebf61c76", "df1aaadb-a8d5-46b4-a642-e84601fa8e5d" },
                    { "cc5e4c67-36c1-44b4-a1b7-c3fa8122672c", "f86e58e4-7aa9-4320-aa53-89f36104e70b" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Image_ImageId",
                table: "Product",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubCategory_SubCategoryId",
                table: "Product",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
