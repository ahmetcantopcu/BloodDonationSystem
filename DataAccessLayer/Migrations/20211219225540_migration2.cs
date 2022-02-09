using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
