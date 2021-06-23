using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Top2000.Models;

namespace Top2000.Controllers
{
    public class Top10LijstController : Controller
    {
        private readonly db_a74225_top2000Context _context;

        public Top10LijstController(db_a74225_top2000Context context)
        {
            _context = context;
        }

        // GET: Top10Lijst
        [Route("top10lijst/{searchYear?}")]
        public async Task<IActionResult> Index(string searchYear)
        {
            string year = searchYear;
            if (String.IsNullOrEmpty(searchYear))
            {
                year = "2019";
            }
            ViewBag.year = year;
            ViewBag.isData = true;

            var data = await _context.spSelectTop10ListingOnYear
                .FromSqlRaw("dbo.spSelectTop10ListingOnYear @Top2000jaar", new SqlParameter("Top2000jaar", year))
                .ToListAsync();

            if (data.Count() == 0) // Check if data is empty
            {
                ViewBag.isData = false;
            }

            return View(data);
        }
    }
}
