using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maxicycles.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", "22a113e6-a660-42d9-beb1-6361427aa4ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffafadce-2165-40ed-96ed-5eca19ece5e7", "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b868633e-2427-4279-b3bb-e518fda88ed7", "9c5c2f64-0b60-4dc8-9739-0fe41595a012" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", "a2eea9b2-1bbc-4263-ac92-dd84a180a768" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06fb5a00-706b-42ae-ae91-d723eed3d738", "e0f7545b-f5f8-4445-8e8c-1823b0242259" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb9c94fa-3017-45fe-b08f-33a330e7796e", "e7415056-2778-4cb6-a9e7-4e0db58a119d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06fb5a00-706b-42ae-ae91-d723eed3d738");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b868633e-2427-4279-b3bb-e518fda88ed7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb9c94fa-3017-45fe-b08f-33a330e7796e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc629cfa-c2b7-4228-9b15-7d32938a61e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffafadce-2165-40ed-96ed-5eca19ece5e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22a113e6-a660-42d9-beb1-6361427aa4ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c5c2f64-0b60-4dc8-9739-0fe41595a012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2eea9b2-1bbc-4263-ac92-dd84a180a768");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0f7545b-f5f8-4445-8e8c-1823b0242259");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7415056-2778-4cb6-a9e7-4e0db58a119d");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "Payment",
                newName: "Cvv");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "text",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Cvv",
                table: "Payment",
                newName: "Postcode");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Payment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Payment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Payment",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Payment",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06fb5a00-706b-42ae-ae91-d723eed3d738", null, "Technician", "TECHNICIAN" },
                    { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", null, "AccountsClerk", "ACCOUNTSCLERK" },
                    { "b868633e-2427-4279-b3bb-e518fda88ed7", null, "Customer", "CUSTOMER" },
                    { "bb9c94fa-3017-45fe-b08f-33a330e7796e", null, "StockControl", "STOCKCONTROL" },
                    { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", null, "Manager", "MANAGER" },
                    { "ffafadce-2165-40ed-96ed-5eca19ece5e7", null, "MediaManager", "MEDIAMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressLine1", "AddressLine2", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Postcode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22a113e6-a660-42d9-beb1-6361427aa4ee", 0, null, null, null, "07641616-8537-4d1c-a52a-02a29c7b0f4c", "MaxicyclesUser", "accountsClerk@maxicycles.co.uk", true, null, null, true, null, "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "ACCOUNTSCLERK@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGEYH9YKN+IXJ84fUvqLNpSAX6ogpwkprQc4fbZqWATIT3n/xkQTpziOnkJrGAIPxg==", null, true, null, "ea2f6926-41ee-486b-b095-02ba132978d5", false, "accountsClerk@maxicycles.co.uk" },
                    { "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e", 0, null, null, null, "a042b903-d1e8-440b-95d6-5a55546b0283", "MaxicyclesUser", "mediaManager@maxicycles.co.uk", true, null, null, true, null, "MEDIAMANAGER@MAXICYCLES.CO.UK", "MEDIAMANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAELrB2raMGI6x7cJYevjSwUwGfBhDns5gOz+SdW5hwePNFLR6C1f3KzHmYNsNR61PBg==", null, true, null, "98565b65-d6d4-4fb9-b0fb-efa36f6cc601", false, "mediaManager@maxicycles.co.uk" },
                    { "9c5c2f64-0b60-4dc8-9739-0fe41595a012", 0, null, null, null, "04d38fc8-786e-4c32-b704-8773f3d13ff2", "MaxicyclesUser", "customer@example.co.uk", true, null, null, true, null, "CUSTOMER@EXAMPLE.CO.UK", "CUSTOMER@EXAMPLE.CO.UK", "AQAAAAIAAYagAAAAEJzmHCgvAr1cmAfBzUt5QdnBOyDo9niDq3BfVb5R4Q0//W+XnBTHKIAMpAyBUht9mw==", null, true, null, "fff2b6aa-f8d1-4b17-92b8-6267d613ba4e", false, "customer@example.co.uk" },
                    { "a2eea9b2-1bbc-4263-ac92-dd84a180a768", 0, null, null, null, "7ac07322-46be-4088-bc50-befd60457351", "MaxicyclesUser", "manager@maxicycles.co.uk", true, null, null, true, null, "MANAGER@MAXICYCLES.CO.UK", "MANAGER@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEE9HCmXgdKo8Xl/cs1r/2t4iTdmAgpC6wFKo23PpkCX79azAacK9atrKy/wdyqEkwQ==", null, true, null, "bcb959bf-5975-432c-ae30-09d365c7e875", false, "manager@maxicycles.co.uk" },
                    { "e0f7545b-f5f8-4445-8e8c-1823b0242259", 0, null, null, null, "69dd1990-7638-4a2d-821a-f53dbad87e01", "MaxicyclesUser", "technician@maxicycles.co.uk", true, null, null, true, null, "TECHNICIAN@MAXICYCLES.CO.UK", "TECHNICIAN@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEMunIdILzUecZbefeE7LaIwr2NgLUIpbkw4FYwCoXefh+pk67orj2e/8RDvIqSzndw==", null, true, null, "8332eb68-39f6-402c-959b-59f2f8b22f0f", false, "technician@maxicycles.co.uk" },
                    { "e7415056-2778-4cb6-a9e7-4e0db58a119d", 0, null, null, null, "fc0239ba-75cf-4833-8a47-c807e1387b8d", "MaxicyclesUser", "stockControl@maxicycles.co.uk", true, null, null, true, null, "STOCKCONTROL@MAXICYCLES.CO.UK", "STOCKCONTROL@MAXICYCLES.CO.UK", "AQAAAAIAAYagAAAAEGuux7RfD99/tFdQuULdMsv9fkZy1JwPBkahf2O+vi/xit6geso3xCHI+UkYD8Y5qA==", null, true, null, "e09fd68d-8d0e-4331-866a-aa36ede51fc1", false, "stockControl@maxicycles.co.uk" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8e389ec8-9a0e-45d2-9be5-26b5bdc9d736", "22a113e6-a660-42d9-beb1-6361427aa4ee" },
                    { "ffafadce-2165-40ed-96ed-5eca19ece5e7", "63b3df95-2d72-4c67-bc7b-fb04b4c24d9e" },
                    { "b868633e-2427-4279-b3bb-e518fda88ed7", "9c5c2f64-0b60-4dc8-9739-0fe41595a012" },
                    { "cc629cfa-c2b7-4228-9b15-7d32938a61e5", "a2eea9b2-1bbc-4263-ac92-dd84a180a768" },
                    { "06fb5a00-706b-42ae-ae91-d723eed3d738", "e0f7545b-f5f8-4445-8e8c-1823b0242259" },
                    { "bb9c94fa-3017-45fe-b08f-33a330e7796e", "e7415056-2778-4cb6-a9e7-4e0db58a119d" }
                });
        }
    }
}
