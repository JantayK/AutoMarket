using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMarket.Data.Migrations
{
    public partial class RemovedPathField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Adverts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Adverts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
