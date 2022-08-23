using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mHealthBank_Fariz.Migrations
{
    public partial class Rev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserProfiles",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserProfiles");
        }
    }
}
