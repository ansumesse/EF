using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksAuthorsNationalitiesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars2",
                columns: new[] { "LicensePlate", "CarId", "Make", "Model" },
                values: new object[] { "344", 1, "china", "hundaye" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars2",
                keyColumn: "LicensePlate",
                keyValue: "344");
        }
    }
}
