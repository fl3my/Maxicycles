using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
