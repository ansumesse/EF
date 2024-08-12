using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_09.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAudityTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AudityEntity",
                table: "AudityEntity");

            migrationBuilder.RenameTable(
                name: "AudityEntity",
                newName: "AudEnt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AudEnt",
                table: "AudEnt",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AudEnt",
                table: "AudEnt");

            migrationBuilder.RenameTable(
                name: "AudEnt",
                newName: "AudityEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AudityEntity",
                table: "AudityEntity",
                column: "Id");
        }
    }
}
