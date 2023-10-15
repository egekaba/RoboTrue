using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SozlesmeDurumsController : Controller
    {
        private readonly SqlDbContext _context;

        public SozlesmeDurumsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SozlesmeDurums
        public async Task<IActionResult> Index()
        {
            return _context.SozlesmeDurums != null ?
                        View(await _context.SozlesmeDurums.ToListAsync()) :
                        Problem("Entity set 'SqlDbContext.SozlesmeDurums'  is null.");
        }

        // GET: Admin/SozlesmeDurums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SozlesmeDurums == null)
            {
                return NotFound();
            }

            var sozlesmeDurum = await _context.SozlesmeDurums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeDurum == null)
            {
                return NotFound();
            }

            return View(sozlesmeDurum);
        }

        // GET: Admin/SozlesmeDurums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SozlesmeDurums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SozlesmeDurumu,SozlesmeBaslangıcTarihi,SozlesmeBitis,Id,CreateDate")] SozlesmeDurum sozlesmeDurum)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(sozlesmeDurum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sozlesmeDurum);
        }

        // GET: Admin/SozlesmeDurums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SozlesmeDurums == null)
            {
                return NotFound();
            }

            var sozlesmeDurum = await _context.SozlesmeDurums.FindAsync(id);
            if (sozlesmeDurum == null)
            {
                return NotFound();
            }
            return View(sozlesmeDurum);
        }

        // POST: Admin/SozlesmeDurums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SozlesmeDurumu,SozlesmeBaslangıcTarihi,SozlesmeBitis,Id,CreateDate")] SozlesmeDurum sozlesmeDurum)
        {
            if (id != sozlesmeDurum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sozlesmeDurum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SozlesmeDurumExists(sozlesmeDurum.Id))
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
            return View(sozlesmeDurum);
        }

        // GET: Admin/SozlesmeDurums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SozlesmeDurums == null)
            {
                return NotFound();
            }

            var sozlesmeDurum = await _context.SozlesmeDurums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sozlesmeDurum == null)
            {
                return NotFound();
            }

            return View(sozlesmeDurum);
        }

        // POST: Admin/SozlesmeDurums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SozlesmeDurums == null)
            {
                return Problem("Entity set 'SqlDbContext.SozlesmeDurums'  is null.");
            }
            var sozlesmeDurum = await _context.SozlesmeDurums.FindAsync(id);
            if (sozlesmeDurum != null)
            {
                _context.SozlesmeDurums.Remove(sozlesmeDurum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SozlesmeDurumExists(int id)
        {
            return (_context.SozlesmeDurums?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
