using Microsoft.EntityFrameworkCore.Migrations;

namespace Pos.Migrations
{
    public partial class measure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasurmentsProductsMeasurments");

            migrationBuilder.DropTable(
                name: "ProductsProductsMeasurments");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsMeasurments_MeasurmentId",
                table: "ProductsMeasurments",
                column: "MeasurmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsMeasurments_Measurments_MeasurmentId",
                table: "ProductsMeasurments",
                column: "MeasurmentId",
                principalTable: "Measurments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsMeasurments_Products_ProductId",
                table: "ProductsMeasurments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsMeasurments_Measurments_MeasurmentId",
                table: "ProductsMeasurments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsMeasurments_Products_ProductId",
                table: "ProductsMeasurments");

            migrationBuilder.DropIndex(
                name: "IX_ProductsMeasurments_MeasurmentId",
                table: "ProductsMeasurments");

            migrationBuilder.CreateTable(
                name: "MeasurmentsProductsMeasurments",
                columns: table => new
                {
                    MeasurmentsId = table.Column<int>(type: "int", nullable: false),
                    ProductsMeasurmentsProductId = table.Column<int>(type: "int", nullable: false),
                    ProductsMeasurmentsMeasurmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurmentsProductsMeasurments", x => new { x.MeasurmentsId, x.ProductsMeasurmentsProductId, x.ProductsMeasurmentsMeasurmentId });
                    table.ForeignKey(
                        name: "FK_MeasurmentsProductsMeasurments_Measurments_MeasurmentsId",
                        column: x => x.MeasurmentsId,
                        principalTable: "Measurments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeasurmentsProductsMeasurments_ProductsMeasurments_ProductsMeasurmentsProductId_ProductsMeasurmentsMeasurmentId",
                        columns: x => new { x.ProductsMeasurmentsProductId, x.ProductsMeasurmentsMeasurmentId },
                        principalTable: "ProductsMeasurments",
                        principalColumns: new[] { "ProductId", "MeasurmentId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsProductsMeasurments",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    ProductsMeasurmentsProductId = table.Column<int>(type: "int", nullable: false),
                    ProductsMeasurmentsMeasurmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsProductsMeasurments", x => new { x.ProductsId, x.ProductsMeasurmentsProductId, x.ProductsMeasurmentsMeasurmentId });
                    table.ForeignKey(
                        name: "FK_ProductsProductsMeasurments_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsProductsMeasurments_ProductsMeasurments_ProductsMeasurmentsProductId_ProductsMeasurmentsMeasurmentId",
                        columns: x => new { x.ProductsMeasurmentsProductId, x.ProductsMeasurmentsMeasurmentId },
                        principalTable: "ProductsMeasurments",
                        principalColumns: new[] { "ProductId", "MeasurmentId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeasurmentsProductsMeasurments_ProductsMeasurmentsProductId_ProductsMeasurmentsMeasurmentId",
                table: "MeasurmentsProductsMeasurments",
                columns: new[] { "ProductsMeasurmentsProductId", "ProductsMeasurmentsMeasurmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsProductsMeasurments_ProductsMeasurmentsProductId_ProductsMeasurmentsMeasurmentId",
                table: "ProductsProductsMeasurments",
                columns: new[] { "ProductsMeasurmentsProductId", "ProductsMeasurmentsMeasurmentId" });
        }
    }
}
