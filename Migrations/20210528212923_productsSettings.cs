using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class productsSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cell",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Coulmn",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Rack",
                table: "Products",
                newName: "Descriptions");

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "ProductsStore",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coulmn",
                table: "ProductsStore",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "ProductsStore",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "ProductsStore",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "BranchesProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coulmn",
                table: "BranchesProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "BranchesProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "BranchesProducts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cell",
                table: "ProductsStore");

            migrationBuilder.DropColumn(
                name: "Coulmn",
                table: "ProductsStore");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "ProductsStore");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "ProductsStore");

            migrationBuilder.DropColumn(
                name: "Cell",
                table: "BranchesProducts");

            migrationBuilder.DropColumn(
                name: "Coulmn",
                table: "BranchesProducts");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "BranchesProducts");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "BranchesProducts");

            migrationBuilder.RenameColumn(
                name: "Descriptions",
                table: "Products",
                newName: "Rack");

            migrationBuilder.AddColumn<string>(
                name: "Cell",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coulmn",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
