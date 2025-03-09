using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dsdj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguageTypeL_GameLanguageType_GameLanguageTypeId",
                table: "LanguageTypeL");

            migrationBuilder.DropTable(
                name: "GameLanguageType");

            migrationBuilder.DropIndex(
                name: "IX_LanguageTypeL_GameLanguageTypeId",
                table: "LanguageTypeL");

            migrationBuilder.DropColumn(
                name: "GameLanguageTypeId",
                table: "LanguageTypeL");

            migrationBuilder.CreateTable(
                name: "GameLanguageTypeL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    LanguageTypeLId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLanguageTypeL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameLanguageTypeL_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLanguageTypeL_LanguageTypeL_LanguageTypeLId",
                        column: x => x.LanguageTypeLId,
                        principalTable: "LanguageTypeL",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguageTypeL_GameId",
                table: "GameLanguageTypeL",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguageTypeL_LanguageTypeLId",
                table: "GameLanguageTypeL",
                column: "LanguageTypeLId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLanguageTypeL");

            migrationBuilder.AddColumn<int>(
                name: "GameLanguageTypeId",
                table: "LanguageTypeL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GameLanguageType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    LanguageTypeLId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLanguageType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameLanguageType_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTypeL_GameLanguageTypeId",
                table: "LanguageTypeL",
                column: "GameLanguageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguageType_GameId",
                table: "GameLanguageType",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageTypeL_GameLanguageType_GameLanguageTypeId",
                table: "LanguageTypeL",
                column: "GameLanguageTypeId",
                principalTable: "GameLanguageType",
                principalColumn: "Id");
        }
    }
}
