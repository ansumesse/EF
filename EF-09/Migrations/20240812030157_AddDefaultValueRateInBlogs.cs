using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_09.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueRateInBlogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Blogs2",
                type: "int",
                nullable: false,
                defaultValue: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Blogs2");
        }
    }
}
