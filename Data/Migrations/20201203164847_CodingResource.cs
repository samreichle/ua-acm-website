using Microsoft.EntityFrameworkCore.Migrations;

namespace ua_acm_website.Data.Migrations
{
    public partial class CodingResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodingResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resource = table.Column<string>(nullable: true),
                    TopicCovered = table.Column<string>(nullable: true),
                    ApplicableClasses = table.Column<string>(nullable: true),
                    ResourceLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingResource", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodingResource");
        }
    }
}
