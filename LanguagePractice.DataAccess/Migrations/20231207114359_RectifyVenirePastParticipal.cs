using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class RectifyVenirePastParticipal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstPersonPlural", "SecondPersonPlural", "ThirdPersonPlural" },
                values: new object[] { "siamo venuti", "siete venuti", "sono venuti" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PresentPerfectPhrases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstPersonPlural", "SecondPersonPlural", "ThirdPersonPlural" },
                values: new object[] { "siamo venuto", "siete venuto", "sono venuto" });
        }
    }
}
