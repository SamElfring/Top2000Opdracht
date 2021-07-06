using Top2000.Models;

namespace Top2000.Controllers
{
    public class Top2000JaarController : Controller
    {
        private readonly db_a74225_top2000Context _context;

        public Top2000JaarController(db_a74225_top2000Context context)
        {
            _context = context;
        }

        // GET: Top2000Jaar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Top2000Jaars.ToListAsync());
        }

        // GET: Top2000Jaar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var top2000Jaar = await _context.Top2000Jaars
                .FirstOrDefaultAsync(m => m.Jaar == id);
            if (top2000Jaar == null)
            {
                return NotFound();
            }

            return View(top2000Jaar);
        }

        // GET: Top2000Jaar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Top2000Jaar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Jaar,Titel")] Top2000Jaar top2000Jaar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(top2000Jaar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(top2000Jaar);
        }

        // GET: Top2000Jaar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var top2000Jaar = await _context.Top2000Jaars.FindAsync(id);
            if (top2000Jaar == null)
            {
                return NotFound();
            }
            return View(top2000Jaar);
        }

        // POST: Top2000Jaar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Jaar,Titel")] Top2000Jaar top2000Jaar)
        {
            if (id != top2000Jaar.Jaar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(top2000Jaar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Top2000JaarExists(top2000Jaar.Jaar))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(top2000Jaar);
        }

        // GET: Top2000Jaar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var top2000Jaar = await _context.Top2000Jaars
                .FirstOrDefaultAsync(m => m.Jaar == id);
            if (top2000Jaar == null)
            {
                return NotFound();
            }

            return View(top2000Jaar);
        }

        // POST: Top2000Jaar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var top2000Jaar = await _context.Top2000Jaars.FindAsync(id);
            _context.Top2000Jaars.Remove(top2000Jaar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Top2000JaarExists(int id)
        {
            return _context.Top2000Jaars.Any(e => e.Jaar == id);
        }
    }
}
