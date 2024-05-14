using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM_NET105_BanTui.Controllers
{
    public class GioHangCTController : Controller
    {
        // GET: GioHangCTController
        AllRepository<GioHangCT> repo;
        AppDbContext context;
        public GioHangCTController()
        {
            context = new AppDbContext();
            repo = new AllRepository<GioHangCT>(context, context.GioHangCT);
        }
        public ActionResult Index()
        {
            //var check = HttpContext.Session.GetString("UserId");
            //if (Guid.TryParse(check, out Guid UserId))
            //{
            //    if (UserId == Guid.Empty)
            //    {
            //        return RedirectToAction("Login", "Account");
            //    }
            //    else
            //    {

            //        var cartItem = repo.GetAll().FirstOrDefault(x => x.ID_User == UserId);
            //        return View(cartItem);
            //    }
            //}
            var data = repo.GetAll();
            return View(data);
        }

        // GET: GioHangCTController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GioHangCTController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GioHangCTController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GioHangCTController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GioHangCTController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GioHangCTController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GioHangCTController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
