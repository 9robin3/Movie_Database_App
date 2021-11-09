using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class MoreStartingEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test9", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test10", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test11", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Scifi", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test12", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Horror", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test13", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test14", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Adventure", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test15", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017), "desc8", "Comedy", "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", 320f, "test16", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 16);
        }
    }
}
