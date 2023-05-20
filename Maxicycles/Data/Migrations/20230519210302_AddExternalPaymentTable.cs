using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddExternalPaymentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54a072b2-ca6b-49a1-800c-62cc128eabcf", "1606403c-38b4-4d95-903a-ee865708bd80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0200c963-ec34-42b4-a1f0-016efb231838", "1d30cc47-4ae3-4688-8b08-7e2779bed5e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0698c41c-4c51-46dc-80f3-e2050f974846", "5b8a5050-b678-4974-bee8-1a0c54a42704" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", "9455f4f6-06e0-4601-99bc-623394af1200" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "505c8516-9fa4-4df4-ae12-1fecf9577488", "9f595c4a-cce1-4d94-bea3-c48ca97ce911" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", "e5bc009f-9b06-47c1-b93d-9f06dc54478a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0200c963-ec34-42b4-a1f0-016efb231838");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0698c41c-4c51-46dc-80f3-e2050f974846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1917e3bc-fb32-44c4-b655-4b0c5af9c27f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "505c8516-9fa4-4df4-ae12-1fecf9577488");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54a072b2-ca6b-49a1-800c-62cc128eabcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb18fb07-47ea-4c35-811f-c70e7653b5b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1606403c-38b4-4d95-903a-ee865708bd80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d30cc47-4ae3-4688-8b08-7e2779bed5e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b8a5050-b678-4974-bee8-1a0c54a42704");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9455f4f6-06e0-4601-99bc-623394af1200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f595c4a-cce1-4d94-bea3-c48ca97ce911");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5bc009f-9b06-47c1-b93d-9f06dc54478a");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Payment",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Item",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Item",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Image",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Image",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AltText",
                table: "Image",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Holiday",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DeliveryMethods",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Payment");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Item",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Item",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Image",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Image",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "AltText",
                table: "Image",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Holiday",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DeliveryMethods",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0200c963-ec34-42b4-a1f0-016efb231838", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "0698c41c-4c51-46dc-80f3-e2050f974846", null, "Customer", "CUSTOMER" },
                    { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", null, "Technician", "TECHNICIAN" },
                    { "505c8516-9fa4-4df4-ae12-1fecf9577488", null, "MediaManager", "MEDIAMANAGER" },
                    { "54a072b2-ca6b-49a1-800c-62cc128eabcf", null, "Manager", "MANAGER" },
                    { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", null, "StockControl", "STOCKCONTROL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1606403c-38b4-4d95-903a-ee865708bd80", 0, null, null, null, "b2c4864a-58f5-4bcf-9e85-cc856a75f70c", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECw4v5+9G+PoVQmnrreGrOWWLaVnMsXWQjsCGnQZsm84tGcT/tVe4JF48GFpzVgGSQ==", null, true, null, "2c609753-d30c-4221-94cf-0273716242c9", false, "manager@maxicycles.co.uk" },
                    { "1d30cc47-4ae3-4688-8b08-7e2779bed5e9", 0, null, null, null, "1d967265-9c44-4af1-ab05-a805ac06c38e", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEL8kiHgFoFIEYVTfD0JK7DLEeJ6Cf7ng62wkXBqfc7f4t5550nuzTzkuK1pTzg+y8g==", null, true, null, "0a456573-39b3-4f14-a92e-bbc1f9275928", false, "accountsClerk@maxicycles.co.uk" },
                    { "5b8a5050-b678-4974-bee8-1a0c54a42704", 0, null, null, null, "a964b7ee-7cb7-4651-830b-be7ecaffb0f0", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEJPGNV8UhodHww68+2O9X+/5aI2PbNrWdb0g0swfwcIh/hqFNlgp6oUU9g2vBxawiw==", null, true, null, "620f3c85-977a-4db5-a855-39152ceeec5b", false, "customer@example.co.uk" },
                    { "9455f4f6-06e0-4601-99bc-623394af1200", 0, null, null, null, "bc91ebf1-79c7-4999-bd5c-180769d77a0e", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEDT1yWo+/3GgRJw+smWlB1b6QuQipZ1gK9kf/Hq0LeieYj7spnap60wTT8s3VCE91Q==", null, true, null, "dab4790e-516e-4516-ac0f-957759f0a5b2", false, "technician@maxicycles.co.uk" },
                    { "9f595c4a-cce1-4d94-bea3-c48ca97ce911", 0, null, null, null, "3af37975-26e2-42f4-bd3b-75ae4987f3cc", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMukpeeZPJZRbLZWftMsE2aW5YaAUQ3zbOHuibPE3TBvkBqDzRjvwFTgNRb9HC/9LA==", null, true, null, "0d5845d3-1a06-4725-8e2c-8781bb4ee1e4", false, "mediaManager@maxicycles.co.uk" },
                    { "e5bc009f-9b06-47c1-b93d-9f06dc54478a", 0, null, null, null, "4da643de-6aaf-43ef-a245-aed58ce2c37f", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEIOzDk8yjH+M7lsStC2BeUEZQneBkKK2iAyh6Vy0H2NKMbgl+mETrs6W4wr6wqkJIw==", null, true, null, "50d7582f-7152-46e9-8e22-2293af67716e", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54a072b2-ca6b-49a1-800c-62cc128eabcf", "1606403c-38b4-4d95-903a-ee865708bd80" },
                    { "0200c963-ec34-42b4-a1f0-016efb231838", "1d30cc47-4ae3-4688-8b08-7e2779bed5e9" },
                    { "0698c41c-4c51-46dc-80f3-e2050f974846", "5b8a5050-b678-4974-bee8-1a0c54a42704" },
                    { "1917e3bc-fb32-44c4-b655-4b0c5af9c27f", "9455f4f6-06e0-4601-99bc-623394af1200" },
                    { "505c8516-9fa4-4df4-ae12-1fecf9577488", "9f595c4a-cce1-4d94-bea3-c48ca97ce911" },
                    { "cb18fb07-47ea-4c35-811f-c70e7653b5b8", "e5bc009f-9b06-47c1-b93d-9f06dc54478a" }
                });
        }
    }
}
