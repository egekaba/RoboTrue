using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoboTrue.Core.Entities;
using RoboTrue.DataAcsess.Contexts;

namespace RoboTrue.UI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private readonly SqlDbContext _context;
        public AdminController(SqlDbContext context)
        {
            _context = context;
        }
        [Area("Admin")]
        [Authorize]
        public IActionResult Index(string urunkodu, Depo depo)
        {
            urunkodu = "Ürün Yok";
            var a = _context.SatilanUruns.Count();
            var b = _context.SatinAlinanUruns.Count();
            var c = b - a;
            ViewData["SatinAlinanUrunler"] = b;
            ViewData["SatilanUrunler"] = a;
            ViewData["DepodakiUrunSayisi"] = c;

            int x = 0;
            int y = 1;
            do
            {
                y++;

                var bb = _context.SatinAlinanUruns.Find(y);



                var bbc = _context.SatilanUruns.Find(x);


                if (bb != null && bbc != null)
                {
                    if (bb.UrunKodu == bbc.UrunKodu)
                    {
                        urunkodu = bbc.UrunKodu;


                        y--;
                        x++;


                        ViewData["DepodakiUrunler"] = urunkodu;

                        if (a <= x)
                        {
                            break;
                        }
                    }
                    else
                    {
                        y--;
                        x++;
                    }

                }
                else
                {
                    y--;
                    x++;
                }


            } while (x < a);




            x = 1;
            y = 0;
            do
            {
                x++;

                var bb = _context.SatinAlinanUruns.Find(y);



                var bbc = _context.SatilanUruns.Find(x);


                if (bb != null && bbc != null)
                {
                    if (bb.UrunKodu == bbc.UrunKodu)
                    {
                        urunkodu = bbc.UrunKodu;


                        x--;
                        y++;


                        ViewData["DepodakiUrunler"] = urunkodu;

                        if (a <= y)
                        {
                            break;
                        }
                    }
                    else
                    {
                        x--;
                        y++;
                    }

                }
                else
                {
                    x--;
                    y++;
                }


            } while (y < a);





            return _context.Depos != null ?
                                    View(_context.Depos.ToList()) :
                                    Problem("Entity set 'SqlDbContext.SatinAlinanUruns'  is null.");
        }

    }
}
