using Microsoft.EntityFrameworkCore.Migrations;

namespace ua_acm_website.Data.Migrations
{
    public partial class addedMemberFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeetingsAttended",
                table: "Member",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Member",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeetingsAttended",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Member");
        }
    }
}
