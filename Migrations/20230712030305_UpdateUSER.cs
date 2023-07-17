using Microsoft.EntityFrameworkCore.Migrations;

namespace webapp.Migrations
{
    public partial class UpdateUSER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Home",
                table: "Users",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Home",
                table: "Users");
        }
    }
}
