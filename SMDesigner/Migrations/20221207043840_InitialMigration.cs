using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SMDesigner.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentProgram",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConductorL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpenPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeakerFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermedNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosePrayer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentProgram", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentProgram");
        }
    }
}
