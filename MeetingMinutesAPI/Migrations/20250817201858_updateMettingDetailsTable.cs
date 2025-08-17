using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingMinutesAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMettingDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttendsFromClient",
                table: "MeetingMinutesMasters",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AttendsFromHost",
                table: "MeetingMinutesMasters",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingAgenda",
                table: "MeetingMinutesMasters",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingDecision",
                table: "MeetingMinutesMasters",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingDiscussion",
                table: "MeetingMinutesMasters",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingPlace",
                table: "MeetingMinutesMasters",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttendsFromClient",
                table: "MeetingMinutesMasters");

            migrationBuilder.DropColumn(
                name: "AttendsFromHost",
                table: "MeetingMinutesMasters");

            migrationBuilder.DropColumn(
                name: "MeetingAgenda",
                table: "MeetingMinutesMasters");

            migrationBuilder.DropColumn(
                name: "MeetingDecision",
                table: "MeetingMinutesMasters");

            migrationBuilder.DropColumn(
                name: "MeetingDiscussion",
                table: "MeetingMinutesMasters");

            migrationBuilder.DropColumn(
                name: "MeetingPlace",
                table: "MeetingMinutesMasters");
        }
    }
}
