using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_26.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTesty",
                table: "OrderTesty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderTesty",
                newName: "OrderTesties");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AlterColumn<long>(
                name: "OrderNum",
                table: "OrderTesties",
                type: "bigint",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR OrderNumber",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "NEXT VALUE FOR ORDERNUMBER");

            migrationBuilder.AlterColumn<long>(
                name: "OrderNum",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR OrderNumber",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "NEXT VALUE FOR ORDERNUMBER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTesties",
                table: "OrderTesties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTesties",
                table: "OrderTesties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderTesties",
                newName: "OrderTesty");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.AlterColumn<long>(
                name: "OrderNum",
                table: "OrderTesty",
                type: "bigint",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR ORDERNUMBER",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "NEXT VALUE FOR OrderNumber");

            migrationBuilder.AlterColumn<long>(
                name: "OrderNum",
                table: "Order",
                type: "bigint",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR ORDERNUMBER",
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "NEXT VALUE FOR OrderNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTesty",
                table: "OrderTesty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");
        }
    }
}
