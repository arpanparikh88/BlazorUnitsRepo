using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorUnitsApp.Server.Migrations
{
    public partial class UnitsTableSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Ip_Address", "Latitude", "Longitude", "Name" },
                values: new object[] { 1, "162.191.107.130", 33.551769999999998, -112.13500000000001, "Unit One" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Ip_Address", "Latitude", "Longitude", "Name" },
                values: new object[] { 2, "162.191.107.130", 33.551740000000002, -112.1135, "Unit Two" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Ip_Address", "Latitude", "Longitude", "Name" },
                values: new object[] { 3, "162.191.107.130", 33.551729999999999, -112.1134, "Unit Three" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
