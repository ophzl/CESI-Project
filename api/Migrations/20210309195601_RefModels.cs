using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class RefModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DefaultSupplierId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DefaultSupplier_Id",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DefaultSupplierId",
                table: "Products",
                column: "DefaultSupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_DefaultSupplierId",
                table: "Products",
                column: "DefaultSupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_DefaultSupplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DefaultSupplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DefaultSupplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DefaultSupplier_Id",
                table: "Products");
        }
    }
}
