using Microsoft.EntityFrameworkCore.Migrations;

namespace exam.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_RequesteeId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_RequesterId",
                table: "Relationships");

            migrationBuilder.RenameColumn(
                name: "RequesterId",
                table: "Relationships",
                newName: "TargetId");

            migrationBuilder.RenameColumn(
                name: "RequesteeId",
                table: "Relationships",
                newName: "SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Relationships_RequesterId",
                table: "Relationships",
                newName: "IX_Relationships_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_Relationships_RequesteeId",
                table: "Relationships",
                newName: "IX_Relationships_SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_SenderId",
                table: "Relationships",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_TargetId",
                table: "Relationships",
                column: "TargetId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_SenderId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Users_TargetId",
                table: "Relationships");

            migrationBuilder.RenameColumn(
                name: "TargetId",
                table: "Relationships",
                newName: "RequesterId");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Relationships",
                newName: "RequesteeId");

            migrationBuilder.RenameIndex(
                name: "IX_Relationships_TargetId",
                table: "Relationships",
                newName: "IX_Relationships_RequesterId");

            migrationBuilder.RenameIndex(
                name: "IX_Relationships_SenderId",
                table: "Relationships",
                newName: "IX_Relationships_RequesteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_RequesteeId",
                table: "Relationships",
                column: "RequesteeId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Users_RequesterId",
                table: "Relationships",
                column: "RequesterId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
