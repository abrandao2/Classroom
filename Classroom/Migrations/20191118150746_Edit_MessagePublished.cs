using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Edit_MessagePublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MessagesPublished",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessagesPublished_AspNetUsers_UserId",
                table: "MessagesPublished");

            migrationBuilder.DropIndex(
                name: "IX_MessagesPublished_UserId",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MessagesPublished");
        }
    }
}
