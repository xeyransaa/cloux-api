using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class kdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDeveloper_Developer_DeveloperId",
                table: "GameDeveloper");

            migrationBuilder.DropForeignKey(
                name: "FK_GameDeveloper_Games_GameId",
                table: "GameDeveloper");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguageTypeL_Games_GameId",
                table: "GameLanguageTypeL");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguageTypeL_LanguageTypeL_LanguageTypeLId",
                table: "GameLanguageTypeL");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageTypeL_LanguageType_LanguageTypeId",
                table: "LanguageTypeL");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageTypeL_Languages_LanguageId",
                table: "LanguageTypeL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTypeL",
                table: "LanguageTypeL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageType",
                table: "LanguageType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameLanguageTypeL",
                table: "GameLanguageTypeL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameDeveloper",
                table: "GameDeveloper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developer",
                table: "Developer");

            migrationBuilder.RenameTable(
                name: "LanguageTypeL",
                newName: "LanguageTypeLs");

            migrationBuilder.RenameTable(
                name: "LanguageType",
                newName: "LanguageTypes");

            migrationBuilder.RenameTable(
                name: "GameLanguageTypeL",
                newName: "GameLanguageTypeLs");

            migrationBuilder.RenameTable(
                name: "GameDeveloper",
                newName: "GameDevelopers");

            migrationBuilder.RenameTable(
                name: "Developer",
                newName: "Developers");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTypeL_LanguageTypeId",
                table: "LanguageTypeLs",
                newName: "IX_LanguageTypeLs_LanguageTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTypeL_LanguageId",
                table: "LanguageTypeLs",
                newName: "IX_LanguageTypeLs_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguageTypeL_LanguageTypeLId",
                table: "GameLanguageTypeLs",
                newName: "IX_GameLanguageTypeLs_LanguageTypeLId");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguageTypeL_GameId",
                table: "GameLanguageTypeLs",
                newName: "IX_GameLanguageTypeLs_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameDeveloper_GameId",
                table: "GameDevelopers",
                newName: "IX_GameDevelopers_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameDeveloper_DeveloperId",
                table: "GameDevelopers",
                newName: "IX_GameDevelopers_DeveloperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTypeLs",
                table: "LanguageTypeLs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTypes",
                table: "LanguageTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameLanguageTypeLs",
                table: "GameLanguageTypeLs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameDevelopers",
                table: "GameDevelopers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDevelopers_Developers_DeveloperId",
                table: "GameDevelopers",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameDevelopers_Games_GameId",
                table: "GameDevelopers",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguageTypeLs_Games_GameId",
                table: "GameLanguageTypeLs",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguageTypeLs_LanguageTypeLs_LanguageTypeLId",
                table: "GameLanguageTypeLs",
                column: "LanguageTypeLId",
                principalTable: "LanguageTypeLs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageTypeLs_LanguageTypes_LanguageTypeId",
                table: "LanguageTypeLs",
                column: "LanguageTypeId",
                principalTable: "LanguageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageTypeLs_Languages_LanguageId",
                table: "LanguageTypeLs",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameDevelopers_Developers_DeveloperId",
                table: "GameDevelopers");

            migrationBuilder.DropForeignKey(
                name: "FK_GameDevelopers_Games_GameId",
                table: "GameDevelopers");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguageTypeLs_Games_GameId",
                table: "GameLanguageTypeLs");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguageTypeLs_LanguageTypeLs_LanguageTypeLId",
                table: "GameLanguageTypeLs");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageTypeLs_LanguageTypes_LanguageTypeId",
                table: "LanguageTypeLs");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageTypeLs_Languages_LanguageId",
                table: "LanguageTypeLs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTypes",
                table: "LanguageTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTypeLs",
                table: "LanguageTypeLs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameLanguageTypeLs",
                table: "GameLanguageTypeLs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameDevelopers",
                table: "GameDevelopers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.RenameTable(
                name: "LanguageTypes",
                newName: "LanguageType");

            migrationBuilder.RenameTable(
                name: "LanguageTypeLs",
                newName: "LanguageTypeL");

            migrationBuilder.RenameTable(
                name: "GameLanguageTypeLs",
                newName: "GameLanguageTypeL");

            migrationBuilder.RenameTable(
                name: "GameDevelopers",
                newName: "GameDeveloper");

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "Developer");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTypeLs_LanguageTypeId",
                table: "LanguageTypeL",
                newName: "IX_LanguageTypeL_LanguageTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTypeLs_LanguageId",
                table: "LanguageTypeL",
                newName: "IX_LanguageTypeL_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguageTypeLs_LanguageTypeLId",
                table: "GameLanguageTypeL",
                newName: "IX_GameLanguageTypeL_LanguageTypeLId");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguageTypeLs_GameId",
                table: "GameLanguageTypeL",
                newName: "IX_GameLanguageTypeL_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameDevelopers_GameId",
                table: "GameDeveloper",
                newName: "IX_GameDeveloper_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameDevelopers_DeveloperId",
                table: "GameDeveloper",
                newName: "IX_GameDeveloper_DeveloperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageType",
                table: "LanguageType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTypeL",
                table: "LanguageTypeL",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameLanguageTypeL",
                table: "GameLanguageTypeL",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameDeveloper",
                table: "GameDeveloper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developer",
                table: "Developer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameDeveloper_Developer_DeveloperId",
                table: "GameDeveloper",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameDeveloper_Games_GameId",
                table: "GameDeveloper",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguageTypeL_Games_GameId",
                table: "GameLanguageTypeL",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguageTypeL_LanguageTypeL_LanguageTypeLId",
                table: "GameLanguageTypeL",
                column: "LanguageTypeLId",
                principalTable: "LanguageTypeL",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageTypeL_LanguageType_LanguageTypeId",
                table: "LanguageTypeL",
                column: "LanguageTypeId",
                principalTable: "LanguageType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageTypeL_Languages_LanguageId",
                table: "LanguageTypeL",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
