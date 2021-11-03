using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class SeedMoviesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Description", "RunningTime", "Title" },
                values: new object[] { 1, "desc", 200f, "test1" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Description", "RunningTime", "Title" },
                values: new object[] { 2, "desc2", 70f, "test2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Description", "RunningTime", "Title" },
                values: new object[] { 3, "desc3", 120f, "test3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3);
        }
    }
}
