using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace carrentalmanagmennt.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4321), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4327), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4328), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4923), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4928), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5501), "3 series", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5506), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5508), "3 Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5511), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
