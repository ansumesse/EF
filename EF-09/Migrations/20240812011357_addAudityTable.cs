﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_09.Migrations
{
    /// <inheritdoc />
    public partial class addAudityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Blogs2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Blogs2_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_BlogId",
                table: "Post",
                column: "BlogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Blogs2");

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
    }
}
