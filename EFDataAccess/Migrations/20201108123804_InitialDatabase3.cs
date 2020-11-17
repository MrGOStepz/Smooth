using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class InitialDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrinterProduct_PrinterInfo_PrinterInfoId",
                table: "PrinterProduct");

            migrationBuilder.DropIndex(
                name: "IX_PrinterProduct_PrinterInfoId",
                table: "PrinterProduct");

            migrationBuilder.AlterColumn<int>(
                name: "PrinterInfoId",
                table: "PrinterProduct",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrinterInfoId",
                table: "PrinterProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PrinterProduct_PrinterInfoId",
                table: "PrinterProduct",
                column: "PrinterInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterProduct_PrinterInfo_PrinterInfoId",
                table: "PrinterProduct",
                column: "PrinterInfoId",
                principalTable: "PrinterInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
