using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorCrud.Migrations.RazorCrudHerb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Herb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Usage = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Part = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Grams = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herb", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Herb");
        }
    }
}
