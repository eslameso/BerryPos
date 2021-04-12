using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class jobtitleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobtitleId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobtitleId",
                table: "AspNetUsers",
                column: "JobtitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobTitles_JobtitleId",
                table: "AspNetUsers",
                column: "JobtitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobTitles_JobtitleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobtitleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobtitleId",
                table: "AspNetUsers");
        }
    }
}
