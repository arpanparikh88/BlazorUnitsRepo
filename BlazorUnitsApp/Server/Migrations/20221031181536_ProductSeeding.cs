using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorUnitsApp.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The original, first radio series comes from a proposal called \"The Ends of the Earth\": six self-contained episodes, all ending with Earth being destroyed in a different way. While writing the first episode, Adams realised that he needed someone on the planet who was an alien to provide some context, and that this alien needed a reason to be there. Adams finally settled on making the alien a roving researcher for a \"wholly remarkable book\" named The Hitchhiker's Guide to the Galaxy.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The HitchHikers Guide To The Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Sorrento asks mercenary i-R0k to learn Wade's true identity, intending to bribe him to win the contest on IOI's behalf. Wade and Art3mis discover from the Journals that Halliday once dated Morrow's wife Karen \"Kira\" Underwood. ", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 5.55m, "Ready Player One" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
