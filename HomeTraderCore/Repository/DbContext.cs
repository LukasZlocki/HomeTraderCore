using HomeTraderCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTraderCore.Repository
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        DbSet<GpwCompany>PolishCompanies { get; set; }
        DbSet<FinanceBalance> BalanceData { get; set; }
        DbSet<FinanceCashFlow> CashFlowData { get; set; }
        DbSet<FinanceProfitAndLose> ProfitAndLoseData { get; set; }

    }
}
