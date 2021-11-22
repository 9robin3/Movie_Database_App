using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class UpdateALlEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1975), "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", "Scifi/Adventure", "https://static.posters.cz/image/1300/poster/star-wars-classic-i97850.jpg", 121f, "Star Wars", "https://www.imdb.com/video/vi1317709849?playlistId=tt0076759&ref_=tt_ov_vi" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4,
                columns: new[] { "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011), "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes. A survival game that has a whopping 45.6 billion-won prize at stake.", "Action/Drama/Mystery", "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/418598/small_a21d1dd6edee7ca8e955852b1045464b-MV5BYWE3MDVkN2EtNjQ5MS00ZDQ4LTliNzYtMjc2YWMzMDEwMTA3XkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_FMjpg_UX1000_.jpg", 55f, "Squid Game", "https://www.imdb.com/video/vi2427699993?playlistId=tt10919420&ref_=tt_ov_vi" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 5,
                columns: new[] { "DatePublished", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1999), "Adventure/Drama", "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg", 180f, "The Lord of the Rings: Fellowship of the Ring", "https://www.imdb.com/video/vi2073101337?playlistId=tt0120737&ref_=tt_ov_vi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2005), "desc3", "Horror", "https://image.posterlounge.se/images/l/1892194.jpg", 120f, "test3", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4,
                columns: new[] { "DatePublished", "Description", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), "desc4", "Horror", "https://image.posterlounge.se/images/l/1892194.jpg", 120f, "test4", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 5,
                columns: new[] { "DatePublished", "Genre", "PosterUrl", "RunningTime", "Title", "TrailerUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1995), "Horror", "https://image.posterlounge.se/images/l/1892194.jpg", 120f, "test5", "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment" });
        }
    }
}
