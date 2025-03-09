using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ajdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLanguage");

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

            migrationBuilder.CreateTable(
                name: "LanguageTypeL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    GameLanguageTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTypeL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LanguageTypeL_GameLanguageType_GameLanguageTypeId",
                        column: x => x.GameLanguageTypeId,
                        principalTable: "GameLanguageType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LanguageTypeL_LanguageType_LanguageTypeId",
                        column: x => x.LanguageTypeId,
                        principalTable: "LanguageType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageTypeL_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguageType_GameId",
                table: "GameLanguageType",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTypeL_GameLanguageTypeId",
                table: "LanguageTypeL",
                column: "GameLanguageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTypeL_LanguageId",
                table: "LanguageTypeL",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageTypeL_LanguageTypeId",
                table: "LanguageTypeL",
                column: "LanguageTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageTypeL");

            migrationBuilder.DropTable(
                name: "GameLanguageType");

            migrationBuilder.CreateTable(
                name: "GameLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    LanguageTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameLanguage_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLanguage_LanguageType_LanguageTypeId",
                        column: x => x.LanguageTypeId,
                        principalTable: "LanguageType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameLanguage_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguage_GameId",
                table: "GameLanguage",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguage_LanguageId",
                table: "GameLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguage_LanguageTypeId",
                table: "GameLanguage",
                column: "LanguageTypeId");
        }
    }
}
