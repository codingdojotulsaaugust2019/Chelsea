using Microsoft.EntityFrameworkCore.Migrations;

namespace exam2.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Users_CreatorUserId",
                table: "Ideas");

            migrationBuilder.DropIndex(
                name: "IX_Ideas_CreatorUserId",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Ideas");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Ideas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_UserId",
                table: "Ideas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Users_UserId",
                table: "Ideas",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ideas_Users_UserId",
                table: "Ideas");

            migrationBuilder.DropIndex(
                name: "IX_Ideas_UserId",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ideas");

            migrationBuilder.AddColumn<int>(
                name: "CreatorUserId",
                table: "Ideas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_CreatorUserId",
                table: "Ideas",
                column: "CreatorUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ideas_Users_CreatorUserId",
                table: "Ideas",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
