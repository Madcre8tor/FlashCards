using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCardsWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class KarteikartenTabelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Karteikarten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Antwort = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karteikarten", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karteikarten");
        }
    }
}
