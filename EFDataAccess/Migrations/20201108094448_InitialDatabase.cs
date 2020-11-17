using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClockStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CookStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TotalOrder = table.Column<int>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Popup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrinterInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrintType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffPosition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffPosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    TabOrder = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PopupItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    PopupId = table.Column<int>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopupItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PopupItem_Popup_PopupId",
                        column: x => x.PopupId,
                        principalTable: "Popup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PopupId = table.Column<int>(nullable: true),
                    FoodTypeId = table.Column<int>(nullable: true),
                    IsGlutenFree = table.Column<bool>(nullable: false),
                    IsVagen = table.Column<bool>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    IsAvaliable = table.Column<bool>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
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
                    StaffPositionId = table.Column<int>(nullable: true),
                    ClockStatusId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_StaffPosition_StaffPositionId",
                        column: x => x.StaffPositionId,
                        principalTable: "StaffPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TableInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    TableSectionId = table.Column<int>(nullable: true),
                    MarginTop = table.Column<float>(nullable: false),
                    MarginBottom = table.Column<float>(nullable: false),
                    MarginLeft = table.Column<float>(nullable: false),
                    MarginRight = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableInfo_TableSection_TableSectionId",
                        column: x => x.TableSectionId,
                        principalTable: "TableSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrinterProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrinterInfoId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrinterProduct_PrinterInfo_PrinterInfoId",
                        column: x => x.PrinterInfoId,
                        principalTable: "PrinterInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrinterProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrintLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePrint = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<int>(nullable: true),
                    PrintTypeId = table.Column<int>(nullable: true),
                    Detail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrintLog_PrintType_PrintTypeId",
                        column: x => x.PrintTypeId,
                        principalTable: "PrintType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrintLog_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeOrder = table.Column<DateTime>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: true),
                    OrderTypeId = table.Column<int>(nullable: true),
                    StaffId = table.Column<int>(nullable: true),
                    TableInfoId = table.Column<int>(nullable: true),
                    PaymentTypeId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderType_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_PaymentType_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_TableInfo_TableInfoId",
                        column: x => x.TableInfoId,
                        principalTable: "TableInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOrder = table.Column<DateTime>(nullable: false),
                    StaffId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    PopupItemId = table.Column<int>(nullable: true),
                    CookStatusId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderInfo_CookStatus_CookStatusId",
                        column: x => x.CookStatusId,
                        principalTable: "CookStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfo_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfo_PopupItem_PopupItemId",
                        column: x => x.PopupItemId,
                        principalTable: "PopupItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfo_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderInfo_Staff_StaffId",
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
                name: "IX_Ingredient_ProductId",
                table: "Ingredient",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_ProductId",
                table: "Material",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderTypeId",
                table: "Order",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentTypeId",
                table: "Order",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StaffId",
                table: "Order",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TableInfoId",
                table: "Order",
                column: "TableInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_CookStatusId",
                table: "OrderInfo",
                column: "CookStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_OrderId",
                table: "OrderInfo",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_PopupItemId",
                table: "OrderInfo",
                column: "PopupItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_ProductId",
                table: "OrderInfo",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfo_StaffId",
                table: "OrderInfo",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PopupItem_PopupId",
                table: "PopupItem",
                column: "PopupId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterProduct_PrinterInfoId",
                table: "PrinterProduct",
                column: "PrinterInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterProduct_ProductId",
                table: "PrinterProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintLog_PrintTypeId",
                table: "PrintLog",
                column: "PrintTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PrintLog_StaffId",
                table: "PrintLog",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FoodTypeId",
                table: "Product",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PopupId",
                table: "Product",
                column: "PopupId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TableInfo_TableSectionId",
                table: "TableInfo",
                column: "TableSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "OrderInfo");

            migrationBuilder.DropTable(
                name: "PrinterProduct");

            migrationBuilder.DropTable(
                name: "PrintLog");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "StaffTimesheet");

            migrationBuilder.DropTable(
                name: "CookStatus");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PopupItem");

            migrationBuilder.DropTable(
                name: "PrinterInfo");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "PrintType");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "TableInfo");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "Popup");

            migrationBuilder.DropTable(
                name: "ClockStatus");

            migrationBuilder.DropTable(
                name: "StaffPosition");

            migrationBuilder.DropTable(
                name: "TableSection");
        }
    }
}
