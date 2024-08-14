using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddMMCarAndRecordSalesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars2",
                columns: table => new
                {
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars2", x => x.LicensePlate);
                });

            migrationBuilder.CreateTable(
                name: "RecordSales",
                columns: table => new
                {
                    RecordSaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordSales", x => x.RecordSaleId);
                });

            migrationBuilder.CreateTable(
                name: "CarRecordSales",
                columns: table => new
                {
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecordSaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRecordSales", x => new { x.RecordSaleId, x.LicensePlate });
                    table.ForeignKey(
                        name: "FK_CarRecordSales_Cars2_LicensePlate",
                        column: x => x.LicensePlate,
                        principalTable: "Cars2",
                        principalColumn: "LicensePlate",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarRecordSales_RecordSales_RecordSaleId",
                        column: x => x.RecordSaleId,
                        principalTable: "RecordSales",
                        principalColumn: "RecordSaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarRecordSales_LicensePlate",
                table: "CarRecordSales",
                column: "LicensePlate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRecordSales");

            migrationBuilder.DropTable(
                name: "Cars2");

            migrationBuilder.DropTable(
                name: "RecordSales");
        }
    }
}
