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


        // GET - Company by Wig20
        public async Task<IActionResult> IndexSort(int id)
        {
            string _sort="";

            if (id == 1 ) { _sort = "Wig20"; }
            if (id == 2 ) { _sort = "mWig40"; }
            if (id == 3 ) { _sort = "sWig80"; }

            var _result = await _db.Company.Where(n => n.Index == _sort).ToListAsync();

            return View("Index",_result);
        }


    }
}