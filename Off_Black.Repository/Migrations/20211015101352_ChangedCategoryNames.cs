using Microsoft.EntityFrameworkCore.Migrations;

namespace Off_Black.Migrations
{
    public partial class ChangedCategoryNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Name",
                value: "Hoodies");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Name",
                value: "Pants");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "Name",
                value: "T-Shirts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Name",
                value: "Sweaaters And Hoodies");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "Name",
                value: "Pants And Sweatpants");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "Name",
                value: "T-shirts");
        }
    }
}
