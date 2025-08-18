using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingMinutesAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateCorporateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CorporateName",
                table: "CorporateCustomers",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CorporateCustomers",
                newName: "CorporateName");
        }
    }
}
