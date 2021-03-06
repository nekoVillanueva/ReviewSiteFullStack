﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite.Models;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181104004336_AddedNewShoes")]
    partial class AddedNewShoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Type = "Running Shoes" },
                        new { Id = 2, Type = "Casual Shoes" },
                        new { Id = 3, Type = "Basketball Shoes" },
                        new { Id = 4, Type = "High Fashion/Designer SHoes" },
                        new { Id = 5, Type = "Dress Shoes" }
                    );
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Content = "Nike introduced its Air Cushioning Technology in 1979. By embedding Air Cushioning in the midsoles of its running shoes, it changed the way athletes approached and reacted to athletic performance forever. Eight years later, as Nike continued to bring the latest scientific discoveries to footwear design, the Nike Air component became larger – meaning greater cushioning and comfort – and was made visible for the first time in the Air Max shoe: now athletes could see as well as feel the benefits of Nike Air. Many Nike Air products were developed since then and many of them grew to become icons on and off the track.", ImgUrl = "/images/NikeAirMax.jpg", Title = "Nike" },
                        new { Id = 2, CategoryId = 2, Content = "In 2013, The Brand with the Three Stripes introduced Boost as its revolutionary cushioning system, which provided the highest energy return in any running sneaker. The technology was designed to provide runners with soft cushioning and long-lasting energy that more rigid sneakers couldn't.What makes Boost unlike any other cushioning used in sneakers is its material. Adidas partnered with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small energy capsules. When put together to form the distinct Boost midsole, the capsules store and release more energy than any other design on the market.What makes Boost unlike any other cushioning used in sneakers is its material. Adidas partnered with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small energy capsules.While sneaker innovation across the industry consists of a lot of research and development, there's also a lot of trial and error involved. To the consumers, new technology can seem gimmicky, as brands come up with air units, special foams, and such for performance. Boost is far from a gimmick and its uses continue to expand throughout Adidas' line of product.", ImgUrl = "/images/AdidasUltraboost.jpg", Title = "Adidas" },
                        new { Id = 3, CategoryId = 3, Content = "Each year, a new AIR JORDAN is unveiled. An annual event since its debut in 1985, eachunveiling has been met with ever-increasing anticipation from the media, the industry,and the buying public. AIR JORDANs perennially dominate the market in sales and demand,establishing with each year’s model higher benchmark standards in design, innovation and performance for the entire athletic footwear industry.At the heart of the franchise isthe perfect synergy between athlete and technology – Michael Jordan, the greatest player in the history of basketball, and the shoes he’s worn throughout his illustrious careerthat epitomize his relentless dedication to performance, innovation and achievement.", ImgUrl = "/images/AirJordanRetro.jpg", Title = "Jordans" },
                        new { Id = 4, CategoryId = 4, Content = "BigAss Bulky Super Expensive shoes", Title = "Balenciaga" },
                        new { Id = 5, CategoryId = 5, Content = "Timeless Classic shoes for formal and business attire", Title = "Johnston and Murphy" }
                    );
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
