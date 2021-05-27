using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class measurmentsedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsKnow",
                table: "Measurments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Measurments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKnow",
                table: "Measurments");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Measurments");
        }
    }
}
