using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_important : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Donations_DonationID",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Donors_DonationID",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "DonationID",
                table: "Donors");

            migrationBuilder.AddColumn<int>(
                name: "DonorID",
                table: "Donations",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonorID",
                table: "Donations",
                column: "DonorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Donors_DonorID",
                table: "Donations",
                column: "DonorID",
                principalTable: "Donors",
                principalColumn: "DonorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Donors_DonorID",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_DonorID",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonorID",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "DonationID",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donors_DonationID",
                table: "Donors",
                column: "DonationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Donations_DonationID",
                table: "Donors",
                column: "DonationID",
                principalTable: "Donations",
                principalColumn: "DonationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}