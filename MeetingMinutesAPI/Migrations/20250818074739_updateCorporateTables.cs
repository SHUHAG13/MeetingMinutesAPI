﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingMinutesAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateCorporateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");
        }
    }
}
