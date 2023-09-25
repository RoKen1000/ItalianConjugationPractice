using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanguagePracticeSite.Migrations
{
    /// <inheritdoc />
    public partial class CreatePresentIndicativeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PresentIndicatives",
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
                    table.PrimaryKey("PK_PresentIndicatives", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PresentIndicatives",
                columns: new[] { "Id", "FirstPersonPlural", "FirstPersonSingular", "Infinitive", "SecondPersonPlural", "SecondPersonSingular", "ThirdPersonPlural", "ThirdPersonSingular" },
                values: new object[,]
                {
                    { 1, "facciamo", "faccio", "fare", "fate", "fai", "fanno", "fa" },
                    { 2, "vediamo", "vedo", "vedere", "vedete", "vedi", "vedono", "vede" },
                    { 3, "parliamo", "parlo", "parlare", "parlate", "parla", "parlano", "parla" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PresentIndicatives");
        }
    }
}
