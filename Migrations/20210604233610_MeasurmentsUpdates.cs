using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class MeasurmentsUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "ProductsMeasurments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SalesPrice",
                table: "ProductsMeasurments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "ProductsMeasurments");

            migrationBuilder.DropColumn(
                name: "SalesPrice",
                table: "ProductsMeasurments");
        }
    }
}
