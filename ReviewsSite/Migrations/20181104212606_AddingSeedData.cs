using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagId = table.Column<int>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewTags_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedAt", "ReviewId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nike has one of the largest variety of shoes to chose from" },
                    { 2, new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "There are many styles of dress shoes but one of my favories are chelsea boots!" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Athletic" },
                    { 2, "Buisness" },
                    { 3, "Expensive" },
                    { 4, "Affordable" },
                    { 5, "Daily Use" },
                    { 6, "Special Occasions" }
                });

            migrationBuilder.InsertData(
                table: "ReviewTags",
                columns: new[] { "Id", "ReviewId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 5, 2 },
                    { 5, 5, 3 },
                    { 6, 4, 3 },
                    { 7, 1, 4 },
                    { 8, 2, 4 },
                    { 9, 1, 5 },
                    { 10, 2, 5 },
                    { 11, 4, 6 },
                    { 12, 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTags_ReviewId",
                table: "ReviewTags",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTags_TagId",
                table: "ReviewTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ReviewTags");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
