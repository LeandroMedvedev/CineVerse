using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPMediaAndMovieAndSerieTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhysicalMedia",
                columns: table => new
                {
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    OriginalTitle = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterPath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Runtime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Premiere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasedOnRealFacts = table.Column<bool>(type: "bit", nullable: true),
                    BasedOnBooks = table.Column<bool>(type: "bit", nullable: true),
                    Dubbed = table.Column<bool>(type: "bit", nullable: true),
                    Awarded = table.Column<bool>(type: "bit", nullable: true),
                    Seasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Episodes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalMedia", x => x.PhysicalMediaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhysicalMedia");
        }
    }
}
