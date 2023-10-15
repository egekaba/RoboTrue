using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CariFaliyetSektorusController : Controller
    {
        private readonly SqlDbContext _context;

        public CariFaliyetSektorusController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CariFaliyetSektorus
        public async Task<IActionResult> Index()
        {
            return _context.CariFaliyetSektorus != null ?
                        View(await _context.CariFaliyetSektorus.ToListAsync()) :
                        Problem("Entity set 'SqlDbContext.CariFaliyetSektorus'  is null.");
        }

        // GET: Admin/CariFaliyetSektorus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CariFaliyetSektorus == null)
            {
                return NotFound();
            }

            var cariFaliyetSektoru = await _context.CariFaliyetSektorus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cariFaliyetSektoru == null)
            {
                return NotFound();
            }

            return View(cariFaliyetSektoru);
        }

        // GET: Admin/CariFaliyetSektorus/Create
        public IActionResult Create()
        {

            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi");

            return View();

        }

        // POST: Admin/CariFaliyetSektorus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FaliyetSektoru,Id,CreateDate,OlusturanKullaniciId")] CariFaliyetSektoru cariFaliyetSektoru)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(cariFaliyetSektoru);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi", cariFaliyetSektoru);

            return View(cariFaliyetSektoru);
        }

        // GET: Admin/CariFaliyetSektorus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CariFaliyetSektorus == null)
            {
                return NotFound();
            }

            var cariFaliyetSektoru = await _context.CariFaliyetSektorus.FindAsync(id);
            if (cariFaliyetSektoru == null)
            {
                return NotFound();
            }
            return View(cariFaliyetSektoru);
        }

        // POST: Admin/CariFaliyetSektorus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FaliyetSektoru,Id,CreateDate,OlusturanKullaniciId")] CariFaliyetSektoru cariFaliyetSektoru)
        {
            if (id != cariFaliyetSektoru.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(cariFaliyetSektoru);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CariFaliyetSektoruExists(cariFaliyetSektoru.Id))
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
            return View(cariFaliyetSektoru);
        }

        // GET: Admin/CariFaliyetSektorus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CariFaliyetSektorus == null)
            {
                return NotFound();
            }

            var cariFaliyetSektoru = await _context.CariFaliyetSektorus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cariFaliyetSektoru == null)
            {
                return NotFound();
            }

            return View(cariFaliyetSektoru);
        }

        // POST: Admin/CariFaliyetSektorus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CariFaliyetSektorus == null)
            {
                return Problem("Entity set 'SqlDbContext.CariFaliyetSektorus'  is null.");
            }
            var cariFaliyetSektoru = await _context.CariFaliyetSektorus.FindAsync(id);
            if (cariFaliyetSektoru != null)
            {
                _context.CariFaliyetSektorus.Remove(cariFaliyetSektoru);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CariFaliyetSektoruExists(int id)
        {
            return (_context.CariFaliyetSektorus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
