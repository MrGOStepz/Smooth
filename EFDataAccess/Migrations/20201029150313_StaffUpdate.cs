using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class StaffUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_ClockStatus_ClockStatusId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_StaffPosition_StaffPositionId",
                table: "Staff");

            migrationBuilder.AlterColumn<int>(
                name: "StaffPositionId",
                table: "Staff",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClockStatusId",
                table: "Staff",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_ClockStatus_ClockStatusId",
                table: "Staff",
                column: "ClockStatusId",
                principalTable: "ClockStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_StaffPosition_StaffPositionId",
                table: "Staff",
                column: "StaffPositionId",
                principalTable: "StaffPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_ClockStatus_ClockStatusId",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_StaffPosition_StaffPositionId",
                table: "Staff");

            migrationBuilder.AlterColumn<int>(
                name: "StaffPositionId",
                table: "Staff",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClockStatusId",
                table: "Staff",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_ClockStatus_ClockStatusId",
                table: "Staff",
                column: "ClockStatusId",
                principalTable: "ClockStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_StaffPosition_StaffPositionId",
                table: "Staff",
                column: "StaffPositionId",
                principalTable: "StaffPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
