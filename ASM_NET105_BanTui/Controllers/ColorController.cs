using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM_NET105_BanTui.Controllers
{
    public class ColorController : Controller
    {
        AppDbContext db;
        AllRepository<MauSac> repos;
        public ColorController()
        {
            db = new AppDbContext();
            repos= new AllRepository<MauSac>(db,db.MauSac);
        }
        // GET: ColorController
        public ActionResult Index()
        {
            var data= db.MauSac.ToList();
            return View(data);
        }

        // GET: ColorController/Details/5
        public ActionResult Details(Guid id)
        {
            var details= db.MauSac.Find(id);
            return View(details);
        }

        // GET: ColorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColorController/Create
        [HttpPost]
  
        public ActionResult Create(MauSac mauSac)
        {
            try
            {
                db.MauSac.Add(mauSac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ColorController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var edit = db.MauSac.Find(id);
            return View(edit);
        }

        // POST: ColorController/Edit/5
        [HttpPost]
        public ActionResult Edit(MauSac mauSac)
        {
            try
            {
               repos.UpdateObj(mauSac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ColorController/Delete/5
       

        // POST: ColorController/Delete/
        public ActionResult Delete(Guid id)
        {
            
                var delete = repos.GetById(id);
                repos.DeleteObj(delete);
                db.SaveChanges();
                return RedirectToAction("Index");
          
        }
    }
}
