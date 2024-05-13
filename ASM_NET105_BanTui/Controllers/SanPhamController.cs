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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM_NET105_BanTui.Controllers
{
    public class SanPhamController : Controller
    {
        AllRepository<SanPham> repo;
        AppDbContext context;   
        public SanPhamController()
        {
            context = new AppDbContext();
            repo = new AllRepository<SanPham>(context, context.SanPham);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var data = context.SanPham
                .Include(p => p.LoaiSP)
                .Include(p=>p.MauSac)
                .Include(p=>p.Hang)
                .Include(p=>p.ChatLieu)
                .ToList();
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
        public IActionResult Edit(SanPham sp)
        {
            ViewBag.LoaiSP = new SelectList(context.LoaiSP.ToList(), "ID_LoaiSP", "TenLoaiSP");
            ViewBag.MauSac = new SelectList(context.MauSac.ToList(), "ID_MauSac", "TenMauSac");
            ViewBag.Hang = new SelectList(context.Hang.ToList(), "ID_Hang", "TenHang");
            ViewBag.ChatLieu = new SelectList(context.ChatLieu.ToList(), "ID_ChatLieu", "TenChatLieu");
            repo.UpdateObj(sp);
            return RedirectToAction("Index");
        }
    }
}

