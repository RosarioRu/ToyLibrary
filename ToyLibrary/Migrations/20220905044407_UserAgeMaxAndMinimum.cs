using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyLibrary.Migrations
{
    public partial class UserAgeMaxAndMinimum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypicalUserAge",
                table: "Toys",
                newName: "UserAgeMinimum");

            migrationBuilder.AddColumn<int>(
                name: "UserAgeMaximum",
                table: "Toys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAgeMaximum",
                table: "Toys");

            migrationBuilder.RenameColumn(
                name: "UserAgeMinimum",
                table: "Toys",
                newName: "TypicalUserAge");
        }
    }
}
