using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class AddEnglishTranslations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnglishTranslation",
                table: "PresentPerfectPhrases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTranslation",
                table: "PresentIndicativeWords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTranslation",
                table: "ImperfectWords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnglishTranslation",
                value: "to see/look at");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnglishTranslation",
                value: "to talk");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 3,
                column: "EnglishTranslation",
                value: "to come");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 4,
                column: "EnglishTranslation",
                value: "to do/make");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 5,
                column: "EnglishTranslation",
                value: "to go");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 6,
                column: "EnglishTranslation",
                value: "to live");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 7,
                column: "EnglishTranslation",
                value: "to sleep");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 8,
                column: "EnglishTranslation",
                value: "to ask");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 9,
                column: "EnglishTranslation",
                value: "to put");

            migrationBuilder.UpdateData(
                table: "ImperfectWords",
                keyColumn: "Id",
                keyValue: 10,
                column: "EnglishTranslation",
                value: "to dress");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnglishTranslation",
                value: "to do/make");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnglishTranslation",
                value: "to see/look at");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 3,
                column: "EnglishTranslation",
                value: "to talk");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 4,
                column: "EnglishTranslation",
                value: "to come");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 5,
                column: "EnglishTranslation",
                value: "to go");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 6,
                column: "EnglishTranslation",
                value: "to live");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 7,
                column: "EnglishTranslation",
                value: "to sleep");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 8,
                column: "EnglishTranslation",
                value: "to ask");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 9,
                column: "EnglishTranslation",
                value: "to put");

            migrationBuilder.UpdateData(
                table: "PresentIndicativeWords",
                keyColumn: "Id",
                keyValue: 10,
                column: "EnglishTranslation",
                value: "to dress");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 1,
                column: "EnglishTranslation",
                value: "to prepare");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 2,
                column: "EnglishTranslation",
                value: "to sell");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 3,
                column: "EnglishTranslation",
                value: "to go");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 4,
                column: "EnglishTranslation",
                value: "to come");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 5,
                column: "EnglishTranslation",
                value: "to do/make");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 6,
                column: "EnglishTranslation",
                value: "to live");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 7,
                column: "EnglishTranslation",
                value: "to sleep");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 8,
                column: "EnglishTranslation",
                value: "to ask");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 9,
                column: "EnglishTranslation",
                value: "to put");

            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 10,
                column: "EnglishTranslation",
                value: "to dress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishTranslation",
                table: "PresentPerfectPhrases");

            migrationBuilder.DropColumn(
                name: "EnglishTranslation",
                table: "PresentIndicativeWords");

            migrationBuilder.DropColumn(
                name: "EnglishTranslation",
                table: "ImperfectWords");
        }
    }
}
