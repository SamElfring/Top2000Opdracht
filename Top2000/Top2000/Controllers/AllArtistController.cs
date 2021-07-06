using Top2000.Models;

namespace Top2000.Controllers
{
    public class AllArtistController : Controller
    {
        private readonly db_a74225_top2000Context _context;

        public AllArtistController(db_a74225_top2000Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.spSelectAllArtist.FromSqlRaw("dbo.spSelectAllArtists").ToListAsync();
            return View(data);
        }
    }
}
