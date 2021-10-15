using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class ChangedProductImagepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ProductImagePath",
                value: "/Img/Men-Caravaggio-Hoodie.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ProductImagePath",
                value: "/Img/Men-Caravaggio-tshirt.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductImagePath",
                value: "/Img/Men-Formal-pants.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ProductImagePath",
                value: "/Img/Men-Padded-leather-shirt.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ProductImagePath",
                value: "/Img/Woman-Offkat-Allover-Spay-Hoodie.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "ProductImagePath",
                value: "/Img/Woman-Ribbed-Bodysuit.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "ProductImagePath",
                value: "/Img/Woman-Offkat-cady-Pants.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "ProductImagePath",
                value: "/Img/Woman-Offkat-tomboy-jacket.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ProductImagePath",
                value: "~/Img/Men-Caravaggio-Hoodie.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ProductImagePath",
                value: "~/Img/Men-Caravaggio-tshirt.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductImagePath",
                value: "~/Img/Men-Formal-pants.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ProductImagePath",
                value: "~/Img/Men-Padded-leather-shirt.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "ProductImagePath",
                value: "~/Img/Woman-Offkat-Allover-Spay-Hoodie.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "ProductImagePath",
                value: "~/Img/Woman-Ribbed-Bodysuit.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "ProductImagePath",
                value: "~/Img/Woman-Offkat-cady-Pants.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "ProductImagePath",
                value: "~/Img/Woman-Offkat-tomboy-jacket.png");
        }
    }
}
