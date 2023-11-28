using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace carrentalmanagmennt.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "93ba8e5b-4b48-49ac-bac8-69be1c2bfcd2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGo36wTjlxQj8kUFSoxOZUkJVRBC4Fzy7QvNTrUE0SmeFRv6dQ5qxcnm9DV8ZgXdUw==", null, false, "a9842dae-ced7-4f44-a4eb-2cbcecb82c20", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 819, DateTimeKind.Local).AddTicks(9307), new DateTime(2023, 11, 28, 15, 12, 15, 819, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 819, DateTimeKind.Local).AddTicks(9342), new DateTime(2023, 11, 28, 15, 12, 15, 819, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(61), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 11, 28, 15, 12, 15, 820, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4327), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 11, 28, 14, 51, 32, 789, DateTimeKind.Local).AddTicks(5511) });
        }
    }
}
