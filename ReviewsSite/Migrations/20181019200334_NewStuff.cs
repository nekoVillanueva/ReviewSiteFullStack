using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class NewStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Running Shoes" },
                    { 2, "Casual Shoes" },
                    { 3, "Basketball Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImgUrl", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Nike introduced its Air Cushioning Technology in 1979. By embedding Air Cushioning in the midsoles of its running shoes, it changed the way athletes approached and reacted to athletic performance forever. Eight years later, as Nike continued to bring the latest scientific discoveries to footwear design, the Nike Air component became larger – meaning greater cushioning and comfort – and was made visible for the first time in the Air Max shoe: now athletes could see as well as feel the benefits of Nike Air. Many Nike Air products were developed since then and many of them grew to become icons on and off the track.", "/images/NikeAirMax.jpg", "Nike" },
                    { 2, 2, "In 2013, The Brand with the Three Stripes introduced Boost as its revolutionary cushioning system, which provided the highest energy return in any running sneaker. The technology was designed to provide runners with soft cushioning and long-lasting energy that more rigid sneakers couldn't.What makes Boost unlike any other cushioning used in sneakers is its material. Adidas partnered with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small energy capsules. When put together to form the distinct Boost midsole, the capsules store and release more energy than any other design on the market.What makes Boost unlike any other cushioning used in sneakers is its material. Adidas partnered with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small energy capsules.While sneaker innovation across the industry consists of a lot of research and development, there's also a lot of trial and error involved. To the consumers, new technology can seem gimmicky, as brands come up with air units, special foams, and such for performance. Boost is far from a gimmick and its uses continue to expand throughout Adidas' line of product.", "/images/AdidasUltraboost.jpg", "Adidas" },
                    { 3, 3, "Each year, a new AIR JORDAN is unveiled. An annual event since its debut in 1985, eachunveiling has been met with ever-increasing anticipation from the media, the industry,and the buying public. AIR JORDANs perennially dominate the market in sales and demand,establishing with each year’s model higher benchmark standards in design, innovation and performance for the entire athletic footwear industry.At the heart of the franchise isthe perfect synergy between athlete and technology – Michael Jordan, the greatest player in the history of basketball, and the shoes he’s worn throughout his illustrious careerthat epitomize his relentless dedication to performance, innovation and achievement.", "/images/AirJordanRetro.jpg", "Jordans" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
