using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMvsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "This is the first entry in the diary.", new DateTime(2025, 2, 11, 12, 31, 6, 9, DateTimeKind.Local).AddTicks(2739), "First Entry" },
                    { 2, "This is the second entry in the diary.", new DateTime(2025, 2, 11, 12, 31, 6, 9, DateTimeKind.Local).AddTicks(3069), "Second Entry" },
                    { 3, "This is the third entry in the diary.", new DateTime(2025, 2, 11, 12, 31, 6, 9, DateTimeKind.Local).AddTicks(3073), "Third Entry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
