using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EvaluationID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EvaluationID",
                table: "Comments",
                column: "EvaluationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Evaluations_EvaluationID",
                table: "Comments",
                column: "EvaluationID",
                principalTable: "Evaluations",
                principalColumn: "EvaluationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Evaluations_EvaluationID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EvaluationID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EvaluationID",
                table: "Comments");
        }
    }
}
