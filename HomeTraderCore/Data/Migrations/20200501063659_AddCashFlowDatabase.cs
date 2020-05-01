using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTraderCore.Data.Migrations
{
    public partial class AddCashFlowDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashFlow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciOperacyjnej = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciInvestycyjnej = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciFinansowej = table.Column<int>(nullable: false),
                    PrzeplywyRazem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashFlow", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashFlow");
        }
    }
}
