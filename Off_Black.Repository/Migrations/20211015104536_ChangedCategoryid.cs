using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class ChangedCategoryid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryImage1", "CategoryImage2", "Name" },
                values: new object[] { "/Img/Men-Category-Tshirt.png", "/Img/Woman-Category-Tshirt.png", "T-Shirts" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryImage1", "CategoryImage2", "Name" },
                values: new object[] { "/Img/Men-Category-Pants.png", "/Img/Woman-Category-Pants.png", "Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "FK_CategoryID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "FK_CategoryID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "FK_CategoryID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "FK_CategoryID",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryImage1", "CategoryImage2", "Name" },
                values: new object[] { "/Img/Men-Category-Pants.png", "/Img/Woman-Category-Pants.png", "Pants" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryImage1", "CategoryImage2", "Name" },
                values: new object[] { "/Img/Men-Category-Tshirt.png", "/Img/Woman-Category-Tshirt.png", "T-Shirts" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "FK_CategoryID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "FK_CategoryID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "FK_CategoryID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "FK_CategoryID",
                value: 2);
        }
    }
}
