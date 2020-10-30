using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class AddProductContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "PrinterInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Material",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Ingredient",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PopupId = table.Column<int>(nullable: true),
                    FoodTypeId = table.Column<int>(nullable: true),
                    IsGlutenFree = table.Column<bool>(nullable: false),
                    IsVagen = table.Column<bool>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    IsAvaliable = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_FoodType_FoodTypeId",
                        column: x => x.FoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Popup_PopupId",
                        column: x => x.PopupId,
                        principalTable: "Popup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrinterInfo_ProductId",
                table: "PrinterInfo",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_ProductId",
                table: "Material",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_ProductId",
                table: "Ingredient",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FoodTypeId",
                table: "Product",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PopupId",
                table: "Product",
                column: "PopupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Product_ProductId",
                table: "Ingredient",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Product_ProductId",
                table: "Material",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterInfo_Product_ProductId",
                table: "PrinterInfo",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Product_ProductId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Product_ProductId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_PrinterInfo_Product_ProductId",
                table: "PrinterInfo");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropIndex(
                name: "IX_PrinterInfo_ProductId",
                table: "PrinterInfo");

            migrationBuilder.DropIndex(
                name: "IX_Material_ProductId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_ProductId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PrinterInfo");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Ingredient");
        }
    }
}
