    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ASM_NET105_BanTui.Core.Domain.Models;
    using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
    using ASM_NET105_BanTui.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;


    namespace ASM_NET105_BanTui.Controllers
    {
        public class SanPhamController : Controller
        {
            AllRepository<GioHangCT> repoGHCT;
            AllRepository<SanPham> repo;
            AppDbContext context;   
            public SanPhamController()
            {
                context = new AppDbContext();
                repo = new AllRepository<SanPham>(context, context.SanPham);
                repoGHCT = new AllRepository<GioHangCT>(context, context.GioHangCT);
            }
            // GET: /<controller>/
            public IActionResult Index()
            {
                var data = context.SanPham
                    .Include(p => p.LoaiSP)
                    .Include(p=>p.MauSac)
                    .Include(p=>p.Hang)
                    .Include(p=>p.ChatLieu).ToList();
                return View(data);
            }

            public IActionResult IndexKH()
            {
                var data = context.SanPham
                    .Include(p => p.LoaiSP)
                    .Include(p => p.MauSac)
                    .Include(p => p.Hang)
                    .Include(p => p.ChatLieu).ToList();
                return View(data);
            }

        public IActionResult Create()
            {
                ViewBag.LoaiSP = new SelectList(context.LoaiSP.ToList(), "ID_LoaiSP", "TenLoaiSP");
                ViewBag.MauSac = new SelectList(context.MauSac.ToList(), "ID_MauSac", "TenMauSac");
                ViewBag.Hang = new SelectList(context.Hang.ToList(), "ID_Hang", "TenHang");
                ViewBag.ChatLieu = new SelectList(context.ChatLieu.ToList(), "ID_ChatLieu", "TenChatLieu");
                return View();
            }
            [HttpPost]
            public IActionResult Create(SanPham sp, IFormFile imgFile)
            {
                if (imgFile != null && imgFile.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imgs", imgFile.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    imgFile.CopyTo(stream);
                    sp.Img = imgFile.FileName;
                }
                else
                {
                    sp.Img = "";
                }
                sp.ID_SanPham = Guid.NewGuid();
                repo.CreateObj(sp);
                return RedirectToAction("Index");
            }
            public IActionResult Delete(Guid id)
            {
                var temp = repo.GetById(id);
                repo.DeleteObj(temp);
                return RedirectToAction("Index");
            }
            public IActionResult Details(Guid id)
            {
                ViewBag.LoaiSP = new SelectList(context.LoaiSP.ToList(), "ID_LoaiSP", "TenLoaiSP");
                ViewBag.MauSac = new SelectList(context.MauSac.ToList(), "ID_MauSac", "TenMauSac");
                ViewBag.Hang = new SelectList(context.Hang.ToList(), "ID_Hang", "TenHang");
                ViewBag.ChatLieu = new SelectList(context.ChatLieu.ToList(), "ID_ChatLieu", "TenChatLieu");
                var temp = repo.GetById(id);
                return View(temp);
            }
        public IActionResult DetailsKH(Guid id)
        {
            ViewBag.LoaiSP = new SelectList(context.LoaiSP.ToList(), "ID_LoaiSP", "TenLoaiSP");
            ViewBag.MauSac = new SelectList(context.MauSac.ToList(), "ID_MauSac", "TenMauSac");
            ViewBag.Hang = new SelectList(context.Hang.ToList(), "ID_Hang", "TenHang");
            ViewBag.ChatLieu = new SelectList(context.ChatLieu.ToList(), "ID_ChatLieu", "TenChatLieu");
            var temp = repo.GetById(id);
            return View(temp);
        }
        public IActionResult Edit(Guid id)
        {
            ViewBag.LoaiSP = new SelectList(context.LoaiSP.ToList(), "ID_LoaiSP", "TenLoaiSP");
            ViewBag.MauSac = new SelectList(context.MauSac.ToList(), "ID_MauSac", "TenMauSac");
            ViewBag.Hang = new SelectList(context.Hang.ToList(), "ID_Hang", "TenHang");
            ViewBag.ChatLieu = new SelectList(context.ChatLieu.ToList(), "ID_ChatLieu", "TenChatLieu");
            var temp = repo.GetById(id);
            return View(temp);
        }

        [HttpPost]
        public IActionResult Edit(SanPham sp, IFormFile imgFile)
        {
            var spcu = repo.GetById(sp.ID_SanPham);
            if (imgFile != null && imgFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imgs", imgFile.FileName);
                var stram = new FileStream(path, FileMode.Create);
                imgFile.CopyTo(stram);
                sp.Img = imgFile.FileName;
            }
            else
            {
                sp.Img = spcu.Img;
            }
            spcu.TenSanPham = sp.TenSanPham;
            spcu.SoLuongTon = sp.SoLuongTon;
            spcu.GiaNiemYet = sp.GiaNiemYet;
            spcu.ID_LoaiSP = sp.ID_LoaiSP;
            spcu.ID_Hang = sp.ID_Hang;
            spcu.ID_MauSac = sp.ID_MauSac;
            spcu.ID_ChatLieu = sp.ID_ChatLieu;
            spcu.TrangThai = sp.TrangThai;
            spcu.Img = sp.Img;

            repo.UpdateObj(spcu);
            return RedirectToAction("Index");
        }

        public IActionResult AddToCart(Guid id, int SL)
        {
            SL = 1;
            var check = HttpContext.Session.GetString("UserId");
            if (Guid.TryParse(check, out Guid UserId))
            {
                if (string.IsNullOrEmpty(check))
                {
                    return RedirectToAction("Login", "TaiKhoan");
                }
                else
                {
                    var cartItem = repoGHCT.GetAll().FirstOrDefault(x => x.ID_User == UserId && x.ID_SanPham == id);
                    if (cartItem == null)
                    {
                        var matchingSanPham = repo.GetById(id);
                        if (matchingSanPham.SoLuongTon <= 0)
                        {
                            TempData["Message2"] = "Sản phẩm hết mất rồi !";
                            matchingSanPham.SoLuongTon = 0;

                        }
                        else
                        {
                            GioHangCT gioHangCT = new GioHangCT()
                            {
                                ID_GioHangCT = Guid.NewGuid(),
                                ID_SanPham = id,
                                SoLuong = SL,
                                ID_User = UserId,
                            };
                            repoGHCT.CreateObj(gioHangCT);
                        }
                    }
                    else
                    {
                        var sanPham = repo.GetById(id);

                        if (cartItem.SoLuong + SL <= sanPham.SoLuongTon)
                        {
                            cartItem.SoLuong = cartItem.SoLuong + SL;
                            repoGHCT.UpdateObj(cartItem);
                        }
                        else
                        {
                            TempData["Message"] = "Đã đạt số lượng tối đa !";
                        }
                    }
                }
            }
            return RedirectToAction("IndexKH", "SanPham");
        }

        public IActionResult AddToCart2(Guid id, int quantity)
        {
            var check = HttpContext.Session.GetString("UserId");
            if (Guid.TryParse(check, out Guid UserId))
            {
                if (string.IsNullOrEmpty(check))
                {
                    return RedirectToAction("Login", "TaiKhoan");
                }
                else
                {
                    var cartItem = repoGHCT.GetAll().FirstOrDefault(x => x.ID_User == UserId && x.ID_SanPham == id);
                    if (cartItem == null)
                    {
                        var matchingSanPham = repo.GetById(id);
                        if (matchingSanPham.SoLuongTon <= 0)
                        {
                            TempData["Message2"] = "Sản phẩm hết mất rồi !";
                            matchingSanPham.SoLuongTon = 0;
                        }
                        else
                        {
                            GioHangCT gioHangCT = new GioHangCT()
                            {
                                ID_GioHangCT = Guid.NewGuid(),
                                ID_SanPham = id,
                                SoLuong = quantity,
                                ID_User = UserId,
                            };
                            repoGHCT.CreateObj(gioHangCT);
                        }
                    }
                    else
                    {
                        var sanPham = repo.GetById(id);

                        if(cartItem.SoLuong + quantity <= sanPham.SoLuongTon)
                        {
                            cartItem.SoLuong = cartItem.SoLuong + quantity;
                            repoGHCT.UpdateObj(cartItem);
                        }
                        else
                        {
                            TempData["Message"] = "Đã đạt số lượng tối đa !";
                        }
                    }
                }
            }
            return RedirectToAction("IndexKH", "SanPham");
        }

        public IActionResult AddToCartView(Guid id)
        {
            // Lấy thông tin sản phẩm từ ID và truyền vào view
            var product = context.SanPham.FirstOrDefault(p => p.ID_SanPham == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}

//test