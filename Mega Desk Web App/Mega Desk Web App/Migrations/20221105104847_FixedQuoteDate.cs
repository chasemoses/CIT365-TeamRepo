using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mega_Desk_Web_App.Migrations
{
    public partial class FixedQuoteDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "QuoteDate",
                table: "Quote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteDate",
                table: "Quote");
        }
    }
}
