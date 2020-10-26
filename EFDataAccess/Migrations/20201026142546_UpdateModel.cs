using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClockStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffPosition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffPosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ClockStatusId = table.Column<int>(nullable: false),
                    StaffPositionId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_ClockStatus_ClockStatusId",
                        column: x => x.ClockStatusId,
                        principalTable: "ClockStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_StaffPosition_StaffPositionId",
                        column: x => x.StaffPositionId,
                        principalTable: "StaffPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffTimesheet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(nullable: true),
                    ClockIn = table.Column<DateTime>(nullable: false),
                    ClockOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTimesheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffTimesheet_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClockStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "In" },
                    { 2, "Out" }
                });

            migrationBuilder.InsertData(
                table: "StaffPosition",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Manager" },
                    { 3, "Staff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_ClockStatusId",
                table: "Staff",
                column: "ClockStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Password",
                table: "Staff",
                column: "Password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_StaffPositionId",
                table: "Staff",
                column: "StaffPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTimesheet_StaffId",
                table: "StaffTimesheet",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffTimesheet");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "ClockStatus");

            migrationBuilder.DropTable(
                name: "StaffPosition");
        }
    }
}
