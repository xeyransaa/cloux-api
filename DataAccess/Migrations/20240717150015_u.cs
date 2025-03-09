using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class u : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GameCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameCategories_CategoryId",
                table: "GameCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories");

            migrationBuilder.DropIndex(
                name: "IX_GameCategories_CategoryId",
                table: "GameCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GameCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories",
                columns: new[] { "CategoryId", "GameId" });
        }
    }
}
