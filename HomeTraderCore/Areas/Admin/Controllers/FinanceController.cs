using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTraderCore.Data;
using HomeTraderCore.Models.ViewModels;
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

        
        public async Task<IActionResult> Index()
        {
            return View();
        }
       

        // GET - CashFlow
        [HttpPost]
        public async Task<IActionResult> CashFlow(string stockName)
        {
            CashFlowViewModel CashFlowVM = new CashFlowViewModel()
            {
                FinanceCashFlow = await _db.CashFlow.Where(n => n.ComapanyName == stockName).OrderByDescending(m => m.RaportYear).ToListAsync(),
                StockName = stockName,
                FinanceCashFlowDescription = new Models.FinanceCashFlow()
            };
            return View(CashFlowVM);
        }

        // GET - Balance
        public async Task<IActionResult> Balance()
        {
            return View();
        }
    }
}