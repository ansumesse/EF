using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddCarAndRecordSalesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.UniqueConstraint("AK_Car_LicensePlate", x => x.LicensePlate);
                });

            migrationBuilder.CreateTable(
                name: "RecordSales",
                columns: table => new
                {
                    RecordSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordSales", x => x.RecordSaleId);
                    table.ForeignKey(
                        name: "FK_RecordSales_Car_LicensePlate",
                        column: x => x.LicensePlate,
                        principalTable: "Car",
                        principalColumn: "LicensePlate",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordSales_LicensePlate",
                table: "RecordSales",
                column: "LicensePlate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordSales");

            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
