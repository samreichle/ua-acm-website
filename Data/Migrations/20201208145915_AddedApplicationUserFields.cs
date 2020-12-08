using Microsoft.EntityFrameworkCore.Migrations;

namespace ua_acm_website.Data.Migrations
{
    public partial class AddedApplicationUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DuesPaid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeetingsAttended",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuesPaid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MeetingsAttended",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "AspNetUsers");
        }
    }
}
