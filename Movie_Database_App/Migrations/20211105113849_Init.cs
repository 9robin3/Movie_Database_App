using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunningTime = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieID1",
                        column: x => x.MovieID1,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019), "desc", "Action", "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg", 200f, "test1", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc2", "Scifi", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 70f, "test2", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), "desc3", "Horror", "https://image.posterlounge.se/images/l/1892194.jpg", 120f, "test3", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), "desc4", "Horror", "https://image.posterlounge.se/images/l/1892194.jpg", 120f, "test4", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc5", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 70f, "test5", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019), "desc6", "Action", "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg", 200f, "test6", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc7", "Scifi", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 70f, "test7", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test8", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieID1",
                table: "Reviews",
                column: "MovieID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
