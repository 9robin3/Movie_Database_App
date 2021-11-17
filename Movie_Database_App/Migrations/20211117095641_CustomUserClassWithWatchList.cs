using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class CustomUserClassWithWatchList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_AppUserId",
                table: "Movies",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_AspNetUsers_AppUserId",
                table: "Movies",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_AspNetUsers_AppUserId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_AppUserId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Movies");
        }
    }
}
