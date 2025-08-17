using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingMinutesAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CorporateCustomers",
                columns: table => new
                {
                    CorporateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorporateName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateCustomers", x => x.CorporateId);
                });

            migrationBuilder.CreateTable(
                name: "IndividualCustomers",
                columns: table => new
                {
                    IndividualId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualCustomers", x => x.IndividualId);
                });

            migrationBuilder.CreateTable(
                name: "MeetingMinutesMasters",
                columns: table => new
                {
                    MasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorporateId = table.Column<int>(type: "int", nullable: true),
                    IndividualId = table.Column<int>(type: "int", nullable: true),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingMinutesMasters", x => x.MasterId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "MeetingMinutesDetails",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingMinutesDetails", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_MeetingMinutesDetails_MeetingMinutesMasters_MasterId",
                        column: x => x.MasterId,
                        principalTable: "MeetingMinutesMasters",
                        principalColumn: "MasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetingMinutesDetails_MasterId",
                table: "MeetingMinutesDetails",
                column: "MasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorporateCustomers");

            migrationBuilder.DropTable(
                name: "IndividualCustomers");

            migrationBuilder.DropTable(
                name: "MeetingMinutesDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MeetingMinutesMasters");
        }
    }
}
