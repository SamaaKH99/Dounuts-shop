using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Donuts_shop.Migrations
{
    public partial class orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_Donuts_D_Id",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_O_Id",
                table: "orderDetails");

            migrationBuilder.DropIndex(
                name: "IX_orderDetails_D_Id",
                table: "orderDetails");

            migrationBuilder.DropIndex(
                name: "IX_orderDetails_O_Id",
                table: "orderDetails");

            migrationBuilder.DropColumn(
                name: "D_Id",
                table: "orderDetails");

            migrationBuilder.DropColumn(
                name: "O_Id",
                table: "orderDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "orders",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "orders",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailConfirm",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_DonutId",
                table: "orderDetails",
                column: "DonutId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_OrderId",
                table: "orderDetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_Donuts_DonutId",
                table: "orderDetails",
                column: "DonutId",
                principalTable: "Donuts",
                principalColumn: "DonutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_Donuts_DonutId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails");

            migrationBuilder.DropIndex(
                name: "IX_orderDetails_DonutId",
                table: "orderDetails");

            migrationBuilder.DropIndex(
                name: "IX_orderDetails_OrderId",
                table: "orderDetails");

            migrationBuilder.DropColumn(
                name: "City",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "EmailConfirm",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "orders");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "orders",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "orders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "D_Id",
                table: "orderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "O_Id",
                table: "orderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_D_Id",
                table: "orderDetails",
                column: "D_Id");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetails_O_Id",
                table: "orderDetails",
                column: "O_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_Donuts_D_Id",
                table: "orderDetails",
                column: "D_Id",
                principalTable: "Donuts",
                principalColumn: "DonutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_O_Id",
                table: "orderDetails",
                column: "O_Id",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
