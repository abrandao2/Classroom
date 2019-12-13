using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Update_MessagePublishedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesPublished_AspNetUsers_UserId",
                table: "MessagesPublished");

            migrationBuilder.DropIndex(
                name: "IX_MessagesPublished_UserId",
                table: "MessagesPublished");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "MessagesPublished",
                newName: "UserEmail");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "MessagesPublished",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "MessagesPublished",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MessagesPublished",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessagesPublished_UserId",
                table: "MessagesPublished",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesPublished_AspNetUsers_UserId",
                table: "MessagesPublished",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
