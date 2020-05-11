using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTraderCore.Data.Migrations
{
    public partial class AddBalanceDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(nullable: false),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    AktywaTrwale = table.Column<int>(nullable: false),
                    AktywaObrotowe = table.Column<int>(nullable: false),
                    AktywaRazem = table.Column<int>(nullable: false),
                    KapitalWlasnyAkcjonariuszyJednostkiDominujacej = table.Column<int>(nullable: false),
                    UdzialyNiekontrolujace = table.Column<int>(nullable: false),
                    ZobowiazaniaDlugoterminowe = table.Column<int>(nullable: false),
                    ZobowiazaniaKrotkoterminowe = table.Column<int>(nullable: false),
                    PasywaRazem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balance");
        }
    }
}
