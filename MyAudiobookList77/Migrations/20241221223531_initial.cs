using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAudiobookList.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AudioBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Subtitle = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    NarratedBy = table.Column<string>(type: "TEXT", nullable: false),
                    Series = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    Ratings = table.Column<string>(type: "TEXT", nullable: true),
                    Stars = table.Column<string>(type: "TEXT", nullable: true),
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true),
                    BookNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioBooks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AudioBooks");
        }
    }
}
