using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Context:DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ReviewTag> ReviewTags { get; set; } // for some reason ReviewTag is white, not aqua.  does it build?
// perfect nope keep the tags also.  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=NVReviews;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
                 
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id=1,Type="Running Shoes"},
                new Category() { Id = 2, Type = "Casual Shoes" },
                new Category() { Id = 3, Type = "Basketball Shoes" },
                new Category() { Id=4, Type="High Fashion/Designer SHoes"},
                new Category() { Id=5,Type="Dress Shoes"}


                );
            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    Title = "Nike",
                    CategoryId = 1,
                    Content = "Nike introduced its Air Cushioning Technology in 1979." +
                " By embedding Air Cushioning in the midsoles of its running shoes, it changed the way athletes approached and reacted to athletic" +
                " performance forever. Eight years later, as Nike continued to bring the latest scientific discoveries to footwear design, the Nike" +
                " Air component became larger – meaning greater cushioning and comfort – and was made visible for the first time in the Air Max shoe:" +
                " now athletes could see as well as feel the benefits of Nike Air. Many Nike Air products were developed since then and many of them grew to" +
                " become icons on and off the track.",
                    ImgUrl = "/images/NikeAirMax.jpg"
                },

                new Review()
                {
                    Id = 2,
                    Title = "Adidas",
                    CategoryId = 2,
                    Content = "In 2013, The Brand with the Three Stripes introduced Boost as its revolutionary" +
                " cushioning system, which provided the highest energy return in any running sneaker. The technology was designed to provide runners with soft cushioning" +
                " and long-lasting energy that more rigid sneakers couldn't.What makes Boost unlike any other cushioning used in sneakers is its material. Adidas partnered" +
                " with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small energy capsules. When put together " +
                "to form the distinct Boost midsole, the capsules store and release more energy than any other design on the market.What makes Boost unlike any other cushioning used" +
                " in sneakers is its material. Adidas partnered with leading chemical company BASF to develop a solid granular material that's blown up and turned into thousands of small" +
                " energy capsules.While sneaker innovation across the industry consists of a lot of research and development, there's also a lot of trial and error involved. To the consumers," +
                " new technology can seem gimmicky, as brands come up with air units, special foams, and such for performance. Boost is far from a gimmick and its uses continue to expand " +
                "throughout Adidas' line of product.",
                    ImgUrl = "/images/AdidasUltraboost.jpg"
                },

                new Review()
                {
                    Id = 3,
                    Title = "Jordans",
                    CategoryId = 3,
                    Content = "Each year, a new AIR JORDAN is unveiled. An annual event since its debut in 1985, each" +
               "unveiling has been met with ever-increasing anticipation from the media, the industry,and the buying public. AIR JORDANs perennially dominate the market in sales and demand," +
               "establishing with each year’s model higher benchmark standards in design, innovation and performance for the entire athletic footwear industry.At the heart of the franchise is" +
               "the perfect synergy between athlete and technology – Michael Jordan, the greatest player in the history of basketball, and the shoes he’s worn throughout his illustrious career" +
               "that epitomize his relentless dedication to performance, innovation and achievement.",
                    ImgUrl = "/images/AirJordanRetro.jpg"
                },

                new Review() { Id = 4, Title = "Balenciaga", CategoryId = 4, Content = "BigAss Bulky Super Expensive shoes" },

                new Review() { Id = 5, Title = "Johnston and Murphy", CategoryId = 5, Content = "Timeless Classic shoes for formal and business attire" });

            modelBuilder.Entity<Comment>().HasData(
               new Comment() { Id = 1, Text = "Nike has one of the largest variety of shoes to chose from", CreatedAt = new DateTime(2018, 11, 3), ReviewId = 1 },
                new Comment() { Id = 2, Text = "There are many styles of dress shoes but one of my favories are chelsea boots!", CreatedAt = new DateTime(2018, 11, 3), ReviewId = 5 }
               );
            // good call! I forgot.  Pairing for the win :)
            //we havent added any seed data for reviewtag 
            // Lets get this in a minute, want to make sure we have the models right first.
            modelBuilder.Entity<Tag>().HasData(
               new Tag() { Id = 1, Text= "Athletic" },
               new Tag() { Id = 2, Text = "Buisness" },
               new Tag() { Id = 3, Text = "Expensive" },
               new Tag() { Id = 4, Text = "Affordable" },
               new Tag() { Id = 5, Text = "Daily Use" },
               new Tag() { Id = 6, Text = "Special Occasions" }

               );
            ////sounds good I know he is probably in the same boat  .i still am kinda lost when it comes to what is actually going on but maybe when we dive more into itll make more sense

            // So, Review tags will connect a tag to a review by using their IDs.  
            // You can join one tag to multiple reviews, and one review to multiple tags now
            // Want to run with this for a bit and try to get a migration and I'll go help Tim out for a bit?
            modelBuilder.Entity<ReviewTag>().HasData(
                new ReviewTag() { Id = 1, TagId = 1, ReviewId = 1 },
                new ReviewTag() { Id = 2, TagId = 1, ReviewId = 2 },
                new ReviewTag() { Id = 3, TagId = 1, ReviewId = 3 },
                new ReviewTag() { Id = 4, TagId = 2, ReviewId = 5 },
                new ReviewTag() { Id = 5, TagId = 3, ReviewId = 5 },
                new ReviewTag() { Id = 6, TagId = 3, ReviewId = 4 },
                new ReviewTag() { Id = 7, TagId = 4, ReviewId = 1 },
                new ReviewTag() { Id = 8, TagId = 4, ReviewId = 2 },
                new ReviewTag() { Id = 9, TagId = 5, ReviewId = 1 },
                new ReviewTag() { Id = 10, TagId = 5, ReviewId = 2 },
                new ReviewTag() { Id = 11, TagId = 6, ReviewId = 4 },
                new ReviewTag() { Id = 12, TagId = 6, ReviewId = 5 }
            );  // Update-Database 0
                // Update-Database

            base.OnModelCreating(modelBuilder);
        }

        

    }
}
