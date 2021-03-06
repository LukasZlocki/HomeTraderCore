﻿using System;
using System.Collections.Generic;
using System.Text;
using HomeTraderCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeTraderCore.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<GpwCompany> Company { get; set; }
        public DbSet<FinanceProfitAndLose> ProfitAndLose { get; set; }
        public DbSet<FinanceCashFlow> CashFlow { get; set; }
        public DbSet<FinanceBalance> Balance { get; set; }

    }
}
