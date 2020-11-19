using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVProject.Migrations
{
    public partial class ChanOnStudy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Studies");

            migrationBuilder.AddColumn<string>(
                name: "DiplomaPath",
                table: "Studies",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                nullable: false,
                defaultValueSql: "dateadd(hour,4,getutcdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 9, 12, 33, 2, 598, DateTimeKind.Local).AddTicks(1562));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiplomaPath",
                table: "Studies");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Studies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 9, 12, 33, 2, 598, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "dateadd(hour,4,getutcdate())");
        }
    }
}
