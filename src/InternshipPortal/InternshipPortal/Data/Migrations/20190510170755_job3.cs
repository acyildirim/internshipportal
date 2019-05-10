using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipPortal.Data.Migrations
{
    public partial class job3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Job",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Job",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Job");
        }
    }
}
