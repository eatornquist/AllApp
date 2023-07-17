using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedImageTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[] { 2, "C:/Images", "Test_Description2", "Test_Image2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[] { 1, "C:/Images", "Test_Description", "Test_Image" });
        }
    }
}
