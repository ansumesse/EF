using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddNameUniqueFilterToIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars2_CarId",
                table: "Cars2");

            migrationBuilder.CreateIndex(
                name: "CarIndex",
                table: "Cars2",
                column: "CarId",
                unique: true,
                filter: "[CARID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "CarIndex",
                table: "Cars2");

            migrationBuilder.CreateIndex(
                name: "IX_Cars2_CarId",
                table: "Cars2",
                column: "CarId");
        }
    }
}
