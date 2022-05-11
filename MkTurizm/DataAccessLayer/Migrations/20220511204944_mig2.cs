using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusServices",
                columns: table => new
                {
                    BusServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusServices", x => x.BusServiceId);
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
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    BusServiceId = table.Column<int>(type: "int", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.ReservationId, x.SeatNo, x.BusServiceId });
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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BusServiceId",
                table: "Reservations",
                column: "BusServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PassengerId",
                table: "Reservations",
                column: "PassengerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "BusServices");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}
