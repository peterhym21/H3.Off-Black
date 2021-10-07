using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class AddedMoreSampelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 2, "Pants And Sweatpants" },
                    { 3, "T-shirts" },
                    { 4, "Jackets" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Adress", "Email", "PhoneNumber" },
                values: new object[] { "Test 1", "Test1@test.com", "29045781" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Adress", "Email", "FK_UserID", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 2, "Test 2", "Test2@test.com", null, "Casper", "Koch", "29045782" },
                    { 3, "Test 3", "Test3@test.com", null, "Nickolai", "Heuck", "29045783" },
                    { 4, "Test 4", "Test4@test.com", null, "Jan", "Andersen", "29045784" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FK_CustomerID" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Amount", "FK_CategoryID", "Price", "ProductDescription", "ProductImagePath", "ProductName" },
                values: new object[] { 3, 12, 2, 7073.00m, "Straight leg formal pants in black. Logo patch sewn at front. Pockets at back. Button closure. Zip-fly. Four-pocket styling.", "", "Formal Pants" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Amount", "FK_CategoryID", "Price", "ProductDescription", "ProductImagePath", "ProductName" },
                values: new object[] { 2, 50, 3, 2316.00m, "Short sleeves T-shirt in black featuring Caravaggio painting on the front. Crewneck collar. Slim fit.", "", "Caravaggio Painting S/S T-Shirt" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Amount", "FK_CategoryID", "Price", "ProductDescription", "ProductImagePath", "ProductName" },
                values: new object[] { 4, 21, 4, 13430.00m, "Hybrid padded leather shirt in black featuring metallic swimming logo at chest and knitted sleeves. Rib knit collar cuffs and hem.", "", "Padded Leather Shirt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Adress", "Email", "PhoneNumber" },
                values: new object[] { "Egedam 4", "Test@test.com", "29045782" });
        }
    }
}
