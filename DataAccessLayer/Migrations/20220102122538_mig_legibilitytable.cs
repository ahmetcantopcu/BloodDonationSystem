using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_legibilitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvaluationLegibilities",
                columns: table => new
                {
                    EvaluationLegibilityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvaluationID = table.Column<int>(type: "int", nullable: false),
                    EvaluationTotalScore = table.Column<int>(type: "int", nullable: false),
                    EvaluationLegibilityCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationLegibilities", x => x.EvaluationLegibilityID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationLegibilities");
        }
    }
}
