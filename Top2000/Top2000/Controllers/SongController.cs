using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Top2000.Models;

namespace Top2000.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            Song song = new Song
            {
                Songid = 0,
                Titel = "Hallo",
                Artiestid = 5656,
                Jaar = 2006
            };

            return View(song);
        }
    }
}
