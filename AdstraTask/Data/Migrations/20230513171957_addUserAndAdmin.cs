using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdstraTask.Data.Migrations
{
    public partial class addUserAndAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f11b9ed9-2e9e-4604-bbda-9a7c8e373fa2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0596f773-4be2-4bdc-a8c0-ddf10dc2a320", 0, "8112b13a-dd15-4fc0-b2d9-41ac2c859912", "Admin@gmail.com", false, false, null, "Admin@gmail.com", "Admin", "Admin*123", "12343545", false, "225a1cff-68b9-4964-97f8-6b6a610c6687", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17c53995-0047-471b-bf0b-ca1bd7fd0306", 0, "71878471-0777-4bfe-9dd8-3afb418a577d", "User@gmail.com", false, false, null, "User@gmail.com", "User", "User*123", "43836287389", false, "7090877b-3db7-4f9e-b9d8-7c95c87e890d", false, "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0596f773-4be2-4bdc-a8c0-ddf10dc2a320");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17c53995-0047-471b-bf0b-ca1bd7fd0306");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f11b9ed9-2e9e-4604-bbda-9a7c8e373fa2", 0, "4596676f-e315-437a-98c0-c9320c16d33c", "Admin@gmail.com", false, false, null, "Admin@gmail.com", "Admin", "Admin*123", "12343545", false, "5c300af7-62d0-4a32-9176-13e141155322", false, "Admin" });
        }
    }
}
