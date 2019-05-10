using Microsoft.EntityFrameworkCore.Migrations;

namespace MiningProject.Migrations.TruckLocationDb
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Location_LocationID1",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Trucks_TruckID1",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_LocationID1",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_TruckID1",
                table: "History");

            migrationBuilder.DropColumn(
                name: "LocationID1",
                table: "History");

            migrationBuilder.DropColumn(
                name: "TruckID1",
                table: "History");

            migrationBuilder.AlterColumn<long>(
                name: "TruckID",
                table: "History",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "LocationID",
                table: "History",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_History_LocationID",
                table: "History",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_History_TruckID",
                table: "History",
                column: "TruckID");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Location_LocationID",
                table: "History",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Trucks_TruckID",
                table: "History",
                column: "TruckID",
                principalTable: "Trucks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Location_LocationID",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Trucks_TruckID",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_LocationID",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_TruckID",
                table: "History");

            migrationBuilder.AlterColumn<int>(
                name: "TruckID",
                table: "History",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "History",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "LocationID1",
                table: "History",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TruckID1",
                table: "History",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_History_LocationID1",
                table: "History",
                column: "LocationID1");

            migrationBuilder.CreateIndex(
                name: "IX_History_TruckID1",
                table: "History",
                column: "TruckID1");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Location_LocationID1",
                table: "History",
                column: "LocationID1",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Trucks_TruckID1",
                table: "History",
                column: "TruckID1",
                principalTable: "Trucks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
