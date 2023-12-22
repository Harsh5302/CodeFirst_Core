using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_Core.Migrations
{
    public partial class SalesDBchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName Name",
                table: "salesProducts",
                newName: "ProductName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "salesProducts",
                newName: "ProductName Name");
        }
    }
}
