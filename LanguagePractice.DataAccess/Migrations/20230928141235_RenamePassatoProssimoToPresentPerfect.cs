using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class RenamePassatoProssimoToPresentPerfect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassatoProssimoPhrases");

            migrationBuilder.CreateTable(
                name: "PresentPerfectPhrases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Infinitive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsesEssere = table.Column<bool>(type: "bit", nullable: false),
                    FirstPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentPerfectPhrases", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PresentPerfectPhrases",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular", "UsesEssere" },
                values: new object[,]
                {
                    { 1, "abbiamo preparato", "ho preparato", "preparàre", "avete preparato", "hai preparato", "hanno preparato", "ha preparato", false },
                    { 2, "abbiamo venduto", "ho venduto", "véndere", "avete venduto", "hai venduto", "hanno venduto", "ha venduto", false },
                    { 3, "siamo andati", "sono andato", "andare", "siete andati", "sei andato", "sono andati", "è andato", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PresentPerfectPhrases");

            migrationBuilder.CreateTable(
                name: "PassatoProssimoPhrases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Infinitive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonPlural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPersonSingular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsesEssere = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassatoProssimoPhrases", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PassatoProssimoPhrases",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular", "UsesEssere" },
                values: new object[,]
                {
                    { 1, "abbiamo preparato", "ho preparato", "preparàre", "avete preparato", "hai preparato", "hanno preparato", "ha preparato", false },
                    { 2, "abbiamo venduto", "ho venduto", "véndere", "avete venduto", "hai venduto", "hanno venduto", "ha venduto", false },
                    { 3, "siamo andati", "sono andato", "andare", "siete andati", "sei andato", "sono andati", "è andato", true }
                });
        }
    }
}
