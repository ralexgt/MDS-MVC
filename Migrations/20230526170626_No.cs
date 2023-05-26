using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1Calendar.Migrations
{
    /// <inheritdoc />
    public partial class No : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "No",
                table: "Race",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Winner",
                table: "Race",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "No",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "Winner",
                table: "Race");
        }
    }
}
