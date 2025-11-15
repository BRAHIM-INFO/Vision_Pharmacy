using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vision_Pharmacy.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SaleReturn");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "SaleReturn");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "SaleReturn");

            migrationBuilder.RenameColumn(
                name: "TypePaimt",
                table: "SaleReturn",
                newName: "ReturnFactureNum");

            migrationBuilder.RenameColumn(
                name: "FactureDate",
                table: "SaleReturn",
                newName: "ReturnFactureDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnFactureNum",
                table: "SaleReturn",
                newName: "TypePaimt");

            migrationBuilder.RenameColumn(
                name: "ReturnFactureDate",
                table: "SaleReturn",
                newName: "FactureDate");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "SaleReturn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "SaleReturn",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "SaleReturn",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
