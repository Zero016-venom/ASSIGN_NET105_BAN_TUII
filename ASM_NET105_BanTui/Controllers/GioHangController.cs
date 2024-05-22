using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_NET105_BanTui.Core.Domain.Enums;
using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.DTO;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ASM_NET105_BanTui.Controllers
{
    public class GioHangController : Controller
    {
        AllRepository<GioHangCT> repo;
        AppDbContext context;
        AllRepository<SanPham> repoSP;
        public GioHangController()
        {
            context = new AppDbContext();
            repo = new AllRepository<GioHangCT>(context, context.GioHangCT);
            repoSP = new AllRepository<SanPham>(context, context.SanPham);
        }
        // GET: /<controller>/
        public ActionResult Index()
        {
            var check = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(check))
            {
                return RedirectToAction("Login", "TaiKhoan");
            }
            else
            {
                var cartItem = context.GioHangCT
                .Include(x => x.SanPham)
                .Where(x => x.ID_User.ToString() == check).ToList();
                return View(cartItem);
            }
        }

        public ActionResult ThanhToan()
        {
            var loginData = HttpContext.Session.GetString("UserId");
            var userCart = context.GioHangCT.Where(temp => temp.ID_User == Guid.Parse(loginData)).ToList();

            foreach (var item in userCart)
            {
                var product = context.SanPham.FirstOrDefault(temp => temp.ID_SanPham == item.ID_SanPham);

                if (product != null && item.SoLuong <= product.SoLuongTon)
                {
                    product.SoLuongTon -= item.SoLuong;
                }
                else
                {
                    TempData["Message2"] = "Sản phẩm không đủ số lượng, vui lòng check lại !!!";
                    return RedirectToAction("Index");
                }
            }

            if(userCart.Count > 0)
            {
                var hoaDon = new HoaDon()
                {
                    ID_HoaDon = Guid.NewGuid(),
                    ID_User = Guid.Parse(loginData),
                    TongTien = userCart.Sum(temp => temp.SoLuong * temp.SanPham.GiaNiemYet),
                    TrangThai = StatusOfBillOptions.Paid.ToString(),
                    NgayThanhToan = DateTime.Now
                };

                //HttpContext.Session.SetString("hoaDonId", hoaDon.ID_HoaDon.ToString());
                Guid id = hoaDon.ID_HoaDon;

                foreach (var item in userCart)
                {
                    var hoaDonCT = new HoaDonCT()
                    {
                        ID_HoaDonCT = Guid.NewGuid(),
                        ID_HoaDon = hoaDon.ID_HoaDon,
                        ID_SanPham = item.ID_SanPham,
                        GiaBan = item.SanPham.GiaNiemYet,
                        SoLuong = item.SoLuong,
                    };
                    context.HoaDonCT.Add(hoaDonCT);
                }

                context.HoaDon.Add(hoaDon);
                context.GioHangCT.RemoveRange(userCart);
                context.SaveChanges();

                return RedirectToAction("Index", "GioHang");
            }
            else
            {
                TempData["Message2"] = "Bạn chưa có sản phẩm nào trong giỏ hàng !";
            }
            return RedirectToAction("Index", "GioHang");
        }

        public IActionResult Delete(Guid id)
        {
            var loginData = HttpContext.Session.GetString("UserId");
            if (loginData == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var userId = Guid.Parse(loginData);
            var cartItem = context.GioHangCT.FirstOrDefault(item => item.ID_GioHangCT == id && item.ID_User == userId);

            if (cartItem != null)
            {
                context.GioHangCT.Remove(cartItem);
                context.SaveChanges();
            }

            return RedirectToAction("Index", "GioHang");
        }

        [HttpPost]
        public ActionResult ThayDoiSoLuong(Guid id, int quantity)
        {
            if (quantity <= 0)
            {
                TempData["Message2"] = "Số lượng phải lớn hơn 0!";
                return RedirectToAction("Index");
            }
            var loginData = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(loginData))
            {
                return RedirectToAction("Login", "TaiKhoan");
            }

            var userId = Guid.Parse(loginData);
            var cartItem = context.GioHangCT.FirstOrDefault(x => x.ID_GioHangCT == id && x.ID_User == userId);

            //var productInCartitem = context.SanPham.FirstOrDefault(x => x.ID_SanPham == cartItem.ID_SanPham);

            if (cartItem != null)
            {
                cartItem.SoLuong = quantity;
                context.SaveChanges();
            }
            //else if (quantity > productInCartitem.SoLuongTon)
            //{
            //    TempData["Message2"] = $"Số lượng phải nhỏ hơn {productInCartitem.SoLuongTon}! ";
            //    return RedirectToAction("Index");
            //}
            

            return RedirectToAction("Index");
        }

    }
}

