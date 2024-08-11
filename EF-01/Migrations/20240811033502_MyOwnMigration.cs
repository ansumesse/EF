using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_01.Migrations
{
    /// <inheritdoc />
    public partial class MyOwnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO EMPLOYEES
                                    VAlUES ('AHMED')"); 

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM EMPLOYEES WHERE NAME = 'AHMED'");
        }
    }
}
