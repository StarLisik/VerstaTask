using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerstaTask.Migrations
{
    /// <inheritdoc />
    public partial class AdjustNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdressSender",
                table: "Orders",
                newName: "AddressSender");

            migrationBuilder.RenameColumn(
                name: "AdressReceiver",
                table: "Orders",
                newName: "AddressReceiver");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressSender",
                table: "Orders",
                newName: "AdressSender");

            migrationBuilder.RenameColumn(
                name: "AddressReceiver",
                table: "Orders",
                newName: "AdressReceiver");
        }
    }
}
