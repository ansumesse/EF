using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_09.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueSqlAddOnBlogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Blogs2",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Blogs2");
        }
    }
}
