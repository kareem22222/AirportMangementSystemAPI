using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication8.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightDetailsModels",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightModel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetailsModels", x => x.FlightId);
                });

            migrationBuilder.CreateTable(
                name: "FlightTravelInfos",
                columns: table => new
                {
                    FlightTravelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightArrivingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightDepartureLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightTravelInfos", x => x.FlightTravelId);
                    table.ForeignKey(
                        name: "FK_FlightTravelInfos_FlightDetailsModels_FlightId",
                        column: x => x.FlightId,
                        principalTable: "FlightDetailsModels",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightTravelInfos_FlightId",
                table: "FlightTravelInfos",
                column: "FlightId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightTravelInfos");

            migrationBuilder.DropTable(
                name: "FlightDetailsModels");
        }
    }
}
