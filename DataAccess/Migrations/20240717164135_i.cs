using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "Link", "Name" },
                values: new object[,]
                {
                    { 1, "https://www.facebook.com", "Facebook" },
                    { 2, "https://www.twitter.com", "Twitter" },
                    { 3, "https://www.plus.google.com", "Google Plus" },
                    { 4, "https://www.youtube.com", "Youtube" },
                    { 5, "https://www.instagram.com", "Instagram" },
                    { 6, "https://www.twitch.tv", "Twitch" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
