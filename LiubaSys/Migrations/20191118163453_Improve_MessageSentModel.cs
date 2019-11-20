using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Improve_MessageSentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesSent_AspNetUsers_StudentId",
                table: "MessagesSent");

            migrationBuilder.DropIndex(
                name: "IX_MessagesSent_StudentId",
                table: "MessagesSent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "MessagesSent",
                newName: "UserEmail");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "MessagesSent",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "MessagesSent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "MessagesSent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MessagesSent_ApplicationUserId",
                table: "MessagesSent",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesSent_AspNetUsers_ApplicationUserId",
                table: "MessagesSent",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesSent_AspNetUsers_ApplicationUserId",
                table: "MessagesSent");

            migrationBuilder.DropIndex(
                name: "IX_MessagesSent_ApplicationUserId",
                table: "MessagesSent");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "MessagesSent");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "MessagesSent");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "MessagesSent",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "MessagesSent",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MessagesSent_StudentId",
                table: "MessagesSent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MessagesSent_AspNetUsers_StudentId",
                table: "MessagesSent",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
