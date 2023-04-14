using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductSlug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Product",
                type: "text",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Product");

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
    }
}
