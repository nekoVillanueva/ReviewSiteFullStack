using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedNewShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Type" },
                values: new object[] { 4, "High Fashion/Designer SHoes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Type" },
                values: new object[] { 5, "Dress Shoes" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImgUrl", "Title" },
                values: new object[] { 4, 4, "BigAss Bulky Super Expensive shoes", null, "Balenciaga" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImgUrl", "Title" },
                values: new object[] { 5, 5, "Timeless Classic shoes for formal and business attire", null, "Johnston and Murphy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
