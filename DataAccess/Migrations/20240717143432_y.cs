using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class y : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GamePlatforms",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatforms_GameId",
                table: "GamePlatforms",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms");

            migrationBuilder.DropIndex(
                name: "IX_GamePlatforms_GameId",
                table: "GamePlatforms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GamePlatforms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamePlatforms",
                table: "GamePlatforms",
                columns: new[] { "GameId", "PlatformId" });
        }
    }
}
