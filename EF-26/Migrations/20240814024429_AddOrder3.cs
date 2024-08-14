using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterSequence(
                name: "OrderNumber",
                incrementBy: 2);

            migrationBuilder.RestartSequence(
                name: "OrderNumber",
                startValue: 100L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterSequence(
                name: "OrderNumber",
                oldIncrementBy: 2);

            migrationBuilder.RestartSequence(
                name: "OrderNumber",
                startValue: 1L);
        }
    }
}
