using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstBlog.Migrations
{
    /// <inheritdoc />
    public partial class RenameImageColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageSrc",
                table: "Posts",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Posts",
                newName: "ImageFile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Posts",
                newName: "ImageSrc");

            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Posts",
                newName: "Image");
        }
    }
}
