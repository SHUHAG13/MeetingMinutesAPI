using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetingMinutesAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTableDatausingDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CorporateCustomers",
                columns: new[] { "CorporateId", "CorporateName" },
                values: new object[,]
                {
                    { 1, "Shuhag" },
                    { 2, "Nihal" },
                    { 3, "Imran" }
                });

            migrationBuilder.InsertData(
                table: "IndividualCustomers",
                columns: new[] { "IndividualId", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "Alice Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "Unit" },
                values: new object[,]
                {
                    { 1, "Product A", "kg" },
                    { 2, "Product B", "pcs" },
                    { 3, "Service C", "hour" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CorporateCustomers",
                keyColumn: "CorporateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CorporateCustomers",
                keyColumn: "CorporateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CorporateCustomers",
                keyColumn: "CorporateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IndividualCustomers",
                keyColumn: "IndividualId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IndividualCustomers",
                keyColumn: "IndividualId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IndividualCustomers",
                keyColumn: "IndividualId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
