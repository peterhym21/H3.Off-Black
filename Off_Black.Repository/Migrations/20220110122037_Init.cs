using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    FK_CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Catagories_FK_CategoryID",
                        column: x => x.FK_CategoryID,
                        principalTable: "Catagories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FK_UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Users_FK_UserID",
                        column: x => x.FK_UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FK_CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_FK_CustomerID",
                        column: x => x.FK_CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    FK_OrderID = table.Column<int>(type: "int", nullable: false),
                    FK_ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItmeID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_FK_OrderID",
                        column: x => x.FK_OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_FK_ProductID",
                        column: x => x.FK_ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CategoryID", "CategoryImage1", "CategoryImage2", "Name" },
                values: new object[,]
                {
                    { 1, "/Img/Men-Category-Hoodie.png", "/Img/Woman-Category-Hoodie.png", "Hoodies" },
                    { 2, "/Img/Men-Category-Tshirt.png", "/Img/Woman-Category-Tshirt.png", "T-Shirts" },
                    { 3, "/Img/Men-Category-Pants.png", "/Img/Woman-Category-Pants.png", "Pants" },
                    { 4, "/Img/Men-Category-Jackets.png", "/Img/Woman-Category-Jackets.png", "Jackets" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Adress", "City", "Email", "FK_UserID", "FirstName", "LastName", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { 2, "Test 2", null, "Test2@test.com", null, "Casper", "Koch", "29045782", "6400" },
                    { 4, "Test 4", null, "Test4@test.com", null, "Jan", "Andersen", "29045784", "6400" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FK_CustomerID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Adress", "City", "Email", "FK_UserID", "FirstName", "LastName", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Test 1", null, "Test1@test.com", 1, "Peter", "Hymøller", "29045781", "6400" },
                    { 3, "Test 3", null, "Test3@test.com", 2, "Nickolai", "Heuck", "29045783", "6400" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Amount", "FK_CategoryID", "Gender", "Price", "ProductDescription", "ProductImagePath", "ProductName" },
                values: new object[,]
                {
                    { 1, 21, 1, false, 3832.00m, "Long sleeves oversized hooded sweatshirt in black featuring Off logo on the front. Caravaggio arrows printed on the back. Crewneck collar. Rib knit collar, cuffs and hem. Kangaroo pocket.", "/Img/Men-Caravaggio-Hoodie.png", "Caravaggio Arrows Hoodie" },
                    { 5, 25, 1, true, 5052.00m, "Long sleeves hooded sweatshirt with sprayed multicolor pattern allover. Elasticized hem and cuffs. Black strings.", "/Img/Woman-Offkat-Allover-Spay-Hoodie.png", "Offkat Allover Spray Hoodie" },
                    { 2, 50, 2, false, 2316.00m, "Short sleeves T-shirt in black featuring Caravaggio painting on the front. Crewneck collar. Slim fit.", "/Img/Men-Caravaggio-tshirt.png", "Caravaggio Painting S/S T-Shirt" },
                    { 6, 40, 2, true, 2231.00m, "Sleeveless bodysuit in black with OFF printed in white at chest.", "/Img/Woman-Ribbed-Bodysuit.png", "Ribbed Bodysuit" },
                    { 3, 12, 3, false, 7073.00m, "Straight leg formal pants in black. Logo patch sewn at front. Pockets at back. Button closure. Zip-fly. Four-pocket styling.", "/Img/Men-Formal-pants.png", "Formal Pants" },
                    { 7, 30, 3, true, 8715.00m, "Formal pant with multicolor pattern allover. Pockets at front and back. Zip fly. Belt loops.", "/Img/Woman-Offkat-cady-Pants.png", "Offkat Cady Pants" },
                    { 4, 26, 4, false, 13430.00m, "Hybrid padded leather shirt in black featuring metallic swimming logo at chest and knitted sleeves. Rib knit collar cuffs and hem.", "/Img/Men-Padded-leather-shirt.png", "Padded Leather Shirt" },
                    { 8, 28, 4, true, 15704.00m, "Tomboy jacket in multicolor pattern allover. Pockets at front. Breast pocket. Buttons closure", "/Img/Woman-Offkat-tomboy-jacket.png", "Offkat Tomboy Jacket" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_FK_UserID",
                table: "Customers",
                column: "FK_UserID",
                unique: true,
                filter: "[FK_UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FK_OrderID",
                table: "OrderItems",
                column: "FK_OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FK_ProductID",
                table: "OrderItems",
                column: "FK_ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_CustomerID",
                table: "Orders",
                column: "FK_CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FK_CategoryID",
                table: "Products",
                column: "FK_CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
