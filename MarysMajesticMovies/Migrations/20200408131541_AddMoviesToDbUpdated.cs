using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarysMajesticMovies.Migrations
{
    public partial class AddMoviesToDbUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Length",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<string>(
                name: "PosterUrl",
                table: "Movies",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosterUrl",
                table: "Movies");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Length",
                table: "Movies",
                type: "time",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
