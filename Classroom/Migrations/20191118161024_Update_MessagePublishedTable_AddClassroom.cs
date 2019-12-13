using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Update_MessagePublishedTable_AddClassroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Classroom",
                table: "MessagesPublished",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classroom",
                table: "MessagesPublished");
        }
    }
}
