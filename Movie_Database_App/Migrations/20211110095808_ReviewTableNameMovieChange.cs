using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class ReviewTableNameMovieChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieID1",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "MovieID1",
                table: "Reviews",
                newName: "MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MovieID1",
                table: "Reviews",
                newName: "IX_Reviews_MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieID",
                table: "Reviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieID",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Reviews",
                newName: "MovieID1");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MovieID",
                table: "Reviews",
                newName: "IX_Reviews_MovieID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieID1",
                table: "Reviews",
                column: "MovieID1",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
