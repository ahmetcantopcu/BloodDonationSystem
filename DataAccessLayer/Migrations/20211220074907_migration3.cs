using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodID",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donors_BloodID",
                table: "Donors",
                column: "BloodID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Bloods_BloodID",
                table: "Donors",
                column: "BloodID",
                principalTable: "Bloods",
                principalColumn: "BloodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Bloods_BloodID",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Donors_BloodID",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "BloodID",
                table: "Donors");
        }
    }
}
