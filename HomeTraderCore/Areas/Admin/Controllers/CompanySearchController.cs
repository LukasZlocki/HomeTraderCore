using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeTraderCore.Data;

namespace HomeTraderCore.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanySearchController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public CompanySearchController(ApplicationDBContext db)
        {
            _db = db;
        }


        // GET - financial profit and lose
        [Produces("application/json")]
       // [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var companyName = _db.Company.Where(p => p.Name.Contains(term))
                    .Select(p => p.Name).ToList();
                return Ok(companyName);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


    }
}