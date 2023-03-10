using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskNoSSL.Migrations
{
    /// <inheritdoc />
    public partial class DBStructureNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentDirName",
                table: "Dirs");

            migrationBuilder.AddColumn<int>(
                name: "ParentDirId",
                table: "Dirs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentDirId",
                table: "Dirs");

            migrationBuilder.AddColumn<string>(
                name: "ParentDirName",
                table: "Dirs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
