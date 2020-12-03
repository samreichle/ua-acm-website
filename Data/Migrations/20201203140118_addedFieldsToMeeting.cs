using Microsoft.EntityFrameworkCore.Migrations;

namespace ua_acm_website.Data.Migrations
{
    public partial class addedFieldsToMeeting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Meeting");

            migrationBuilder.AddColumn<int>(
                name: "Attendance",
                table: "Meeting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recruiter",
                table: "Meeting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attendance",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Recruiter",
                table: "Meeting");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Meeting",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
