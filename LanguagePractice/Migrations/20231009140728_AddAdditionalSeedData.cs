using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ImperfectWords",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[,]
                {
                    { 4, "facevamo", "facevo", "fare", "facevate", "facevi", "facevano", "facevama" },
                    { 5, "andavamo", "andavo", "andare", "andavate", "andavi", "andavano", "andava" },
                    { 6, "vivevamo", "vivevo", "vìvere", "vivevate", "vivevi", "vivevano", "viveva" },
                    { 7, "dormivamo", "dormivo", "dormire", "dormivate", "dormivi", "dormivano", "dormiva" },
                    { 8, "chiedevamo", "chiedevo", "chiedere", "chiedevate", "chiedevi", "chiedevano", "chiedeva" },
                    { 9, "mettevamo", "mettevo", "mettere", "mettevate", "mettevi", "mettevano", "metteva" },
                    { 10, "vestivamo", "vestivo", "vestire", "vestivate", "vestivi", "vestivano", "vestiva" }
                });

            migrationBuilder.InsertData(
                table: "PresentIndicativeWords",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[,]
                {
                    { 4, "veniamo", "vengo", "venire", "venite", "vieni", "vengono", "viene" },
                    { 5, "andiamo", "vado", "andare", "andate", "vai", "vanno", "va" },
                    { 6, "viviamo", "vivo", "vìvere", "vivete", "vivi", "vivono", "vive" },
                    { 7, "dormiamo", "dormo", "dormire", "dormite", "dormi", "dormono", "dorme" },
                    { 8, "chiediamo", "chiedo", "chiedere", "chiedete", "chiedi", "chiedono", "chiede" },
                    { 9, "mettiamo", "metto", "mettere", "mettete", "metti", "mettono", "mette" },
                    { 10, "vestiamo", "vesto", "vestire", "vestite", "vesti", "vestono", "veste" }
                });

            migrationBuilder.InsertData(
                table: "PresentPerfectPhrases",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular", "UsesEssere" },
                values: new object[,]
                {
                    { 4, "siamo venuto", "sono venuto", "venire", "siete venuto", "sei venuto", "sono venuto", "è venuto", true },
                    { 5, "abbiamo fatto", "ho fatto", "fare", "avete fatto", "hai fatto", "hanno fatto", "ha fatto", false },
                    { 6, "abbiamo vissuto", "ho vissuto", "vìvere", "avete vissuto", "hai vissuto", "hanno vissuto", "ha vissuto", false },
                    { 7, "abbiamo dormito", "ho dormito", "dormire", "avete dormito", "hai dormito", "hanno dormito", "ha dormito", false },
                    { 8, "abbiamo chiesto", "ho chiesto", "chiedere", "avete chiesto", "hai chiesto", "hanno chiesto", "ha chiesto", false },
                    { 9, "abbiamo messo", "ho messo", "mettere", "avete messo", "hai messo", "hanno messo", "ha messo", false },
                    { 10, "abbiamo vestito", "ho vestito", "vestire", "avete vestito", "hai vestito", "hanno vestito", "ha vestito", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
