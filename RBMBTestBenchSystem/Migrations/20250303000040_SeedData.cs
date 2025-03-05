using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RBMBTestBenchSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bearings",
                columns: new[] { "BearingId", "MaxRotationSpeed", "Model" },
                values: new object[,]
                {
                    { 1, 2400, "alpha" },
                    { 2, 2865, "beta" },
                    { 3, 3100, "gamma" },
                    { 4, 3000, "delta" },
                    { 5, 2750, "epsilon" },
                    { 6, 3300, "zeta" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bearings",
                keyColumn: "BearingId",
                keyValue: 6);
        }
    }
}
