using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieAndSerieTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasedOnRealFacts = table.Column<bool>(type: "bit", nullable: false),
                    BasedOnBooks = table.Column<bool>(type: "bit", nullable: false),
                    Dubbed = table.Column<bool>(type: "bit", nullable: false),
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterPath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Runtime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Premiere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awarded = table.Column<bool>(type: "bit", nullable: false),
                    Seasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Episodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterPath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Runtime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Premiere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.SerieId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Serie");
        }
    }
}
