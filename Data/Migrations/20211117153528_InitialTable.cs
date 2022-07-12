using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticalUpImageWebApp.Data.Migrations
{
    public partial class InitialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsName = table.Column<string>(maxLength: 150, nullable: false),
                    ProductsModel = table.Column<string>(maxLength: 50, nullable: false),
                    ProductsPrice = table.Column<decimal>(nullable: false),
                    ProductsImage = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
