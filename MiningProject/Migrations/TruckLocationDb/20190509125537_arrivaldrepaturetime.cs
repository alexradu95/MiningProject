using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiningProject.Migrations.TruckLocationDb
{
    public partial class arrivaldrepaturetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "History",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "History",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "History");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "History");
        }
    }
}
