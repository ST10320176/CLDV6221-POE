using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class Order_Product_Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Order_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Order_Product",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Order_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Order_Product");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Order_Product");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Order_Product");
        }
    }
}
