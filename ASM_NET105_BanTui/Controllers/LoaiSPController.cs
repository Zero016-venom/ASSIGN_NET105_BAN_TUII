using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM_NET105_BanTui.Controllers
{
    public class LoaiSPController : Controller
    {
        AllRepository<LoaiSP> repo;
        AppDbContext context;
        public LoaiSPController()
        {
            context = new AppDbContext();
            repo = new AllRepository<LoaiSP>(context, context.LoaiSP); 
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var data = repo.GetAll();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LoaiSP loaiSP)
        {
            loaiSP.ID_LoaiSP = Guid.NewGuid();
            repo.CreateObj(loaiSP);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var temp = repo.GetById(id);
            return View(temp);
        }
        public IActionResult Edit(Guid id)
        {
            var temp = repo.GetById(id);
            return View(temp);
        }
        [HttpPost]
        public IActionResult Edit(LoaiSP loaiSP)
        {
            repo.UpdateObj(loaiSP);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            var temp = repo.GetById(id);
            repo.DeleteObj(temp);
            return RedirectToAction("Index");
        }
    }
}

