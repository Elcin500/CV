using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CVProject.Migrations
{
    public partial class AppInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 9, 12, 33, 2, 598, DateTimeKind.Local).AddTicks(1562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 9, 11, 27, 59, 693, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.CreateTable(
                name: "AppInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    FacebookLink = table.Column<string>(nullable: true),
                    InstagramLink = table.Column<string>(nullable: true),
                    TwitterLink = table.Column<string>(nullable: true),
                    GithubLink = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppInfos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 9, 11, 27, 59, 693, DateTimeKind.Local).AddTicks(3365),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 9, 12, 33, 2, 598, DateTimeKind.Local).AddTicks(1562));
        }
    }
}
