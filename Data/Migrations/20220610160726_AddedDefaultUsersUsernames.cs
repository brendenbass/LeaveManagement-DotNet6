using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d845f5-0c2d-5314-a08a-c000e8d57577",
                column: "ConcurrencyStamp",
                value: "a610957d-bdac-425a-9dd4-c9d7fd842281");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d875f5-2d8d-5314-a08a-f000e8a57577",
                column: "ConcurrencyStamp",
                value: "008b4571-aeb2-4043-aa20-33979d89c7dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12d873d0-2d8c-0396-f31d-a320e8c57561",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b86aa3cd-a102-4d78-bccf-969ef934b3de", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJWgzV6EjgnBRc063l6o61BNNq8+98ykRcnqn6XNcRNUUKRc/ibUGS7wMgFGFjLxfQ==", "87b5a00e-21f4-4199-95db-fc1c804452ef", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47d875e0-2d8c-5394-a38d-f021e8d57597",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7e65d2d0-0d95-4065-96dc-7e1cee7484ac", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECUEdvOqDwjJmNCQqQmCiJPTX9ORdwHYKGC8NZNgTioGLpgDOvL5v2DKpsD09vO7rw==", "bac7d6a8-78d3-42d0-b39d-8fed00571756", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d845f5-0c2d-5314-a08a-c000e8d57577",
                column: "ConcurrencyStamp",
                value: "177a15af-c9b5-446c-9d4d-022c7aeb4fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d875f5-2d8d-5314-a08a-f000e8a57577",
                column: "ConcurrencyStamp",
                value: "f8e02875-a281-45f7-8d91-91daa0ce6d8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12d873d0-2d8c-0396-f31d-a320e8c57561",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e79db702-7d66-4b97-885a-239ef2ba9fdb", false, null, "AQAAAAEAACcQAAAAEK6DIM+3GlHrQQzYV1Pl7lT93QQ9GscTwIiEf47QZGZGQZukVKJu2LZOFiyIIpP+XA==", "8eb2ed59-158e-47cd-ba14-216d9959fb57", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47d875e0-2d8c-5394-a38d-f021e8d57597",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "996fad18-3b91-485a-a4c8-a52a38420b4b", false, null, "AQAAAAEAACcQAAAAEB15/lUNiT2umDymIWBw9b9izsI7U3o5qeZYzzvYv4x/qw2XpfC8SW7R58ExJDxueg==", "99ae78b8-56e9-470f-88dd-da843d58e093", null });
        }
    }
}
