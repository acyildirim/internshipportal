using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipPortal.Data.Migrations
{
    public partial class job1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Job",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Job",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Job");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Job",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
