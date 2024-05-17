using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ASM_NET105_BanTui.Controllers
{
    public class HoaDonController : Controller
    {
        AppDbContext _db;
        AllRepository<HoaDon> repoHoaDon;

        public HoaDonController(AppDbContext db)
        {
            _db = db;
            repoHoaDon = new AllRepository<HoaDon>(_db, _db.HoaDon);
        }

        public IActionResult Index()
        {
            var check = HttpContext.Session.GetString("UserId");
            var data = _db.HoaDon.Where(temp => temp.ID_User.ToString() == check).ToList();
            return View(data);
        }

        public ActionResult Details()
        {
            var check = HttpContext.Session.GetString("UserId");

            var HoaDonId = HttpContext.Session.GetString("hoaDonId");
            if (string.IsNullOrEmpty(check))
            {
                return RedirectToAction("Login", "TaiKhoan");
            }
            else
            {
                var cartItem = _db.HoaDonCT
                .Where(x => x.ID_HoaDon.ToString() == HoaDonId).ToList();
                return View(cartItem);
            }
        }
    }
}
