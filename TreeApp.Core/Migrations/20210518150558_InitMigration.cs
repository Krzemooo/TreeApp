using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeApp.Core.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tree",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemValue = table.Column<string>(nullable: true),
                    ItemLevel = table.Column<int>(nullable: false),
                    ItemPosition = table.Column<int>(nullable: false),
                    UniqItemID = table.Column<Guid>(nullable: false),
                    ParentUniqID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tree", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tree");
        }
    }
}
