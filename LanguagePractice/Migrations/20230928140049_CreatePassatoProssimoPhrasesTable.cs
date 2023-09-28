using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class CreatePassatoProssimoPhrasesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PresentIndicatives",
                table: "PresentIndicatives");

            migrationBuilder.RenameTable(
                name: "PresentIndicatives",
                newName: "PresentIndicativeWords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresentIndicativeWords",
                table: "PresentIndicativeWords",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PassatoProssimoPhrases",
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

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "facciàmo", "fàccio", "fàre", "fàte", "fài", "fànno", "fà" });

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "vediàmo", "védo", "vedére", "vedéte", "védi", "védono", "véde" });

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "parliàmo", "pàrlo", "parlàre", "parlàte", "pàrli", "pàrlano", "pàrla" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassatoProssimoPhrases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PresentIndicativeWords",
                table: "PresentIndicativeWords");

            migrationBuilder.RenameTable(
                name: "PresentIndicativeWords",
                newName: "PresentIndicatives");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PresentIndicatives",
                table: "PresentIndicatives",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "PresentIndicatives",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "facciamo", "faccio", "fare", "fate", "fai", "fanno", "fa" });

            migrationBuilder.UpdateData(
                table: "PresentIndicatives",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "vediamo", "vedo", "vedere", "vedete", "vedi", "vedono", "vede" });

            migrationBuilder.UpdateData(
                table: "PresentIndicatives",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "parliamo", "parlo", "parlare", "parlate", "parla", "parlano", "parla" });
        }
    }
}
