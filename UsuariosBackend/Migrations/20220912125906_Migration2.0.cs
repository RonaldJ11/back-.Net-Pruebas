using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosBackend.Migrations
{
    public partial class Migration20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "User",
                type: "nvarchar(2)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "User");
        }
    }
}
