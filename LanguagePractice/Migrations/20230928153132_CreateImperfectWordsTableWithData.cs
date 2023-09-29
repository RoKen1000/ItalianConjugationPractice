using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class CreateImperfectWordsTableWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImperfectWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Infinitive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImperfectWords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ImperfectWords",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[,]
                {
                    { 1, "vedevàmo", "védevo", "vedere", "vedevàte", "vedévi", "vedévano", "vedéva" },
                    { 2, "parlavàmo", "parlàvo", "parlàre", "parlavàte", "parlàvi", "parlàvano", "parlàva" },
                    { 3, "venivàmo", "venìvo", "venìre", "venivàte", "venìvi", "venìvano", "venìva" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImperfectWords");
        }
    }
}
