using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DuiMing = table.Column<string>(nullable: true),
                    Half = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    ChuPanJiao = table.Column<string>(nullable: true),
                    DangQianJiao = table.Column<string>(nullable: true),
                    SheZheng = table.Column<string>(nullable: true),
                    ShePian = table.Column<string>(nullable: true),
                    ChuPanRang = table.Column<string>(nullable: true),
                    DangQianRang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
