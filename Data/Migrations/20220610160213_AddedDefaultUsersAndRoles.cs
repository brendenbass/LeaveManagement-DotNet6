using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17d845f5-0c2d-5314-a08a-c000e8d57577", "177a15af-c9b5-446c-9d4d-022c7aeb4fb4", "User", "USER" },
                    { "27d875f5-2d8d-5314-a08a-f000e8a57577", "f8e02875-a281-45f7-8d91-91daa0ce6d8c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12d873d0-2d8c-0396-f31d-a320e8c57561", 0, "e79db702-7d66-4b97-885a-239ef2ba9fdb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEK6DIM+3GlHrQQzYV1Pl7lT93QQ9GscTwIiEf47QZGZGQZukVKJu2LZOFiyIIpP+XA==", null, false, "8eb2ed59-158e-47cd-ba14-216d9959fb57", null, false, null },
                    { "47d875e0-2d8c-5394-a38d-f021e8d57597", 0, "996fad18-3b91-485a-a4c8-a52a38420b4b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEB15/lUNiT2umDymIWBw9b9izsI7U3o5qeZYzzvYv4x/qw2XpfC8SW7R58ExJDxueg==", null, false, "99ae78b8-56e9-470f-88dd-da843d58e093", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "17d845f5-0c2d-5314-a08a-c000e8d57577", "12d873d0-2d8c-0396-f31d-a320e8c57561" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "27d875f5-2d8d-5314-a08a-f000e8a57577", "47d875e0-2d8c-5394-a38d-f021e8d57597" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17d845f5-0c2d-5314-a08a-c000e8d57577", "12d873d0-2d8c-0396-f31d-a320e8c57561" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "27d875f5-2d8d-5314-a08a-f000e8a57577", "47d875e0-2d8c-5394-a38d-f021e8d57597" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d845f5-0c2d-5314-a08a-c000e8d57577");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d875f5-2d8d-5314-a08a-f000e8a57577");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12d873d0-2d8c-0396-f31d-a320e8c57561");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47d875e0-2d8c-5394-a38d-f021e8d57597");
        }
    }
}
