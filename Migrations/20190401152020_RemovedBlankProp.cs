using Microsoft.EntityFrameworkCore.Migrations;

namespace adatabaseoficeandfire.Migrations
{
    public partial class RemovedBlankProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Houses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Houses",
                nullable: false,
                defaultValue: 0);
        }
    }
}
