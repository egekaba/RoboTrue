using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList;
using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CariEkleController : Controller
    {
        private readonly SqlDbContext _context;

        public CariEkleController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CariEkle
        public async Task<IActionResult> Index(string sortOrder)
        {
            var sqlDbContext = _context.Caris.Include(c => c.CalismaDovizi).Include(c => c.CariAdresCesit).Include(c => c.CariTipi).Include(c => c.FaliyetSektoru).Include(c => c.Ilce).Include(c => c.SatilanUrunleri).Include(c => c.Sehir).Include(c => c.TelUlkeKodu).Include(c => c.TelefonCesit).Include(c => c.Ulke).Include(c => c.VerigiDairesi);
            ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var urunlers = from s in _context.Caris
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.CariUnvani);
                    break;
                case "Date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.CariKodu);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.Id);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.CariUnvani);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Email);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.CariKodu);
                    break;
            }
            return View(_context.Caris.ToList());
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
            var urunlers = from s in _context.Caris
                           select s;
            if (!string.IsNullOrEmpty(searchString))
            {
                urunlers = urunlers.Where(s => s.CariUnvani.Contains(searchString)
                                        || s.CariKodu.Contains(searchString)
                            );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    urunlers = urunlers.OrderByDescending(s => s.CariUnvani);
                    break;
                case "Date":
                    urunlers = urunlers.OrderBy(s => s.CariKodu);
                    break;
                case "date_desc":
                    urunlers = urunlers.OrderByDescending(s => s.Id);
                    break;
                case "Ger":
                    urunlers = urunlers.OrderBy(s => s.CariKodu);
                    break;
                case "Ger_desc":
                    urunlers = urunlers.OrderByDescending(s => s.CariUnvani);
                    break;
                default:
                    urunlers = urunlers.OrderBy(s => s.Email);
                    break;

            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(urunlers.ToPagedList(pageNumber, pageSize));
        }





        // GET: Admin/CariEkle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Caris == null)
            {
                return NotFound();
            }

            var cari = await _context.Caris
                .Include(c => c.CalismaDovizi)
                .Include(c => c.CariAdresCesit)
                .Include(c => c.CariTipi)
                .Include(c => c.FaliyetSektoru)
                .Include(c => c.Ilce)
                .Include(c => c.SatilanUrunleri)
                .Include(c => c.Sehir)
                .Include(c => c.TelUlkeKodu)
                .Include(c => c.TelefonCesit)
                .Include(c => c.Ulke)
                .Include(c => c.VerigiDairesi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cari == null)
            {
                return NotFound();
            }

            return View(cari);
        }

        // GET: Admin/CariEkle/Create
        public IActionResult Create()
        {
            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri");
            ViewData["CariAdresCesitId"] = new SelectList(_context.AdresCesits, "Id", "AdresCesidi");
            ViewData["CariTipiId"] = new SelectList(_context.CariTipis, "Id", "SirketTipi");
            ViewData["FaliyetSektoruId"] = new SelectList(_context.CariFaliyetSektorus, "Id", "FaliyetSektoru");
            ViewData["IlceId"] = new SelectList(_context.Ilces, "Id", "IlceAdi");
            ViewData["SatilanUrunleriId"] = new SelectList(_context.SatilanUruns, "Id", "Id");
            ViewData["SehirId"] = new SelectList(_context.Sehirs, "Id", "SehirAdi");
            ViewData["TelUlkeKoduId"] = new SelectList(_context.TelUlkeKodus, "Id", "UlkeKodlari");
            ViewData["TelefonCesitId"] = new SelectList(_context.TelefonCesits, "Id", "TelefonCesiti");
            ViewData["UlkeId"] = new SelectList(_context.Ulkes, "Id", "Ulkeler");
            ViewData["VerigiDairesiId"] = new SelectList(_context.VergiDairesis, "Id", "VergiDairesiAdi");
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi");


            var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = true, UseSpecial = false });
            string text = randomizerText.Generate();

            ViewData["CariKoduId"] = text;




            return View();
        }


        // POST: Admin/CariEkle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CariKodu,CariUnvani,CariTipiId,FaliyetSektoruId,VerigiDairesiId,VergiNo,VatandasNo,Email,OzelKod,CariAdresCesitId,AdresAd,AdresSoyisim,Adres1,Adres2,Adres3,SehirId,PostaKodu,IlceId,UlkeId,TelefonCesitId,TelefonAdi,TelUlkeKoduId,TelNo,Aktiflik,Bloke,DovizCesidiId,SgkNo,SatilanUrunleriId,Id,CreateDate,OlusturanKullaniciId")] Cari cari)
        {

            var randomizerText = RandomizerFactory.GetRandomizer(new FieldOptionsText { UseNumber = true, UseSpecial = false });
            string text = randomizerText.Generate();
            ViewData["CariKoduId"] = new SelectList(_context.Caris.Where(p => p.CariKodu == text), "Id", "CariKodu", cari.CariKodu);

            if (!ModelState.IsValid)
            {
                _context.Add(cari);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri", cari.DovizCesidiId);
            ViewData["CariAdresCesitId"] = new SelectList(_context.AdresCesits, "Id", "AdresCesidi", cari.CariAdresCesitId);
            ViewData["CariTipiId"] = new SelectList(_context.CariTipis, "Id", "SirketTipi", cari.CariTipiId);
            ViewData["FaliyetSektoruId"] = new SelectList(_context.CariFaliyetSektorus, "Id", "FaliyetSektoru", cari.FaliyetSektoruId);
            ViewData["IlceId"] = new SelectList(_context.Ilces, "Id", "IlceAdi", cari.IlceId);
            ViewData["SatilanUrunleriId"] = new SelectList(_context.SatilanUruns, "Id", "Id", cari.SatilanUrunleriId);
            ViewData["SehirId"] = new SelectList(_context.Sehirs, "Id", "SehirAdi", cari.SehirId);
            ViewData["TelUlkeKoduId"] = new SelectList(_context.TelUlkeKodus, "Id", "UlkeKodlari", cari.TelUlkeKoduId);
            ViewData["TelefonCesitId"] = new SelectList(_context.TelefonCesits, "Id", "TelefonCesiti", cari.TelefonCesitId);
            ViewData["UlkeId"] = new SelectList(_context.Ulkes, "Id", "Ulkeler", cari.UlkeId);
            ViewData["VerigiDairesiId"] = new SelectList(_context.VergiDairesis, "Id", "VergiDairesiAdi", cari.VerigiDairesiId);
            ViewData["KullaniciId"] = new SelectList(_context.Kullanicii.Where(p => p.KullaniciAdi == User.Identity.Name), "Id", "KullaniciAdi", cari);

            return View(cari);
        }



        // GET: Admin/CariEkle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Caris == null)
            {
                return NotFound();
            }

            var cari = await _context.Caris.FindAsync(id);
            if (cari == null)
            {
                return NotFound();
            }
            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri", cari.DovizCesidiId);
            ViewData["CariAdresCesitId"] = new SelectList(_context.AdresCesits, "Id", "AdresCesidi", cari.CariAdresCesitId);
            ViewData["CariTipiId"] = new SelectList(_context.CariTipis, "Id", "SirketTipi", cari.CariTipiId);
            ViewData["FaliyetSektoruId"] = new SelectList(_context.CariFaliyetSektorus, "Id", "FaliyetSektoru", cari.FaliyetSektoruId);
            ViewData["IlceId"] = new SelectList(_context.Ilces, "Id", "IlceAdi", cari.IlceId);
            ViewData["SatilanUrunleriId"] = new SelectList(_context.SatilanUruns, "Id", "Id", cari.SatilanUrunleriId);
            ViewData["SehirId"] = new SelectList(_context.Sehirs, "Id", "SehirAdi", cari.SehirId);
            ViewData["TelUlkeKoduId"] = new SelectList(_context.TelUlkeKodus, "Id", "UlkeKodlari", cari.TelUlkeKoduId);
            ViewData["TelefonCesitId"] = new SelectList(_context.TelefonCesits, "Id", "TelefonCesiti", cari.TelefonCesitId);
            ViewData["UlkeId"] = new SelectList(_context.Ulkes, "Id", "Ulkeler", cari.UlkeId);
            ViewData["VerigiDairesiId"] = new SelectList(_context.VergiDairesis, "Id", "VergiDairesiAdi", cari.VerigiDairesiId);
            return View(cari);
        }

        // POST: Admin/CariEkle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CariKodu,CariUnvani,CariTipiId,FaliyetSektoruId,VerigiDairesiId,VergiNo,VatandasNo,Email,OzelKod,CariAdresCesitId,AdresAd,AdresSoyisim,Adres1,Adres2,Adres3,SehirId,PostaKodu,IlceId,UlkeId,TelefonCesitId,TelefonAdi,TelUlkeKoduId,TelNo,Aktiflik,Bloke,DovizCesidiId,SgkNo,SatilanUrunleriId,Id,CreateDate,OlusturanKullaniciId")] Cari cari)
        {
            if (id != cari.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(cari);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CariExists(cari.Id))
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
            ViewData["DovizCesidiId"] = new SelectList(_context.DovizCesidis, "Id", "DovizCesitleri", cari.DovizCesidiId);
            ViewData["CariAdresCesitId"] = new SelectList(_context.AdresCesits, "Id", "AdresCesidi", cari.CariAdresCesitId);
            ViewData["CariTipiId"] = new SelectList(_context.CariTipis, "Id", "SirketTipi", cari.CariTipiId);
            ViewData["FaliyetSektoruId"] = new SelectList(_context.CariFaliyetSektorus, "Id", "Id", cari.FaliyetSektoruId);
            ViewData["IlceId"] = new SelectList(_context.Ilces, "Id", "IlceAdi", cari.IlceId);
            ViewData["SatilanUrunleriId"] = new SelectList(_context.SatilanUruns, "Id", "Id", cari.SatilanUrunleriId);
            ViewData["SehirId"] = new SelectList(_context.Sehirs, "Id", "SehirAdi", cari.SehirId);
            ViewData["TelUlkeKoduId"] = new SelectList(_context.TelUlkeKodus, "Id", "UlkeKodlari", cari.TelUlkeKoduId);
            ViewData["TelefonCesitId"] = new SelectList(_context.TelefonCesits, "Id", "TelefonCesiti", cari.TelefonCesitId);
            ViewData["UlkeId"] = new SelectList(_context.Ulkes, "Id", "Ulkeler", cari.UlkeId);
            ViewData["VerigiDairesiId"] = new SelectList(_context.VergiDairesis, "Id", "VergiDairesiAdi", cari.VerigiDairesiId);
            return View(cari);
        }

        // GET: Admin/CariEkle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Caris == null)
            {
                return NotFound();
            }

            var cari = await _context.Caris
                .Include(c => c.CalismaDovizi)
                .Include(c => c.CariAdresCesit)
                .Include(c => c.CariTipi)
                .Include(c => c.FaliyetSektoru)
                .Include(c => c.Ilce)
                .Include(c => c.SatilanUrunleri)
                .Include(c => c.Sehir)
                .Include(c => c.TelUlkeKodu)
                .Include(c => c.TelefonCesit)
                .Include(c => c.Ulke)
                .Include(c => c.VerigiDairesi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cari == null)
            {
                return NotFound();
            }

            return View(cari);
        }

        // POST: Admin/CariEkle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Caris == null)
            {
                return Problem("Entity set 'SqlDbContext.Caris'  is null.");
            }
            var cari = await _context.Caris.FindAsync(id);
            if (cari != null)
            {
                _context.Caris.Remove(cari);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CariExists(int id)
        {
            return (_context.Caris?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
