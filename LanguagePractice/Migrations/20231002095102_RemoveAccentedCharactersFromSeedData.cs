using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAccentedCharactersFromSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "vedevamo", "vedevo", "vedevate", "vedevi", "vedevano", "vedeva" });

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "parlavamo", "parlavo", "parlare", "parlavate", "parlavi", "parlavano", "parlava" });

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "venivamo", "venivo", "venire", "venivate", "venivi", "venivano", "veniva" });

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "facciamo", "faccio", "fare", "fate", "fai", "fanno", "fa" });

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "vediamo", "vedo", "vedere", "vedete", "vedi", "vedono", "vede" });

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "parliamo", "parlo", "parlare", "parlate", "parli", "parlano", "parla" });

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Infinitive",
                value: "preparare");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 2,
                column: "Infinitive",
                value: "vendere");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "vedevàmo", "védevo", "vedevàte", "vedévi", "vedévano", "vedéva" });

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "parlavàmo", "parlàvo", "parlàre", "parlavàte", "parlàvi", "parlàvano", "parlàva" });

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[] { "venivàmo", "venìvo", "venìre", "venivàte", "venìvi", "venìvano", "venìva" });

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

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Infinitive",
                value: "preparàre");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 2,
                column: "Infinitive",
                value: "véndere");
        }
    }
}
