using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Database_App.Migrations
{
    public partial class ReviewObjectInMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ReviewID",
                table: "Movies",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Review_ReviewID",
                table: "Movies",
                column: "ReviewID",
                principalTable: "Review",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Review_ReviewID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ReviewID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Movies");
        }
    }
}
