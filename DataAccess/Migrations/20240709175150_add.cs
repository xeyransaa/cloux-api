using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_GameCategories_CategoryId",
                table: "GameCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCategories_GameId",
                table: "GameCategories",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Categories_CategoryId",
                table: "GameCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Games_GameId",
                table: "GameCategories",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Categories_CategoryId",
                table: "GameCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Games_GameId",
                table: "GameCategories");

            migrationBuilder.DropIndex(
                name: "IX_GameCategories_CategoryId",
                table: "GameCategories");

            migrationBuilder.DropIndex(
                name: "IX_GameCategories_GameId",
                table: "GameCategories");
        }
    }
}
