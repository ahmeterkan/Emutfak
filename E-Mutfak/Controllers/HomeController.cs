using E_Mutfak.Models;
using E_Mutfak.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Mutfak.Controllers
{
    public class HomeController : Controller
    {
        private UserManager userManager = new UserManager();
        // GET: Home
        public ActionResult Index()
        {
            return View(userManager.List().ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            userManager.Insert(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(int id, double TCKN, string AdSoyad, string Sifre, decimal Fiyat, Doviz paraBirimi)
        {
            User postUser = new User();
            postUser.Id = id;
            postUser.TCKN = TCKN;
            postUser.AdSoyad = AdSoyad;
            postUser.Sifre = Sifre;
            postUser.Fiyat = Fiyat;
            postUser.paraBirimi = paraBirimi;
            userManager.Update(postUser);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete(int id)
        {
            User user = userManager.Find(x => x.Id == id);
            userManager.Delete(user);
            return RedirectToAction("Index");
        }
    }
}