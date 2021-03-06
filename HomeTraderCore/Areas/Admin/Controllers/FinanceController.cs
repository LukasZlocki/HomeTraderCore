﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTraderCore.Data;
using HomeTraderCore.Models;
using HomeTraderCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeTraderCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FinanceController : Controller
    {
        private readonly ApplicationDBContext _db;

        private IEnumerable<GpwCompany> _gpwCompany { get; set; }


        public FinanceController(ApplicationDBContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }


        // GET - CashFlow (string)
        [HttpPost, ActionName("CashFlowBase")]
        [HttpPost]
        public async Task<IActionResult> CashFlowBase(string stockName)
        {
            // ToDo : handle with exceptions !

            // loading company data
            _gpwCompany = await _db.Company.Where(n => n.Name == stockName).ToListAsync();
            var _companyData = _gpwCompany.First();

            FinanceViewModel financeVM = new FinanceViewModel()
            {
                Company = _companyData,
                FinanceCashFlow = await _db.CashFlow.Where(n => n.ComapanyName == stockName).OrderByDescending(m => m.RaportYear).ToListAsync(),
                FinanceCashFlowDescription = new Models.FinanceCashFlow(),
            };
            return View("CashFlow", financeVM);
        }

        // GET - CashFlow (int)
        //[HttpPost]
        public async Task<IActionResult> CashFlow(int id)
        {
            // ToDo : handle with exceptions !

            // loading company data
            _gpwCompany = await _db.Company.Where(n => n.Id == id).ToListAsync();
            var _companyData = _gpwCompany.First();

            FinanceViewModel financeVM = new FinanceViewModel()
            {
                Company = _companyData,
                FinanceCashFlow = await _db.CashFlow.Where(n => n.CompanyId == id).OrderByDescending(m => m.RaportYear).ToListAsync(),           
                FinanceCashFlowDescription = new Models.FinanceCashFlow(),  
            };
            return View(financeVM);
        }


        // GET - Profit And Lose
        public async Task<IActionResult> ProfitAndLose(int id)
        {
            // ToDo : handle with exceptions !

            // loading company data
            _gpwCompany = await _db.Company.Where(n => n.Id == id).ToListAsync();
            var _companyData = _gpwCompany.First();

            FinanceViewModel financeVM = new FinanceViewModel()
            {
                Company = _companyData,
                FinanceProfitAndLose = await _db.ProfitAndLose.Where(n => n.CompanyId == _companyData.Id).OrderByDescending(m => m.RaportYear).ToListAsync(),
                FinanceProfitAndLoseDescription = new Models.FinanceProfitAndLose()
            };

            return View(financeVM);
        }


        // GET - Balance
        public async Task<IActionResult> Balance(int id)
        {
            // ToDo : handle with exceptions !

            // loading company data
            _gpwCompany = await _db.Company.Where(n => n.Id == id).ToListAsync();
            var _companyData = _gpwCompany.First();

            FinanceViewModel financeVM = new FinanceViewModel()
            {
                Company = _companyData,
                FinanceBalance = await _db.Balance.Where(n => n.CompanyId == _companyData.Id).OrderByDescending(m => m.RaportYear).ToListAsync(),
                FinanceBalanceDescription = new Models.FinanceBalance()
            };

            return View(financeVM);
        }




    }
}