using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_blood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bloods_Bloods_BloodID1",
                table: "Bloods");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Bloods_BloodID",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_BloodID",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Bloods_BloodID1",
                table: "Bloods");

            migrationBuilder.DropColumn(
                name: "BloodID",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "BloodID1",
                table: "Bloods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodID",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BloodID1",
                table: "Bloods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_BloodID",
                table: "Donations",
                column: "BloodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bloods_BloodID1",
                table: "Bloods",
                column: "BloodID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bloods_Bloods_BloodID1",
                table: "Bloods",
                column: "BloodID1",
                principalTable: "Bloods",
                principalColumn: "BloodID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Bloods_BloodID",
                table: "Donations",
                column: "BloodID",
                principalTable: "Bloods",
                principalColumn: "BloodID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
