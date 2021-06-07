using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Top2000.Models;

namespace Top2000.Controllers
{
    public class Top2000Controller : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
    }
}
