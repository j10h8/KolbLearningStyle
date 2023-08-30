using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace kolb_learning_style.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "ResultId", "Explainer", "Gatherer", "IdeaGiver", "Tester" },
                values: new object[,]
                {
                    { 1, 20, 8, 5, 20 },
                    { 2, 9, 15, 12, 17 },
                    { 3, 8, 14, 17, 12 },
                    { 4, 12, 19, 6, 11 },
                    { 5, 10, 17, 9, 16 },
                    { 6, 5, 10, 6, 6 },
                    { 7, 13, 5, 16, 19 },
                    { 8, 14, 5, 17, 14 },
                    { 9, 9, 11, 18, 6 },
                    { 10, 13, 11, 15, 18 },
                    { 11, 20, 13, 9, 20 },
                    { 12, 17, 20, 20, 5 },
                    { 13, 16, 17, 19, 14 },
                    { 14, 19, 8, 17, 18 },
                    { 15, 14, 17, 18, 19 },
                    { 16, 20, 15, 14, 7 },
                    { 17, 5, 19, 10, 19 },
                    { 18, 18, 20, 8, 17 },
                    { 19, 11, 14, 14, 15 },
                    { 20, 18, 19, 7, 20 },
                    { 21, 11, 14, 14, 7 },
                    { 22, 19, 19, 7, 8 },
                    { 23, 15, 14, 16, 20 },
                    { 24, 7, 11, 9, 12 },
                    { 25, 13, 10, 8, 20 },
                    { 26, 13, 11, 10, 11 },
                    { 27, 6, 9, 20, 10 },
                    { 28, 15, 19, 9, 7 },
                    { 29, 6, 15, 9, 16 },
                    { 30, 19, 12, 18, 20 },
                    { 31, 8, 12, 17, 20 },
                    { 32, 8, 8, 18, 7 },
                    { 33, 8, 20, 12, 14 },
                    { 34, 6, 7, 18, 17 },
                    { 35, 20, 7, 12, 20 },
                    { 36, 16, 18, 10, 16 },
                    { 37, 12, 9, 14, 20 },
                    { 38, 14, 6, 19, 11 },
                    { 39, 20, 14, 16, 6 },
                    { 40, 12, 7, 5, 11 },
                    { 41, 6, 18, 13, 19 },
                    { 42, 19, 16, 9, 18 },
                    { 43, 18, 9, 8, 17 },
                    { 44, 18, 6, 18, 10 },
                    { 45, 5, 19, 16, 7 },
                    { 46, 20, 18, 6, 20 },
                    { 47, 11, 8, 11, 14 },
                    { 48, 12, 9, 16, 11 },
                    { 49, 19, 14, 14, 20 },
                    { 50, 8, 6, 18, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "ResultId",
                keyValue: 50);
        }
    }
}
