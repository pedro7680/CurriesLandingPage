using Microsoft.EntityFrameworkCore.Migrations;

namespace LandingPageRazor.Migrations
{
    public partial class AmendedContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "emailAddress",
                table: "Contact",
                newName: "EmailAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Contact",
                newName: "emailAddress");
        }
    }
}
