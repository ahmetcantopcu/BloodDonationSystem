using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_donor_evaluation_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DonorID",
                table: "Evaluations",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_DonorID",
                table: "Evaluations",
                column: "DonorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Donors_DonorID",
                table: "Evaluations",
                column: "DonorID",
                principalTable: "Donors",
                principalColumn: "DonorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Donors_DonorID",
                table: "Evaluations");

            migrationBuilder.DropIndex(
                name: "IX_Evaluations_DonorID",
                table: "Evaluations");

            migrationBuilder.DropColumn(
                name: "DonorID",
                table: "Evaluations");
        }
    }
}
