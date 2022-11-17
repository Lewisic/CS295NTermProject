using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject295N.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomebrewItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    ItemRarity = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: true),
                    ItemEffect = table.Column<string>(nullable: true),
                    Attunement = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomebrewItems", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomebrewItems");
        }
    }
}
