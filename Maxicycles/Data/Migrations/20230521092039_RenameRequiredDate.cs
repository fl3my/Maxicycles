using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameRequiredDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_AspNetUsers_MaxicyclesUserId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Item_ItemId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MaxicyclesUserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Image_ImageId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_SubCategory_SubCategoryId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_MaxicyclesUserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Image_ImageId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d1a6866-a7f9-4dfd-b99a-4cd60f3ec726", "25760248-9155-4993-8aeb-86427a36ed03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15a57f07-8375-4e44-b2b3-97f28595df12", "62796976-5863-45f5-8a4e-9384f9721041" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e515765-688e-49ec-bea8-b0e1c331acd5", "6efcd84e-1d21-4538-ae1b-4ded6c62a6a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2cdc542-da8b-437b-ab84-ab1a5b084384", "84224721-7335-473a-bfe1-8c6c4a1375ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b9ff3b0-4b97-4098-af43-e559cac96d87", "a6762ed3-f293-4740-83a6-78c82db0c82a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d601cc58-0440-480b-9182-477e8023ac84", "bde2c6e5-9315-4211-b914-0570cb79fc64" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15a57f07-8375-4e44-b2b3-97f28595df12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d1a6866-a7f9-4dfd-b99a-4cd60f3ec726");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e515765-688e-49ec-bea8-b0e1c331acd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b9ff3b0-4b97-4098-af43-e559cac96d87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d601cc58-0440-480b-9182-477e8023ac84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2cdc542-da8b-437b-ab84-ab1a5b084384");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25760248-9155-4993-8aeb-86427a36ed03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62796976-5863-45f5-8a4e-9384f9721041");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6efcd84e-1d21-4538-ae1b-4ded6c62a6a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84224721-7335-473a-bfe1-8c6c4a1375ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6762ed3-f293-4740-83a6-78c82db0c82a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bde2c6e5-9315-4211-b914-0570cb79fc64");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                newName: "SubCategories");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "Holiday",
                newName: "Holidays");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                newName: "BasketItems");

            migrationBuilder.RenameColumn(
                name: "RequiredDate",
                table: "Orders",
                newName: "TargetDeliveryDate");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategories",
                newName: "IX_SubCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_MaxicyclesUserId",
                table: "Posts",
                newName: "IX_Posts_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_ImageId",
                table: "Posts",
                newName: "IX_Posts_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_SubCategoryId",
                table: "Items",
                newName: "IX_Items_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ImageId",
                table: "Items",
                newName: "IX_Items_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_MaxicyclesUserId",
                table: "Comments",
                newName: "IX_Comments_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_MaxicyclesUserId",
                table: "BasketItems",
                newName: "IX_BasketItems_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_ItemId",
                table: "BasketItems",
                newName: "IX_BasketItems_ItemId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Images",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "038e683b-bc9d-496e-9639-dec2849dc060", null, "Manager", "MANAGER" },
                    { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", null, "Customer", "CUSTOMER" },
                    { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", null, "StockControl", "STOCKCONTROL" },
                    { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", null, "MediaManager", "MEDIAMANAGER" },
                    { "c2ab606c-14a4-4090-9b31-d5314a83edd5", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "e797548d-b70b-4a76-9fe6-d174bfeea83a", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "006c7039-56f4-4f95-a4b2-9fab401a9569", 0, null, null, null, "3dc53cbf-28d1-4701-8923-2c7deb26f6fe", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEBR5YmeCftbWS1f569Ud90D1p7ti8n1c7+9clen8JdxrVna9DJ6u/WUZkZp97IODnQ==", null, true, null, "0d64d48f-33cb-447a-8941-2aee74361c43", false, "customer@example.co.uk" },
                    { "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9", 0, null, null, null, "a3325a5c-66ee-428d-8de3-0d4d85b0c582", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDqTy+WctsrPHFVUCIFZEhx2aX0EKiJ4zhF6pDT9R/y8dOmSbcmgPWoHgJOGI2mbKw==", null, true, null, "9744cead-5d78-47c9-b894-ab2da4011137", false, "mediaManager@maxicycles.co.uk" },
                    { "3e2f0531-ef66-43ba-b797-932e9bdf551c", 0, null, null, null, "b11298e0-183e-48d9-a754-51946b01bacb", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDZ5ClKe25ZWc6QO4pioB0mVlXAbemiMp/l/vuhHQLQhPV++3DlztLeWIUeUmUslBw==", null, true, null, "2a405f82-dc73-473f-a02a-d0d505cbff83", false, "stockControl@maxicycles.co.uk" },
                    { "40cc3f7f-263c-40fe-a847-3436488d3bf6", 0, null, null, null, "e99c3457-b379-446b-9a1a-12c33401fa34", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEAxpxQYmWqCBj0rIdqMGG3Lss1uVxXx6Y0cugvpWKbfTAu+KJZCRvuuLbOVpOR9VEA==", null, true, null, "6ae768e8-3e70-4a77-bf4d-ddba06f48ac6", false, "technician@maxicycles.co.uk" },
                    { "be6ec362-765f-423e-88b5-e29af14ed4f7", 0, null, null, null, "b66f6a46-0efa-4265-9c18-d1994465f841", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEF8LdtRbaZ6UxK2Xwvselhc9TKve+EFzVPnY+Gp7r2HpvfngKFj9+gtpo95r5012pQ==", null, true, null, "3bb4cfd0-c4ab-40bc-a47f-bc846fa392e7", false, "manager@maxicycles.co.uk" },
                    { "c2f5a8ee-93ec-47b2-bb00-270d455878a8", 0, null, null, null, "0c20e964-6491-4fcd-b4fe-e5892b68635f", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJT6BimJmuIHDXzEaTeheLl5M/OHA9RmFXoMsFKTiVHJg6sxZ30Yu9hu/kzRMaGBxg==", null, true, null, "bf2f48cf-301c-4c78-aae5-5bfb682538f3", false, "accountsClerk@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", "006c7039-56f4-4f95-a4b2-9fab401a9569" },
                    { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9" },
                    { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", "3e2f0531-ef66-43ba-b797-932e9bdf551c" },
                    { "e797548d-b70b-4a76-9fe6-d174bfeea83a", "40cc3f7f-263c-40fe-a847-3436488d3bf6" },
                    { "038e683b-bc9d-496e-9639-dec2849dc060", "be6ec362-765f-423e-88b5-e29af14ed4f7" },
                    { "c2ab606c-14a4-4090-9b31-d5314a83edd5", "c2f5a8ee-93ec-47b2-bb00-270d455878a8" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_AspNetUsers_MaxicyclesUserId",
                table: "BasketItems",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Items_ItemId",
                table: "BasketItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_MaxicyclesUserId",
                table: "Comments",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Images_ImageId",
                table: "Items",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SubCategories_SubCategoryId",
                table: "Items",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_MaxicyclesUserId",
                table: "Posts",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Images_ImageId",
                table: "Posts",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_AspNetUsers_MaxicyclesUserId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Items_ItemId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_MaxicyclesUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Images_ImageId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SubCategories_SubCategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_MaxicyclesUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Images_ImageId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ddb9e05-87a7-4f4a-a267-be54edb626d1", "006c7039-56f4-4f95-a4b2-9fab401a9569" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d6bf3f1-32a6-42f7-a47a-d04469a28673", "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1939d9-c391-4fdb-a204-0069d6b7dcb5", "3e2f0531-ef66-43ba-b797-932e9bdf551c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e797548d-b70b-4a76-9fe6-d174bfeea83a", "40cc3f7f-263c-40fe-a847-3436488d3bf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "038e683b-bc9d-496e-9639-dec2849dc060", "be6ec362-765f-423e-88b5-e29af14ed4f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2ab606c-14a4-4090-9b31-d5314a83edd5", "c2f5a8ee-93ec-47b2-bb00-270d455878a8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038e683b-bc9d-496e-9639-dec2849dc060");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ddb9e05-87a7-4f4a-a267-be54edb626d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1939d9-c391-4fdb-a204-0069d6b7dcb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d6bf3f1-32a6-42f7-a47a-d04469a28673");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2ab606c-14a4-4090-9b31-d5314a83edd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e797548d-b70b-4a76-9fe6-d174bfeea83a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "006c7039-56f4-4f95-a4b2-9fab401a9569");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d9b9adc-bd4c-4263-9d84-ed6265ce64b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e2f0531-ef66-43ba-b797-932e9bdf551c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40cc3f7f-263c-40fe-a847-3436488d3bf6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be6ec362-765f-423e-88b5-e29af14ed4f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f5a8ee-93ec-47b2-bb00-270d455878a8");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "SubCategory");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.RenameTable(
                name: "Holidays",
                newName: "Holiday");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "BasketItems",
                newName: "BasketItem");

            migrationBuilder.RenameColumn(
                name: "TargetDeliveryDate",
                table: "Orders",
                newName: "RequiredDate");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_MaxicyclesUserId",
                table: "Post",
                newName: "IX_Post_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ImageId",
                table: "Post",
                newName: "IX_Post_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SubCategoryId",
                table: "Item",
                newName: "IX_Item_SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ImageId",
                table: "Item",
                newName: "IX_Item_ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_MaxicyclesUserId",
                table: "Comment",
                newName: "IX_Comment_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_MaxicyclesUserId",
                table: "BasketItem",
                newName: "IX_BasketItem_MaxicyclesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ItemId",
                table: "BasketItem",
                newName: "IX_BasketItem_ItemId");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Image",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15a57f07-8375-4e44-b2b3-97f28595df12", null, "StockControl", "STOCKCONTROL" },
                    { "2d1a6866-a7f9-4dfd-b99a-4cd60f3ec726", null, "Customer", "CUSTOMER" },
                    { "5e515765-688e-49ec-bea8-b0e1c331acd5", null, "Manager", "MANAGER" },
                    { "8b9ff3b0-4b97-4098-af43-e559cac96d87", null, "Technician", "TECHNICIAN" },
                    { "d601cc58-0440-480b-9182-477e8023ac84", null, "MediaManager", "MEDIAMANAGER" },
                    { "e2cdc542-da8b-437b-ab84-ab1a5b084384", null, "AccountsClerk", "ACCOUNTSCLERK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25760248-9155-4993-8aeb-86427a36ed03", 0, null, null, null, "52909684-8943-4a89-8c07-cf8156913b16", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEHGIX/lJaSZsk82TcPaTt2zebIZFDOL857UZqv8+phhlZPRLHLzl8nbmO4Qixo4Q/Q==", null, true, null, "9e9127a5-c794-44cd-9b0f-454d1d5120fc", false, "customer@example.co.uk" },
                    { "62796976-5863-45f5-8a4e-9384f9721041", 0, null, null, null, "abaab994-a428-4b08-a54b-be4f940362fe", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMR6OEEUngGD/pk8To/0G0Q45Ej2AvrvO12dsoZJn6KQpNqG4hDSMECVjzg/hnsHrg==", null, true, null, "51f6c4d7-3372-4e18-b26b-135f9fee3310", false, "stockControl@maxicycles.co.uk" },
                    { "6efcd84e-1d21-4538-ae1b-4ded6c62a6a6", 0, null, null, null, "21c49ddb-7736-4659-9540-23cd4ca4cc6d", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHU6raeCxlwF3jfxC/7eD5c95TG3Ry6O7dFFWH9H5mOLBgOs9Xlo/KB7lcw5pZPFgQ==", null, true, null, "b559b9df-ba6d-46d0-8de9-2f31e11f85f4", false, "manager@maxicycles.co.uk" },
                    { "84224721-7335-473a-bfe1-8c6c4a1375ea", 0, null, null, null, "fc1673b2-c0d7-473d-a4b7-77918917d604", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEh1NfbDk2LJiHR9YfJimtbeQodmCoUofelAXQezLmpeh1hoaeZGi/m3cGffm10UqQ==", null, true, null, "18dd4981-2129-497f-91ac-eab448519462", false, "accountsClerk@maxicycles.co.uk" },
                    { "a6762ed3-f293-4740-83a6-78c82db0c82a", 0, null, null, null, "e23c09a2-7739-4940-a2c8-8ce3e285fce8", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEP5eoX2GP2R9MtYG8171vZoqBx96hkAKnrUEUzTvTZ/xMyKx3bzq6/VPKdOwtzgd6w==", null, true, null, "66a1e54f-a4f6-4540-b982-39db842c1ebd", false, "technician@maxicycles.co.uk" },
                    { "bde2c6e5-9315-4211-b914-0570cb79fc64", 0, null, null, null, "7441eeb2-391f-4027-9b53-536608317761", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEF6BEyCbxazEQ5rWdKzvX9XvODrKNUC7EfGYnS2Nqv8+/EGY4FQrtjgAMfN8V0nAjg==", null, true, null, "c03cf9f0-5307-421b-9f79-5e125a1539ee", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d1a6866-a7f9-4dfd-b99a-4cd60f3ec726", "25760248-9155-4993-8aeb-86427a36ed03" },
                    { "15a57f07-8375-4e44-b2b3-97f28595df12", "62796976-5863-45f5-8a4e-9384f9721041" },
                    { "5e515765-688e-49ec-bea8-b0e1c331acd5", "6efcd84e-1d21-4538-ae1b-4ded6c62a6a6" },
                    { "e2cdc542-da8b-437b-ab84-ab1a5b084384", "84224721-7335-473a-bfe1-8c6c4a1375ea" },
                    { "8b9ff3b0-4b97-4098-af43-e559cac96d87", "a6762ed3-f293-4740-83a6-78c82db0c82a" },
                    { "d601cc58-0440-480b-9182-477e8023ac84", "bde2c6e5-9315-4211-b914-0570cb79fc64" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_AspNetUsers_MaxicyclesUserId",
                table: "BasketItem",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Item_ItemId",
                table: "BasketItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MaxicyclesUserId",
                table: "Comment",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_MaxicyclesUserId",
                table: "Post",
                column: "MaxicyclesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Image_ImageId",
                table: "Post",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
