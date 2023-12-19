using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    Freight = table.Column<float>(type: "real", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

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
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalMedia", x => x.PhysicalMediaId);
                });

            migrationBuilder.CreateTable(
                name: "CartPhysicalMedia",
                columns: table => new
                {
                    CartsCartId = table.Column<int>(type: "int", nullable: false),
                    PhysicalMediasPhysicalMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartPhysicalMedia", x => new { x.CartsCartId, x.PhysicalMediasPhysicalMediaId });
                    table.ForeignKey(
                        name: "FK_CartPhysicalMedia_Cart_CartsCartId",
                        column: x => x.CartsCartId,
                        principalTable: "Cart",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartPhysicalMedia_PhysicalMedia_PhysicalMediasPhysicalMediaId",
                        column: x => x.PhysicalMediasPhysicalMediaId,
                        principalTable: "PhysicalMedia",
                        principalColumn: "PhysicalMediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenrePhysicalMedia",
                columns: table => new
                {
                    GenresGenreId = table.Column<int>(type: "int", nullable: false),
                    PhysicalMediasPhysicalMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenrePhysicalMedia", x => new { x.GenresGenreId, x.PhysicalMediasPhysicalMediaId });
                    table.ForeignKey(
                        name: "FK_GenrePhysicalMedia_Genre_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenrePhysicalMedia_PhysicalMedia_PhysicalMediasPhysicalMediaId",
                        column: x => x.PhysicalMediasPhysicalMediaId,
                        principalTable: "PhysicalMedia",
                        principalColumn: "PhysicalMediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    BasedOnRealFacts = table.Column<bool>(type: "bit", nullable: false),
                    BasedOnBooks = table.Column<bool>(type: "bit", nullable: false),
                    Dubbed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.PhysicalMediaId);
                    table.ForeignKey(
                        name: "FK_Movie_PhysicalMedia_PhysicalMediaId",
                        column: x => x.PhysicalMediaId,
                        principalTable: "PhysicalMedia",
                        principalColumn: "PhysicalMediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: false),
                    SerieId = table.Column<int>(type: "int", nullable: false),
                    Awarded = table.Column<bool>(type: "bit", nullable: false),
                    Seasons = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Episodes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.PhysicalMediaId);
                    table.ForeignKey(
                        name: "FK_Serie_PhysicalMedia_PhysicalMediaId",
                        column: x => x.PhysicalMediaId,
                        principalTable: "PhysicalMedia",
                        principalColumn: "PhysicalMediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<byte>(type: "tinyint", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicalMediaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_PhysicalMedia_PhysicalMediaId",
                        column: x => x.PhysicalMediaId,
                        principalTable: "PhysicalMedia",
                        principalColumn: "PhysicalMediaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartPhysicalMedia_PhysicalMediasPhysicalMediaId",
                table: "CartPhysicalMedia",
                column: "PhysicalMediasPhysicalMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_GenrePhysicalMedia_PhysicalMediasPhysicalMediaId",
                table: "GenrePhysicalMedia",
                column: "PhysicalMediasPhysicalMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_PhysicalMediaId",
                table: "Stock",
                column: "PhysicalMediaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartPhysicalMedia");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "GenrePhysicalMedia");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "PhysicalMedia");
        }
    }
}
