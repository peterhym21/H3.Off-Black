using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class AddedMoreSeededSampeldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ManWoman",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Price", "ProductImagePath" },
                values: new object[] { 3832.00m, "~/Img/Men-Caravaggio-Hoodie.png" });

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
                value: "~/Img/Men-Formal-pants.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Amount", "ProductImagePath" },
                values: new object[] { 26, "~/Img/Men-Padded-leather-shirt.png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Amount", "FK_CategoryID", "ManWoman", "Price", "ProductDescription", "ProductImagePath", "ProductName" },
                values: new object[,]
                {
                    { 5, 25, 1, true, 5052.00m, "Long sleeves hooded sweatshirt with sprayed multicolor pattern allover. Elasticized hem and cuffs. Black strings.", "~/Img/Woman-Offkat-Allover-Spay-Hoodie.png", "Offkat Allover Spray Hoodie" },
                    { 6, 40, 3, true, 2231.00m, "Sleeveless bodysuit in black with OFF printed in white at chest.", "~/Img/Woman-Ribbed-Bodysuit.png", "Ribbed Bodysuit" },
                    { 7, 30, 2, true, 8715.00m, "Formal pant with multicolor pattern allover. Pockets at front and back. Zip fly. Belt loops.", "~/Img/Woman-Offkat-cady-Pants.png", "Offkat Cady Pants" },
                    { 8, 28, 4, true, 15704.00m, "Tomboy jacket in multicolor pattern allover. Pockets at front. Breast pocket. Buttons closure", "~/Img/Woman-Offkat-tomboy-jacket.png", "Offkat Tomboy Jacket" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "ManWoman",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Price", "ProductImagePath" },
                values: new object[] { 4000.00m, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ProductImagePath",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ProductImagePath",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Amount", "ProductImagePath" },
                values: new object[] { 21, "" });
        }
    }
}
