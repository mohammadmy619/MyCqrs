using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayear.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Prodcuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Prodcuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Prodcuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Prodcuts",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Prodcuts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Prodcuts");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Prodcuts");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Prodcuts");
        }
    }
}
