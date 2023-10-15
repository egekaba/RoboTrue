using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SatilanUrunlerController : Controller
    {
        private readonly SqlDbContext _context;

        public SatilanUrunlerController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SatilanUrunler
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var urunlers = from s in _context.SatilanUruns
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.UrunKodu);
                    break;
                case "Date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.UrunAdi);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.UrunAdi);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.UrunKodu);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.SatilanCariler);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.Kdv);
                    break;
            }
            return View(_context.SatilanUruns.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.currentFilter = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.GerSortParm = sortOrder == "Ger" ? "Ger_desc" : "Ger";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var urunlers = from s in _context.SatilanUruns
                           select s;
            if (!string.IsNullOrEmpty(searchString))
            {
                urunlers = urunlers.Where(s => s.UrunAdi.Contains(searchString)
                                        || s.UrunKodu.Contains(searchString)
                            );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.UrunKodu);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.UrunFiyati);
                    break;
                case "date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.SatilanCariler);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.UrunAdi);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.UrunAdi);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.Kdv);
                    break;

            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(urunlers.ToPagedList(pageNumber, pageSize));
        }

        // GET: Admin/SatilanUrunler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SatilanUruns == null)
            {
                return NotFound();
            }

            var satilanUrunler = await _context.SatilanUruns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satilanUrunler == null)
            {
                return NotFound();
            }

            return View(satilanUrunler);
        }

        // GET: Admin/SatilanUrunler/Create
        public IActionResult Create()
        {
            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri");
            ViewData["SatilanCarilerId"] = new SelectList(_context.Caris, "Id", "CariUnvani");
            ViewData["CreateDate"] = DateTime.Now;
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi");
            ViewData["UrunKoduId"] = new SelectList(_context.SatinAlinanUruns, "Id", "UrunKodu");







            return View();
        }

        // POST: Admin/SatilanUrunler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UrunAdi,UrunKodu,UrunFiyati,DovizCesidiId,Kdv,SatilanCarilerId,Id,CreateDate")] SatilanUrunler satilanUrunler)
        {
            if (!ModelState.IsValid || satilanUrunler != null)
            {
                _context.Add(satilanUrunler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri", satilanUrunler.DovizCesidiId);


            ViewData["SatilanCarilerId"] = new SelectList(_context.Caris, "Id", "CariUnvani", satilanUrunler.SatilanCarilerId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi", satilanUrunler);
            ViewData["UrunAdiId"] = new SelectList(_context.SatinAlinanUruns, "Id", "UrunAdi", satilanUrunler.UrunAdi);
            ViewData["UrunKoduId"] = new SelectList(_context.SatinAlinanUruns, "Id", "UrunKodu", satilanUrunler.UrunKodu);

            return View(satilanUrunler);
        }

        // GET: Admin/SatilanUrunler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SatilanUruns == null)
            {
                return NotFound();
            }

            var satilanUrunler = await _context.SatilanUruns.FindAsync(id);
            if (satilanUrunler == null)
            {
                return NotFound();
            }
            return View(satilanUrunler);
        }

        // POST: Admin/SatilanUrunler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UrunAdi,UrunKodu,UrunFiyati,DovizCesidiId,Kdv,SatilanCarilerId,Id,CreateDate")] SatilanUrunler satilanUrunler)
        {
            if (id != satilanUrunler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(satilanUrunler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SatilanUrunlerExists(satilanUrunler.Id))
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
            return View(satilanUrunler);
        }

        // GET: Admin/SatilanUrunler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SatilanUruns == null)
            {
                return NotFound();
            }

            var satilanUrunler = await _context.SatilanUruns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (satilanUrunler == null)
            {
                return NotFound();
            }

            return View(satilanUrunler);
        }

        // POST: Admin/SatilanUrunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SatilanUruns == null)
            {
                return Problem("Entity set 'SqlDbContext.SatilanUruns'  is null.");
            }
            var satilanUrunler = await _context.SatilanUruns.FindAsync(id);
            if (satilanUrunler != null)
            {
                _context.SatilanUruns.Remove(satilanUrunler);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SatilanUrunlerExists(int id)
        {
            return (_context.SatilanUruns?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
