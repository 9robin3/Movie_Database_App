using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class IDTableNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieID1",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "MovieID1",
                table: "Reviews",
                newName: "Movieid1");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MovieID1",
                table: "Reviews",
                newName: "IX_Reviews_Movieid1");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "Movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_Movieid1",
                table: "Reviews",
                column: "Movieid1",
                principalTable: "Movies",
                principalColumn: "Movieid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_Movieid1",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Movieid1",
                table: "Reviews",
                newName: "MovieID1");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_Movieid1",
                table: "Reviews",
                newName: "IX_Reviews_MovieID1");

            migrationBuilder.RenameColumn(
                name: "Movieid",
                table: "Movies",
                newName: "MovieID");

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
