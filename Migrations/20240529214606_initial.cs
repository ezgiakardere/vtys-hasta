using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kıvıl.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    HastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    EgzersizYapıyorMu = table.Column<bool>(type: "bit", nullable: false),
                    AileGecmisi = table.Column<bool>(type: "bit", nullable: false),
                    SigaraKullanımı = table.Column<bool>(type: "bit", nullable: false),
                    AlkolKullanımı = table.Column<bool>(type: "bit", nullable: false),
                    KalpKriziRiski = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.HastaId);
                });

            migrationBuilder.CreateTable(
                name: "Testler",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KanBasıcı = table.Column<int>(type: "int", nullable: false),
                    Kolestrol = table.Column<int>(type: "int", nullable: false),
                    KanSekeri = table.Column<int>(type: "int", nullable: false),
                    HastaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testler", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_Testler_Hastalar_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastalar",
                        principalColumn: "HastaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Testler_HastaId",
                table: "Testler",
                column: "HastaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testler");

            migrationBuilder.DropTable(
                name: "Hastalar");
        }
    }
}
