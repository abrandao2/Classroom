using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiubaSys.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                });

            migrationBuilder.CreateTable(
                name: "MessagesPublished",
                columns: table => new
                {
                    MessagePublishedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    File1 = table.Column<string>(nullable: true),
                    File2 = table.Column<string>(nullable: true),
                    File3 = table.Column<string>(nullable: true),
                    File4 = table.Column<string>(nullable: true),
                    File5 = table.Column<string>(nullable: true),
                    YoutubeLink1 = table.Column<string>(nullable: true),
                    YoutubeLink2 = table.Column<string>(nullable: true),
                    YoutubeLink3 = table.Column<string>(nullable: true),
                    YoutubeLink4 = table.Column<string>(nullable: true),
                    YoutubeLink5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesPublished", x => x.MessagePublishedId);
                });

            migrationBuilder.CreateTable(
                name: "MessagesSent",
                columns: table => new
                {
                    MessageSentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Subject = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DateSent = table.Column<DateTime>(nullable: false),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesSent", x => x.MessageSentId);
                    table.ForeignKey(
                        name: "FK_MessagesSent_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MessagesInClassroom",
                columns: table => new
                {
                    MessagePublishedId = table.Column<int>(nullable: false),
                    ClassroomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesInClassroom", x => new { x.MessagePublishedId, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_MessagesInClassroom_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessagesInClassroom_MessagesPublished_MessagePublishedId",
                        column: x => x.MessagePublishedId,
                        principalTable: "MessagesPublished",
                        principalColumn: "MessagePublishedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassroomId",
                table: "AspNetUsers",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_MessagesInClassroom_ClassroomId",
                table: "MessagesInClassroom",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_MessagesSent_StudentId",
                table: "MessagesSent",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Classrooms_ClassroomId",
                table: "AspNetUsers",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Classrooms_ClassroomId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MessagesInClassroom");

            migrationBuilder.DropTable(
                name: "MessagesSent");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "MessagesPublished");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassroomId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
