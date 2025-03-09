using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class skjd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Languages_LanguageId",
                table: "GameLanguage");

            migrationBuilder.DropColumn(
                name: "AudioLanguageId",
                table: "GameLanguage");

            migrationBuilder.DropColumn(
                name: "InterfaceLanguageId",
                table: "GameLanguage");

            migrationBuilder.RenameColumn(
                name: "SubtitleLanguageId",
                table: "GameLanguage",
                newName: "LanguageTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "GameLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LanguageType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLanguage_LanguageTypeId",
                table: "GameLanguage",
                column: "LanguageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_LanguageType_LanguageTypeId",
                table: "GameLanguage",
                column: "LanguageTypeId",
                principalTable: "LanguageType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Languages_LanguageId",
                table: "GameLanguage",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_LanguageType_LanguageTypeId",
                table: "GameLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Languages_LanguageId",
                table: "GameLanguage");

            migrationBuilder.DropTable(
                name: "LanguageType");

            migrationBuilder.DropIndex(
                name: "IX_GameLanguage_LanguageTypeId",
                table: "GameLanguage");

            migrationBuilder.RenameColumn(
                name: "LanguageTypeId",
                table: "GameLanguage",
                newName: "SubtitleLanguageId");

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "GameLanguage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AudioLanguageId",
                table: "GameLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InterfaceLanguageId",
                table: "GameLanguage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Languages_LanguageId",
                table: "GameLanguage",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");
        }
    }
}
