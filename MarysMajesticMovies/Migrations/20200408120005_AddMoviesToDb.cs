using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarysMajesticMovies.Migrations
{
    public partial class AddMoviesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImdbId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    YearReleased = table.Column<DateTime>(nullable: false),
                    Length = table.Column<TimeSpan>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Actors = table.Column<string>(nullable: false),
                    Plot = table.Column<string>(nullable: false),
                    ImdbRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
