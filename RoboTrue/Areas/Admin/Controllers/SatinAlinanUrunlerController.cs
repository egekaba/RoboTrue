using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SatinAlinanUrunlerController : Controller
    {
        private readonly SqlDbContext _context;

        public SatinAlinanUrunlerController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SatinAlinanUrunler
        public async Task<IActionResult> Index()
        {
            return _context.SatinAlinanUruns != null ?
                        View(await _context.SatinAlinanUruns.ToListAsync()) :
                        Problem("Entity set 'SqlDbContext.SatinAlinanUruns'  is null.");
        }

        // GET: Admin/SatinAlinanUrunler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SatinAlinanUruns == null)
            {
                return NotFound();
            }

            var satinAlinanUrun = await _context.SatinAlinanUruns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satinAlinanUrun == null)
            {
                return NotFound();
            }

            return View(satinAlinanUrun);
        }

        // GET: Admin/SatinAlinanUrunler/Create
        public IActionResult Create()
        {
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi");


            var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = true, UseSpecial = false });
            string text = randomizerText.Generate();

            ViewData["SatinAlinanUrunKoduId"] = text;


            return View();
        }

        // POST: Admin/SatinAlinanUrunler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UrunAdi,AlisFiyati,Id,CreateDate,OlusturanKullaniciId,SatinAlinanUrunKoduId,UrunKodu")] SatinAlinanUrun satinAlinanUrun)
        {

            if (!ModelState.IsValid)
            {
                _context.Add(satinAlinanUrun);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi", satinAlinanUrun);


            return View(satinAlinanUrun);
        }

        // GET: Admin/SatinAlinanUrunler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SatinAlinanUruns == null)
            {
                return NotFound();
            }

            var satinAlinanUrun = await _context.SatinAlinanUruns.FindAsync(id);
            if (satinAlinanUrun == null)
            {
                return NotFound();
            }
            return View(satinAlinanUrun);
        }

        // POST: Admin/SatinAlinanUrunler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UrunAdi,AlisFiyati,Id,CreateDate,OlusturanKullaniciId")] SatinAlinanUrun satinAlinanUrun)
        {
            if (id != satinAlinanUrun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(satinAlinanUrun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SatinAlinanUrunExists(satinAlinanUrun.Id))
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
            return View(satinAlinanUrun);
        }

        // GET: Admin/SatinAlinanUrunler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SatinAlinanUruns == null)
            {
                return NotFound();
            }

            var satinAlinanUrun = await _context.SatinAlinanUruns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satinAlinanUrun == null)
            {
                return NotFound();
            }

            return View(satinAlinanUrun);
        }

        // POST: Admin/SatinAlinanUrunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SatinAlinanUruns == null)
            {
                return Problem("Entity set 'SqlDbContext.SatinAlinanUruns'  is null.");
            }
            var satinAlinanUrun = await _context.SatinAlinanUruns.FindAsync(id);
            if (satinAlinanUrun != null)
            {
                _context.SatinAlinanUruns.Remove(satinAlinanUrun);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SatinAlinanUrunExists(int id)
        {
            return (_context.SatinAlinanUruns?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
