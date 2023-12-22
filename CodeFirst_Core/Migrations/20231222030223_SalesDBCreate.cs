using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_Core.Migrations
{
    public partial class SalesDBCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "salesProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNameName = table.Column<int>(name: "ProductName Name", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesProducts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salesProducts");
        }
    }
}
