using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM_NET105_BanTui.Controllers
{
    public class HangController : Controller
    {
        AppDbContext db;
        AllRepository<Hang> repos;
        public HangController()
        {
            db = new AppDbContext();
            repos = new AllRepository<Hang>(db,db.Hang);
        }
        // GET: brandsController
        public ActionResult Index()
        {
            var data= repos.GetAll();
            return View(data);
        }

        // GET: brandsController/Details/5
        public ActionResult Details(Guid id)
        {
            var details= repos.GetById(id);
            return View(details);
        }

        // GET: brandsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: brandsController/Create
        [HttpPost]
        public ActionResult Create(Hang brands)
        {
            try
            {
               repos.CreateObj(brands);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: brandsController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var edit= repos.GetById(id);
            return View(edit);
        }

        // POST: brandsController/Edit/5
        [HttpPost]
        public ActionResult Edit(Hang brands)
        {
            try
            {
               repos.UpdateObj(brands);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: brandsController/Delete/5

        public ActionResult Delete(Guid id)
        {
            var delete= repos.GetById(id);
            repos.DeleteObj(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
