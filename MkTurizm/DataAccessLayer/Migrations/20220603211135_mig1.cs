using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerTc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassengerTel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Station1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Station2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.StationId);
                });

            migrationBuilder.CreateTable(
                name: "BusServices",
                columns: table => new
                {
                    BusServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusServices", x => x.BusServiceId);
                    table.ForeignKey(
                        name: "FK_BusServices_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "StationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    BusServiceId = table.Column<int>(type: "int", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    PnrNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.BusServiceId, x.SeatNo });
                    table.ForeignKey(
                        name: "FK_Reservations_BusServices_BusServiceId",
                        column: x => x.BusServiceId,
                        principalTable: "BusServices",
                        principalColumn: "BusServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[,]
                {
                    { 1, "İstanbul" },
                    { 2, "Bolu" },
                    { 3, "Kocaeli" },
                    { 4, "Karabük" },
                    { 5, "Adana" },
                    { 6, "Gaziantep" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "PassengerName", "PassengerTc", "PassengerTel" },
                values: new object[] { 1, "Murat Kuşcan", "2545897468", "5364665961" });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "SeatNo" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 30, 30 },
                    { 29, 29 },
                    { 28, 28 },
                    { 27, 27 },
                    { 26, 26 },
                    { 25, 25 },
                    { 24, 24 },
                    { 23, 23 },
                    { 1, 1 },
                    { 21, 21 },
                    { 20, 20 },
                    { 19, 19 },
                    { 17, 17 },
                    { 22, 22 },
                    { 15, 15 },
                    { 3, 3 },
                    { 16, 16 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 4, 4 },
                    { 10, 10 },
                    { 9, 9 },
                    { 14, 14 },
                    { 18, 18 },
                    { 12, 12 },
                    { 11, 11 },
                    { 13, 13 }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "FromCity", "Price", "Station1", "Station2", "ToCity" },
                values: new object[,]
                {
                    { 11, "İstabul", 500, "Adana", "Bolu", "Gaziantep" },
                    { 1, "Karabük", 300, "Kocaeli", "Bolu", "İstanbul" },
                    { 2, "Gaziantep", 500, "Bolu", "Adana", "İstanbul" },
                    { 4, "Kocaeli", 100, "", "", "İstanbul" },
                    { 5, "Adana", 400, "", "", "İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "FromCity", "Price", "Station1", "Station2", "ToCity" },
                values: new object[,]
                {
                    { 6, "İstanbul", 300, "", "", "Karabük" },
                    { 7, "Kocaeli", 200, "", "", "Karabük" },
                    { 8, "Bolu", 100, "", "", "Karabük" },
                    { 9, "Adana", 200, "", "", "Gaziantep" },
                    { 10, "Bolu", 400, "", "", "Gaziantep" },
                    { 3, "Bolu", 200, "", "", "İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "BusServices",
                columns: new[] { "BusServiceId", "Date", "StationId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 14, new DateTime(2022, 5, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 2, new DateTime(2022, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 12, new DateTime(2022, 5, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 15, new DateTime(2022, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 3, new DateTime(2022, 5, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 13, new DateTime(2022, 5, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 4, new DateTime(2022, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 5, new DateTime(2022, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 6, new DateTime(2022, 5, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 7, new DateTime(2022, 5, 12, 14, 0, 0, 0, DateTimeKind.Unspecified), 7, true },
                    { 8, new DateTime(2022, 5, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), 8, true },
                    { 9, new DateTime(2022, 5, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), 9, true },
                    { 10, new DateTime(2022, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 10, true },
                    { 11, new DateTime(2022, 5, 12, 23, 0, 0, 0, DateTimeKind.Unspecified), 11, true }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "BusServiceId", "SeatNo", "PassengerId", "PnrNo" },
                values: new object[] { 1, 10, 1, 25302530 });

            migrationBuilder.CreateIndex(
                name: "IX_BusServices_StationId",
                table: "BusServices",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PassengerId",
                table: "Reservations",
                column: "PassengerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "BusServices");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
