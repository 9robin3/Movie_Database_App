using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class UpdateEntryTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "DatePublished", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1987), "Scifi/Action", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX1000_.jpg", 160f, "Inception", "https://www.youtube.com/watch?v=YoHD9XEInc0&ab_channel=MovieclipsClassicTrailers" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { "Scifi/Adventure", "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/405404/1e9f19f8529d69ceb08691e6fcb22c41-artwork-dune.jpg", 160f, "Dune", "https://www.imdb.com/video/vi3986080537?playlistId=tt1160419&ref_=tt_ov_vi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "DatePublished", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2019), "Action", "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg", 200f, "test1", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { "Scifi", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 70f, "test2", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" });
        }
    }
}
