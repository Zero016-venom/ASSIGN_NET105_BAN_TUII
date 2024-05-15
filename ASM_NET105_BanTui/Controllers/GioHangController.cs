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
    public class GioHangController : Controller
    {
        AllRepository<GioHangCT> repo;
        AppDbContext context;
        public GioHangController()
        {
            context = new AppDbContext();
            repo = new AllRepository<GioHangCT>(context, context.GioHangCT);
        }
        // GET: /<controller>/
        public ActionResult Index()
        {
            var check = HttpContext.Session.GetString("UserId");
            if (Guid.TryParse(check, out Guid UserId))
            {
                if (UserId == Guid.Empty)
                {
                    return RedirectToAction("Login", "TaiKhoan");
                }
                else
                {

                    var cartItem = repo.GetAll().Where(x => x.ID_User == UserId).ToList();
                    return View(cartItem);
                }
            }
            // var data = repo.GetAll();
            return View();
        }
    }
}

