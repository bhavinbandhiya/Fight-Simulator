using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class UserCharactreRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Userid",
                table: "Characters",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_User_Userid",
                table: "Characters",
                column: "Userid",
                principalTable: "User",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_User_Userid",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_Userid",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Characters");
        }
    }
}
