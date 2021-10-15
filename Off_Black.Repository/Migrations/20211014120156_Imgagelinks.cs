using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class Imgagelinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "/Img/Men-Category-Hoodie.png", "/Img/Woman-Category-Hoodie.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "/Img/Men-Category-Pants.png", "/Img/Woman-Category-Pants.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "/Img/Men-Category-Tshirt.png", "/Img/Woman-Category-Tshirt.png" });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryImage1", "CategoryImage2" },
                values: new object[] { "/Img/Men-Category-Jackets.png", "/Img/Woman-Category-Jackets.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
