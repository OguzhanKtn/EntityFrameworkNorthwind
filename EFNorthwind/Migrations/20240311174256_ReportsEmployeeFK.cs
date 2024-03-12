using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFNorthwind.Migrations
{
    /// <inheritdoc />
    public partial class ReportsEmployeeFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportsTo",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReportsTo",
                table: "Employees");
        }
    }
}
