using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTraderCore.Data.Migrations
{
    public partial class ProfitandloseAddToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfitAndLose",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    PrzychodyZeSprzedazy = table.Column<int>(nullable: false),
                    ZyskZeSprzedazy = table.Column<int>(nullable: false),
                    ZyskOperacyjny = table.Column<int>(nullable: false),
                    ZyskZDzialalnosciGospodarczej = table.Column<int>(nullable: false),
                    ZyskPrzedOpodatkowaniem = table.Column<int>(nullable: false),
                    ZyskNetto = table.Column<int>(nullable: false),
                    ZyskNettoAkcjonariuszyJednostkiDominujacej = table.Column<int>(nullable: false),
                    EBITDA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitAndLose", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfitAndLose");
        }
    }
}
