using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class ChangePortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Portfolios",
                newName: "WebName");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "WebUrl");

            migrationBuilder.AddColumn<string>(
                name: "BigImageUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SmallImageUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigImageUrl",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "SmallImageUrl",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "WebUrl",
                table: "Portfolios",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "WebName",
                table: "Portfolios",
                newName: "Name");
        }
    }
}
