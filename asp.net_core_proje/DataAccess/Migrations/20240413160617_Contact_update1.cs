using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Contact_update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutID",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AboutID",
                table: "Contacts",
                column: "AboutID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Abouts_AboutID",
                table: "Contacts",
                column: "AboutID",
                principalTable: "Abouts",
                principalColumn: "AboutID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Abouts_AboutID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AboutID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AboutID",
                table: "Contacts");
        }
    }
}
