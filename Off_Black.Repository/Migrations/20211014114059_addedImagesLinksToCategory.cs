using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class addedImagesLinksToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManWoman",
                table: "Products",
                newName: "Gender");

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage1",
                table: "Catagories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage2",
                table: "Catagories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "~/Img/Men-Category-Hoodie.png", "~/Img/Woman-Category-Hoodie.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "~/Img/Men-Category-Pants.png", "~/Img/Woman-Category-Pants.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "~/Img/Men-Category-Tshirt.png", "~/Img/Woman-Category-Tshirt.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "~/Img/Men-Category-Jackets.png", "~/Img/Woman-Category-Jackets.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductImagePath",
                value: "~/Img/Men-Formal-pants.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryImage1",
                table: "Catagories");

            migrationBuilder.DropColumn(
                name: "CategoryImage2",
                table: "Catagories");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Products",
                newName: "ManWoman");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductImagePath",
                value: "~/Img/Men-Formal-pants.jpg");
        }
    }
}
