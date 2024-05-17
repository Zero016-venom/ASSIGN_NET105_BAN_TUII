using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var data = _db.HoaDon.Where(temp => temp.ID_User.ToString() == check)
                .Include(x => x.User).Where(p => p.ID_User.ToString() == check).ToList();
            return View(data);

            //.Include(x=>x.User).Where(p=>p.ID_User.ToString() == check)
        }

        public ActionResult Details( Guid id)
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
                .Where(x => x.ID_HoaDon == id)
                .Include(x=>x.SanPham)
                .ToList();
                return View(cartItem);
            }
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var check = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(check))
            {
                return RedirectToAction("Login", "TaiKhoan");
            }
            else
            {
                var hoaDon = _db.HoaDon.FirstOrDefault(x => x.ID_HoaDon == id);

                if (hoaDon != null &&hoaDon.TrangThai != "cancel")
                {
                    hoaDon.TrangThai = "cancel";
                    var hoaDonCTs = _db.HoaDonCT.Where(x => x.ID_HoaDon == id).ToList();
                    foreach (var item in hoaDonCTs)
                    {
                        var product = _db.SanPham.FirstOrDefault(p => p.ID_SanPham == item.ID_SanPham);
                        if (product != null)
                        {
                            product.SoLuongTon += item.SoLuong;
                        }
                    }
                    _db.SaveChanges();
                }

                return RedirectToAction("Index", "HoaDon");
            }
        }
    }
}
