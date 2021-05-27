using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class measurmentsedits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Measurments");

            migrationBuilder.DropColumn(
                name: "MeasurmentType",
                table: "Measurments");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "ProductsMeasurments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MeasurmentType",
                table: "ProductsMeasurments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ProductsMeasurments");

            migrationBuilder.DropColumn(
                name: "MeasurmentType",
                table: "ProductsMeasurments");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Measurments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MeasurmentType",
                table: "Measurments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
