using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vision_Pharmacy.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreataDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medication_Purchase_PurchaseId",
                table: "Medication");

            migrationBuilder.DropIndex(
                name: "IX_Medication_PurchaseId",
                table: "Medication");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Medication");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Medication");

            migrationBuilder.DropColumn(
                name: "SupplierName",
                table: "Medication");

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Purchase",
                newName: "FactureDate");

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Purchase",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Purchase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "Purchase",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "SupplierName",
                table: "Purchase");

            migrationBuilder.RenameColumn(
                name: "FactureDate",
                table: "Purchase",
                newName: "PurchaseDate");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Medication",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Medication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "Medication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Medication_PurchaseId",
                table: "Medication",
                column: "PurchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medication_Purchase_PurchaseId",
                table: "Medication",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "Id");
        }
    }
}
