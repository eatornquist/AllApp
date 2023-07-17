using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedImageTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[] { 1, "C:/Images", "Test_Description1", "Test_Image" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
