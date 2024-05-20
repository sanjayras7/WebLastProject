using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteWebApi.Migrations
{
    /// <inheritdoc />
    public partial class FeedbackMiogration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bFeedbackTable",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bFeedbackTable", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bFeedbackTable");
        }
    }
}
