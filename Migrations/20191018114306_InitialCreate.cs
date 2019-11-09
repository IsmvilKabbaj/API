using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    adress1 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    city1 = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    adress2 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    city2 = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    adress3 = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    city3 = table.Column<string>(type: "nvarchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");
        }
    }
}
