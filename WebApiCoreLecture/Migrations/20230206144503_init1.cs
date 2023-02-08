using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCoreLecture.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "DesignationID",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "Doj",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "IsMarried",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "TblDesignation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TblDesignation");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "TblEmployee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignationID",
                table: "TblEmployee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Doj",
                table: "TblEmployee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TblEmployee",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TblEmployee",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "TblEmployee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsMarried",
                table: "TblEmployee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "TblEmployee",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TblEmployee",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "TblDesignation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "DesignationID",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Doj",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "IsMarried",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TblEmployee");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "TblDesignation");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "TblEmployee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "TblDesignation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignationID",
                table: "TblDesignation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Doj",
                table: "TblDesignation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TblDesignation",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TblDesignation",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "TblDesignation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IsMarried",
                table: "TblDesignation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "TblDesignation",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TblDesignation",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);
        }
    }
}
