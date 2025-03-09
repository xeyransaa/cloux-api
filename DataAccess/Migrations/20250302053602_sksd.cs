using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sksd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalNotes",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DiscountedPrice",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GooglePlusLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OriginalPrice",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "TwitchLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OSs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemReqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Memory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graphics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoundCard = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemReqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OSReqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OSId = table.Column<int>(type: "int", nullable: false),
                    SystemReqsId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    GameId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OSReqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OSReqs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OSReqs_Games_GameId1",
                        column: x => x.GameId1,
                        principalTable: "Games",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OSReqs_OSs_OSId",
                        column: x => x.OSId,
                        principalTable: "OSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OSReqs_SystemReqs_SystemReqsId",
                        column: x => x.SystemReqsId,
                        principalTable: "SystemReqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OSReqs_GameId",
                table: "OSReqs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OSReqs_GameId1",
                table: "OSReqs",
                column: "GameId1");

            migrationBuilder.CreateIndex(
                name: "IX_OSReqs_OSId",
                table: "OSReqs",
                column: "OSId");

            migrationBuilder.CreateIndex(
                name: "IX_OSReqs_SystemReqsId",
                table: "OSReqs",
                column: "SystemReqsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OSReqs");

            migrationBuilder.DropTable(
                name: "OSs");

            migrationBuilder.DropTable(
                name: "SystemReqs");

            migrationBuilder.DropColumn(
                name: "AdditionalNotes",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GooglePlusLink",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TwitchLink",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TwitterLink",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "YoutubeLink",
                table: "Games");
        }
    }
}
