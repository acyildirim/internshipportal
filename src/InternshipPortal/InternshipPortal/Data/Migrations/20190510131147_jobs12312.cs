using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipPortal.Data.Migrations
{
    public partial class jobs12312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
                //name: "Deneme");

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Job",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Job");

            //migrationBuilder.CreateTable(
            //    name: "Deneme",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        category = table.Column<string>(nullable: true),
            //        company = table.Column<string>(nullable: true),
            //        contact_email = table.Column<string>(nullable: true),
            //        contact_user = table.Column<string>(nullable: true),
            //        description = table.Column<string>(nullable: true),
            //        job_title = table.Column<string>(nullable: true),
            //        location = table.Column<string>(nullable: true),
            //        salary = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Deneme", x => x.ID);
            //    });
        }
    }
}
