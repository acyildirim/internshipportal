using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipPortal.Data.Migrations
{
    public partial class job5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Job",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Job",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
