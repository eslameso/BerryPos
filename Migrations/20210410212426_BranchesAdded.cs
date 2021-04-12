using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class BranchesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchesProductsBranchId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchesProductsProductId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchesProductsProductId_BranchesProductsBranchId",
                table: "AspNetUsers",
                columns: new[] { "BranchesProductsProductId", "BranchesProductsBranchId" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BranchesProducts_BranchesProductsProductId_BranchesProductsBranchId",
                table: "AspNetUsers",
                columns: new[] { "BranchesProductsProductId", "BranchesProductsBranchId" },
                principalTable: "BranchesProducts",
                principalColumns: new[] { "ProductId", "BranchId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Branches_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BranchesProducts_BranchesProductsProductId_BranchesProductsBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BranchesProductsProductId_BranchesProductsBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchesProductsBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchesProductsProductId",
                table: "AspNetUsers");
        }
    }
}
