using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class NewConections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catagories_CatagoryCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CatagoryCategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CatagoryCategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "FK_OrderID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FK_CategoryID",
                table: "Products",
                column: "FK_CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FK_OrderID",
                table: "OrderItems",
                column: "FK_OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FK_ProductID",
                table: "OrderItems",
                column: "FK_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_FK_OrderID",
                table: "OrderItems",
                column: "FK_OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_FK_ProductID",
                table: "OrderItems",
                column: "FK_ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catagories_FK_CategoryID",
                table: "Products",
                column: "FK_CategoryID",
                principalTable: "Catagories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_FK_OrderID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_FK_ProductID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catagories_FK_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FK_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FK_OrderID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FK_ProductID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "FK_OrderID",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryCategoryID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatagoryCategoryID",
                table: "Products",
                column: "CatagoryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductID",
                table: "OrderItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catagories_CatagoryCategoryID",
                table: "Products",
                column: "CatagoryCategoryID",
                principalTable: "Catagories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
