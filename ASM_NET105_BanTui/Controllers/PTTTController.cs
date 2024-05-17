using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Mvc;


namespace ASM_NET105_BanTui.Controllers
{
    public class PTTTController : Controller
    {
        AllRepository<PTTT> repo;
        AppDbContext context;
        public PTTTController()
        {
            context = new AppDbContext();
            repo = new AllRepository<PTTT>(context, context.PTTT);
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
        public IActionResult Create(PTTT pTTT)
        {
            pTTT.ID_PTTT = Guid.NewGuid();
            repo.CreateObj(pTTT);
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
        public IActionResult Edit(PTTT pTTT)
        {
            repo.UpdateObj(pTTT);
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

