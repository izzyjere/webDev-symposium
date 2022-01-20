using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleApp.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestigationOfficerId",
                table: "Incidents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvestigationOfficerId",
                table: "Incidents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
