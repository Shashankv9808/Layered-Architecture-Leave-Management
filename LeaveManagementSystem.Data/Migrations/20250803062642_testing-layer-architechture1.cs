using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class testinglayerarchitechture1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c25edb0-e14e-46ea-a155-401cd22ba74e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b40a4b7-25cb-4a12-8c98-304e12d46fcf", "AQAAAAIAAYagAAAAEJ3roRgO+SNQXMboRbnVRXyhe7OhSj3lpJ+M7Y8zfPzYFqy5FUGcNotbSYl4ROfGiw==", "f6386a15-4513-40eb-834a-7918a0469a0b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c25edb0-e14e-46ea-a155-401cd22ba74e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52dc9a8c-12cc-4abb-998d-cbd514e9e863", "AQAAAAIAAYagAAAAEEQsWyeGjzdzWT7GvCGvKKna2HAD0ZxpZ+fhZj+qhuNC1t6WOBjW3vTQW/WCwZCVWA==", "092f41a6-7dff-4f61-bf81-740b2b664bd3" });
        }
    }
}
