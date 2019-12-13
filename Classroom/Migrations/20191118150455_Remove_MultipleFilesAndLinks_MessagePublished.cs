using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Remove_MultipleFilesAndLinks_MessagePublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File2",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "File3",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "File4",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "File5",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "YoutubeLink2",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "YoutubeLink3",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "YoutubeLink4",
                table: "MessagesPublished");

            migrationBuilder.DropColumn(
                name: "YoutubeLink5",
                table: "MessagesPublished");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "File2",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "File3",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "File4",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "File5",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink2",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink3",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink4",
                table: "MessagesPublished",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink5",
                table: "MessagesPublished",
                nullable: true);
        }
    }
}
