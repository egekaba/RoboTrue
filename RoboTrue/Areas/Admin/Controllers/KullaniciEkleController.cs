using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KullaniciEkleController : Controller
    {
        private readonly SqlDbContext _context;

        public KullaniciEkleController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/KullaniciEkle
        public async Task<IActionResult> Index(string sortOrder)
        {
            var sqlDbContext = _context.Kullanicii.Include(o => o.KayitliOlduguDepartman);
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var urunlers = from s in _context.Kullanicii
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.KullaniciAdi);
                    break;
                case "Date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Email);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.Id);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.Rol);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Email);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.KayitliOlduguDepartman);
                    break;
            }
            return View(_context.Kullanicii.ToList());
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
            var urunlers = from s in _context.Kullanicii
                           select s;
            if (!string.IsNullOrEmpty(searchString))
            {
                urunlers = urunlers.Where(s => s.KullaniciAdi.Contains(searchString)
                                        || s.Email.Contains(searchString)
                            );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.KullaniciAdi);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.Email);
                    break;
                case "date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Id);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.Rol);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Email);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.KayitliOlduguDepartman);
                    break;

            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(urunlers.ToPagedList(pageNumber, pageSize));
        }






        // GET: Admin/KullaniciEkle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kullanicii == null)
            {
                return NotFound();
            }

            var olusturanKullanici = await _context.Kullanicii
                .Include(o => o.KayitliOlduguDepartman)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (olusturanKullanici == null)
            {
                return NotFound();
            }

            return View(olusturanKullanici);
        }

        // GET: Admin/KullaniciEkle/Create
        public IActionResult Create()
        {
            ViewData["DepartmanId"] = new SelectList(_context.Departmen, "Id", "DepartmanAdi");
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName");
            return View();
        }

        // POST: Admin/KullaniciEkle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KullaniciAdi,Sifre,Email,DepartmanId,RolId,CreateDate")] OlusturanKullanici olusturanKullanici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(olusturanKullanici);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmanId"] = new SelectList(_context.Departmen, "Id", "DepartmanAdi", olusturanKullanici.DepartmanId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "RoleName", olusturanKullanici.RolId);
            return View(olusturanKullanici);
        }

        // GET: Admin/KullaniciEkle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kullanicii == null)
            {
                return NotFound();
            }

            var olusturanKullanici = await _context.Kullanicii.FindAsync(id);
            if (olusturanKullanici == null)
            {
                return NotFound();
            }
            ViewData["DepartmanId"] = new SelectList(_context.Departmen, "Id", "DepartmanAdi", olusturanKullanici.DepartmanId);
            return View(olusturanKullanici);
        }

        // POST: Admin/KullaniciEkle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KullaniciAdi,Sifre,Email,DepartmanId,RolId,CreateDate")] OlusturanKullanici olusturanKullanici)
        {
            if (id != olusturanKullanici.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(olusturanKullanici);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OlusturanKullaniciExists(olusturanKullanici.Id))
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
            ViewData["DepartmanId"] = new SelectList(_context.Departmen, "Id", "DepartmanAdi", olusturanKullanici.DepartmanId);
            return View(olusturanKullanici);
        }

        // GET: Admin/KullaniciEkle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kullanicii == null)
            {
                return NotFound();
            }

            var olusturanKullanici = await _context.Kullanicii
                .Include(o => o.KayitliOlduguDepartman)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (olusturanKullanici == null)
            {
                return NotFound();
            }

            return View(olusturanKullanici);
        }

        // POST: Admin/KullaniciEkle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kullanicii == null)
            {
                return Problem("Entity set 'SqlDbContext.Kullanicii'  is null.");
            }
            var olusturanKullanici = await _context.Kullanicii.FindAsync(id);
            if (olusturanKullanici != null)
            {
                _context.Kullanicii.Remove(olusturanKullanici);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OlusturanKullaniciExists(int id)
        {
            return (_context.Kullanicii?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
