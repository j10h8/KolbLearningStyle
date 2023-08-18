using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolb_learning_style.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alternative_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alternative_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alternative_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alternative_4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tester = table.Column<int>(type: "int", nullable: false),
                    IdeaGiver = table.Column<int>(type: "int", nullable: false),
                    Gatherer = table.Column<int>(type: "int", nullable: false),
                    Explainer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ResultId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
