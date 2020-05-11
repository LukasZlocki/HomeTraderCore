using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTraderCore.Data.Migrations
{
    public partial class ExtendWithComanyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ProfitAndLose",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "CashFlow",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ProfitAndLose");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "CashFlow");
        }
    }
}
