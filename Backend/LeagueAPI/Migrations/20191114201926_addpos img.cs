using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueAPI.Migrations
{
    public partial class addposimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Positions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "./images/TopLane.png");

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "./images/JungleLane.png");

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "./images/MiddleLane.png");

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "./images/ADCLane.png");

            migrationBuilder.UpdateData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "./images/SupportLane.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Positions");
        }
    }
}
