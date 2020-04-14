using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarysMajesticMovies.Migrations
{
    public partial class AddedTrailerPriceInStockToMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "YearReleased",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RunTime",
                table: "Movies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrailerUrl",
                table: "Movies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RunTime",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TrailerUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Length",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "YearReleased",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
