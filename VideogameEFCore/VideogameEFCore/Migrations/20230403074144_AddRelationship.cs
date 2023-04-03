using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideogameEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SoftwareHouseId",
                table: "Videogames",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_SoftwareHouseId",
                table: "Videogames",
                column: "SoftwareHouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_SoftwareHouses_SoftwareHouseId",
                table: "Videogames",
                column: "SoftwareHouseId",
                principalTable: "SoftwareHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_SoftwareHouses_SoftwareHouseId",
                table: "Videogames");

            migrationBuilder.DropIndex(
                name: "IX_Videogames_SoftwareHouseId",
                table: "Videogames");

            migrationBuilder.DropColumn(
                name: "SoftwareHouseId",
                table: "Videogames");
        }
    }
}
