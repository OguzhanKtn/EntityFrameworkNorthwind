using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFNorthwind.Migrations
{
    /// <inheritdoc />
    public partial class ProductSupplierFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SuppliersId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SuppliersId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SuppliersId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "SuppliersId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SuppliersId",
                table: "Products",
                column: "SuppliersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SuppliersId",
                table: "Products",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }
    }
}
