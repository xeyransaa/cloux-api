using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class lsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameId1",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GameId2",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_GameId",
                table: "Languages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_GameId1",
                table: "Languages",
                column: "GameId1");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_GameId2",
                table: "Languages",
                column: "GameId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Games_GameId",
                table: "Languages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Games_GameId1",
                table: "Languages",
                column: "GameId1",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Games_GameId2",
                table: "Languages",
                column: "GameId2",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Games_GameId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Games_GameId1",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Games_GameId2",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_GameId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_GameId1",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_GameId2",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "GameId2",
                table: "Languages");
        }
    }
}
