using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoMarket.Data.Migrations
{
    public partial class ChangedFieldsInDomainModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Adverts_AdvertId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AdvertId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AdvertId1",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AdvertId",
                table: "Comments",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Adverts_AdvertId",
                table: "Comments",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Adverts_AdvertId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AdvertId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "AdvertId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdvertId1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AdvertId1",
                table: "Comments",
                column: "AdvertId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Adverts_AdvertId1",
                table: "Comments",
                column: "AdvertId1",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
