using Microsoft.EntityFrameworkCore.Migrations;

namespace chefNdish.Migrations
{
    public partial class ChefId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chef",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Chef",
                table: "Dishes",
                nullable: false,
                defaultValue: "");
        }
    }
}
