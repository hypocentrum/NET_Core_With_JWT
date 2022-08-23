using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mHealthBank_Fariz.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nama = table.Column<string>(type: "TEXT", nullable: true),
                    Alamat = table.Column<string>(type: "TEXT", nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JenisKelamin = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageProfileUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
