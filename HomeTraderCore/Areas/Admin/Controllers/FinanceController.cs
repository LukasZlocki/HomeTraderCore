using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTraderCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTraderCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FinanceController : Controller
    {
        private readonly ApplicationDBContext _db;

        public FinanceController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET - financial profit and lose
        public async Task<IActionResult> Index()
        {
            return View(await _db.ProfitAndLose.ToListAsync());
        }

        // GET - CashFlow
        public async Task<IActionResult> CashFlow()
        {
            return View();
        }

        // GET - Balance
        public async Task<IActionResult> Balance()
        {
            return View();
        }
    }
}