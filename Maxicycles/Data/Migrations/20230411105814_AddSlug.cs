using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "919c399a-c717-41be-9965-1a77c56de707", "46e17124-4f7e-4a33-95a1-7531a1a894b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f41a7f03-9749-415e-8aa6-6a641ac7381e", "76addc0c-9d5f-40ee-8cc2-694455bda64d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aa723057-7543-44ef-836d-e5379ee7a4e6", "a5c08205-5bfe-4f97-a23f-7caeca012967" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", "b74fd7c2-840b-4e42-83d2-f99270b2d9a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12dc1573-cf5b-4a02-8883-91426b17d6d4", "e9df56c5-d794-4e4e-8122-8fda2d2c1270" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12dc1573-cf5b-4a02-8883-91426b17d6d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "919c399a-c717-41be-9965-1a77c56de707");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa723057-7543-44ef-836d-e5379ee7a4e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f41a7f03-9749-415e-8aa6-6a641ac7381e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46e17124-4f7e-4a33-95a1-7531a1a894b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76addc0c-9d5f-40ee-8cc2-694455bda64d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5c08205-5bfe-4f97-a23f-7caeca012967");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74fd7c2-840b-4e42-83d2-f99270b2d9a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9df56c5-d794-4e4e-8122-8fda2d2c1270");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SubCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubCategory",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "SubCategory",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Category",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20c55d43-7e9d-43ce-9718-b5c8b6264e03", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "72a17e4b-93cd-45b9-a742-f748c63bb161", null, "Manager", "MANAGER" },
                    { "ac990d1f-e0f8-4d5e-86b3-26e82d9ed86d", null, "Technician", "TECHNICIAN" },
                    { "f0aacbe7-66b2-4296-a866-09c3bdfc314b", null, "MediaManager", "MEDIAMANAGER" },
                    { "f6bbaf43-ab97-4578-9fc0-76e9f92d4d2d", null, "StockControl", "STOCKCONTROL" },
                    { "f8bebdd8-8f8e-449d-9848-3878da716517", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2860d55e-d393-40de-8fc5-3e2b9a446298", 0, null, null, null, "2b9c8491-4d6c-47da-ae1c-20c48a031a97", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEEgdpwZWyqnuDKKtIih0NQhP16wYWxPm32nVXjHmEKQN7xrFnSgIQPUKMv+ezxN0sw==", null, true, null, "e6b38065-47a9-4883-b9c2-498862716487", false, "stockControl@maxicycles.co.uk" },
                    { "31199299-433b-4e6c-813e-622de9605490", 0, null, null, null, "8065aa67-c95a-405f-9a4c-8b45d3090cbb", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEJRXRs8+bsvDblXiNFehI/pdzdC16NmHHi4ARqvsD+TlCEOR7/mq2W/7YG9SryBnDQ==", null, true, null, "7fb9626b-2d83-4c57-8a2e-705fd71b4700", false, "technician@maxicycles.co.uk" },
                    { "61e90279-e182-4a1a-9ca3-dd2a58d6d8ba", 0, null, null, null, "243753b2-9b1c-4f29-87d2-d7a0be9087a3", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAENE3eS3gQrFnHWDLbg18Fm7/ulJFLLdZFLQBB8jnArkgnk+ASGcoNN79koAKrVw3Kg==", null, true, null, "01179c28-8e56-406f-aa15-8825a55ea653", false, "customer@example.co.uk" },
                    { "c52c953e-9281-489f-bdd3-0a11f874b344", 0, null, null, null, "c8516e58-72b8-42a3-b374-217fd44db921", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEHdXspT8drMekK6UlVUmse6oG31ubchDve3+oKkb3v0decD7atYFAwCAtkqwmY+Nbg==", null, true, null, "f055f85a-0c71-499b-a9b1-7e61ccb8b454", false, "accountsClerk@maxicycles.co.uk" },
                    { "ceb58674-1d98-4651-9c05-f61839386f09", 0, null, null, null, "35ee15e7-9856-46a9-b018-15cdc48cdd0d", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELnztm1uash1pwNdZptMxcucdCWeiFqemrqdWRjNjeexpmMQNgXc3mnAJvtWMUm3rg==", null, true, null, "2f7bcbbf-ce38-4e0e-bbad-db6aafda2b65", false, "manager@maxicycles.co.uk" },
                    { "fe301663-90c0-49a0-9327-6122005f6415", 0, null, null, null, "a2267ec9-32e6-4a2d-b0d6-7346205c9c77", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKEtGrm267HF/Tnz/ctPzCPPMOB1Y/sMTy6W7+IObMoniKL68hQZkvjh3M8Z9kK8lQ==", null, true, null, "5d879532-09f8-4859-9896-535b0ebbda60", false, "mediaManager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f6bbaf43-ab97-4578-9fc0-76e9f92d4d2d", "2860d55e-d393-40de-8fc5-3e2b9a446298" },
                    { "ac990d1f-e0f8-4d5e-86b3-26e82d9ed86d", "31199299-433b-4e6c-813e-622de9605490" },
                    { "f8bebdd8-8f8e-449d-9848-3878da716517", "61e90279-e182-4a1a-9ca3-dd2a58d6d8ba" },
                    { "20c55d43-7e9d-43ce-9718-b5c8b6264e03", "c52c953e-9281-489f-bdd3-0a11f874b344" },
                    { "72a17e4b-93cd-45b9-a742-f748c63bb161", "ceb58674-1d98-4651-9c05-f61839386f09" },
                    { "f0aacbe7-66b2-4296-a866-09c3bdfc314b", "fe301663-90c0-49a0-9327-6122005f6415" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f6bbaf43-ab97-4578-9fc0-76e9f92d4d2d", "2860d55e-d393-40de-8fc5-3e2b9a446298" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac990d1f-e0f8-4d5e-86b3-26e82d9ed86d", "31199299-433b-4e6c-813e-622de9605490" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8bebdd8-8f8e-449d-9848-3878da716517", "61e90279-e182-4a1a-9ca3-dd2a58d6d8ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "20c55d43-7e9d-43ce-9718-b5c8b6264e03", "c52c953e-9281-489f-bdd3-0a11f874b344" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72a17e4b-93cd-45b9-a742-f748c63bb161", "ceb58674-1d98-4651-9c05-f61839386f09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0aacbe7-66b2-4296-a866-09c3bdfc314b", "fe301663-90c0-49a0-9327-6122005f6415" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c55d43-7e9d-43ce-9718-b5c8b6264e03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a17e4b-93cd-45b9-a742-f748c63bb161");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac990d1f-e0f8-4d5e-86b3-26e82d9ed86d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0aacbe7-66b2-4296-a866-09c3bdfc314b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6bbaf43-ab97-4578-9fc0-76e9f92d4d2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8bebdd8-8f8e-449d-9848-3878da716517");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2860d55e-d393-40de-8fc5-3e2b9a446298");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31199299-433b-4e6c-813e-622de9605490");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61e90279-e182-4a1a-9ca3-dd2a58d6d8ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c52c953e-9281-489f-bdd3-0a11f874b344");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceb58674-1d98-4651-9c05-f61839386f09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe301663-90c0-49a0-9327-6122005f6415");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubCategory",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SubCategory",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Category",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12dc1573-cf5b-4a02-8883-91426b17d6d4", null, "Manager", "MANAGER" },
                    { "919c399a-c717-41be-9965-1a77c56de707", null, "Technician", "TECHNICIAN" },
                    { "aa723057-7543-44ef-836d-e5379ee7a4e6", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", null, "MediaManager", "MEDIAMANAGER" },
                    { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", null, "StockControl", "STOCKCONTROL" },
                    { "f41a7f03-9749-415e-8aa6-6a641ac7381e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46e17124-4f7e-4a33-95a1-7531a1a894b8", 0, null, null, null, "949dfa84-f2d5-4349-bb17-cc618c86089d", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAECz0ayr6fzt8PM3EscodPnCnA2dkvpxHd4L+9YdC3yuznvyEqejMwS3+6N3DCA4SBg==", null, true, null, "dac691fb-1148-4a10-a636-908cbc8506d8", false, "technician@maxicycles.co.uk" },
                    { "76addc0c-9d5f-40ee-8cc2-694455bda64d", 0, null, null, null, "0ef87bb2-3391-462e-99f4-c597f1be58a4", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEHhZAuYviDMKydopvQXq4mHC20M4/eCKyCu5zF5Z8t28RagA+LwemzhbeonroCbutg==", null, true, null, "8bf471ac-a54d-4ef7-acab-2b5647ade966", false, "customer@example.co.uk" },
                    { "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17", 0, null, null, null, "79dcbf6e-2c82-4244-b9d6-41dd6bae4912", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELZ/7/IK1g24dHtnpvgBgMVlscRDCJcs098KD5k7tw0o7WXdpn5Yk6B/pz94vMWEyA==", null, true, null, "c95fcfdf-765b-4f33-b044-c7e13fa472ff", false, "stockControl@maxicycles.co.uk" },
                    { "a5c08205-5bfe-4f97-a23f-7caeca012967", 0, null, null, null, "577aa62a-76a9-4a28-8fef-64cce3dcb1e2", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEKwkItv4Db4JhWz1n45CLnA4BS/sBvwHTyUCwFWdJ+KtMel3gRpZRLN5tx4U3VZnng==", null, true, null, "2c7192e1-2066-4cbb-8d20-f4bfed6aa62e", false, "accountsClerk@maxicycles.co.uk" },
                    { "b74fd7c2-840b-4e42-83d2-f99270b2d9a5", 0, null, null, null, "9915899c-3db5-4556-b514-fe2066a90fb4", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEG+UHMBbz86kMzxHR06RVj+wxFbB6Wie1w7dQWyWwbeCRGccGoqavArB7J0/KKgEJg==", null, true, null, "91cda7b8-1722-48ea-a1a9-ad61762921ca", false, "mediaManager@maxicycles.co.uk" },
                    { "e9df56c5-d794-4e4e-8122-8fda2d2c1270", 0, null, null, null, "4f891fc1-066b-401f-a09d-977e16d06c20", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMpD0fX9bH2zvKEjg0vBRigiB0+1Fev7QKT1zqfmWrdDqN5Hs88KgVts4o/C+kuK5Q==", null, true, null, "b64410b6-f790-4efe-b322-5db957908d3d", false, "manager@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "919c399a-c717-41be-9965-1a77c56de707", "46e17124-4f7e-4a33-95a1-7531a1a894b8" },
                    { "f41a7f03-9749-415e-8aa6-6a641ac7381e", "76addc0c-9d5f-40ee-8cc2-694455bda64d" },
                    { "e5ef2dd6-20f3-4b89-b0fa-1c235d7d7617", "9fbe5bd1-e770-4d01-b4ea-b217d5e39e17" },
                    { "aa723057-7543-44ef-836d-e5379ee7a4e6", "a5c08205-5bfe-4f97-a23f-7caeca012967" },
                    { "ae1bbca7-a0cc-4763-bd33-c4cbf22b2ec3", "b74fd7c2-840b-4e42-83d2-f99270b2d9a5" },
                    { "12dc1573-cf5b-4a02-8883-91426b17d6d4", "e9df56c5-d794-4e4e-8122-8fda2d2c1270" }
                });
        }
    }
}
