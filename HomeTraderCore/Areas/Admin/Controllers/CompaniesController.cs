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
    public class CompaniesController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CompaniesController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET - Company
        public async Task<IActionResult> Index()
        {
            return View(await _db.Company.ToListAsync());
        }
    }
}