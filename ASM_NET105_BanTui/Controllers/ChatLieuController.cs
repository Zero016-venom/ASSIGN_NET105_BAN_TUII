using ASM_NET105_BanTui.Core.Domain.Models;
using ASM_NET105_BanTui.Infrastructure.DatabaseContext;
using ASM_NET105_BanTui.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASM_NET105_BanTui.Controllers
{
    public class ChatLieuController : Controller
    {
        AllRepository<ChatLieu> repo;
        AppDbContext context;
        public ChatLieuController()
        {
            context = new AppDbContext();
            repo = new AllRepository<ChatLieu>(context, context.ChatLieu);
        }
        // GET: ChatLieuController
        public ActionResult Index() 
        {
            var data = repo.GetAll();
            return View(data);
        }

        // GET: ChatLieuController/Details/5
        public ActionResult Details(Guid id)
        {
            var data =  repo.GetById(id);
            return View(data);
        }

        // GET: ChatLieuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChatLieuController/Create
        [HttpPost]
        public ActionResult Create(ChatLieu chatLieu)
        {
            try
            {
                chatLieu.ID_ChatLieu = Guid.NewGuid();
                repo.CreateObj(chatLieu);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChatLieuController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var data = repo.GetById(id);
            return View(data);
        }

        // POST: ChatLieuController/Edit/5
        [HttpPost]
        public ActionResult Edit(ChatLieu chatLieu)
        {
            try
            {
                repo.UpdateObj(chatLieu);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChatLieuController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var data = repo.GetById(id);
            repo.DeleteObj(data);
            return RedirectToAction("Index");
        }
    }
}
