using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllApp.Migrations
{
    /// <inheritdoc />
    public partial class UserTestingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "EmailConfirmed", "Name", "Password", "PasswordConfirmed" },
                values: new object[] { 1, "eatornquist04@gmail.com", "", "Eduardo", "12345", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
