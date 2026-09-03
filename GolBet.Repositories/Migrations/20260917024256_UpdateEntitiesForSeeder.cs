using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolBet.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesForSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShieldUrl",
                table: "Teams",
                newName: "CrestUrl");

            migrationBuilder.RenameColumn(
                name: "HomeScore",
                table: "Matches",
                newName: "HomeGoals");

            migrationBuilder.RenameColumn(
                name: "AwayScore",
                table: "Matches",
                newName: "AwayGoals");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CrestUrl",
                table: "Teams",
                newName: "ShieldUrl");

            migrationBuilder.RenameColumn(
                name: "HomeGoals",
                table: "Matches",
                newName: "HomeScore");

            migrationBuilder.RenameColumn(
                name: "AwayGoals",
                table: "Matches",
                newName: "AwayScore");
        }
    }
}
