using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class kddjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "GameLanguageTypeLs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguageTypeLs_LanguageId",
                table: "GameLanguageTypeLs",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguageTypeLs_Languages_LanguageId",
                table: "GameLanguageTypeLs",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguageTypeLs_Languages_LanguageId",
                table: "GameLanguageTypeLs");

            migrationBuilder.DropIndex(
                name: "IX_GameLanguageTypeLs_LanguageId",
                table: "GameLanguageTypeLs");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "GameLanguageTypeLs");
        }
    }
}
