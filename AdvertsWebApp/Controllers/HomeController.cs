using AdvertsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AdvertsWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            advertDb = new AdvertDb();
        }
        private List<Advert> adverts;
        private AdvertDb advertDb;

        // GET: Home
        public ActionResult Index()
        {
            return View(advertDb.Advert.ToList());
        }

        public ActionResult Advert(int advertId)
        {
            Advert ad = GetAdvertFromDb(advertId);
            return View(ad);
        }


        private Advert GetAdvertFromDb(int advertId)
        {
            foreach (var ad in advertDb.Advert)
            {
                if (ad.AdvertId == advertId)
                {
                    return ad;
                }
            }
            return null;
        }


        public ActionResult CreateAdvert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateAdvert(Advert advert)
        {
            advert.CreationTime = DateTime.Now;
            advertDb.Advert.Add(advert);
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditAdvert(int advertId)
        {
            Advert editableAdvert = GetAdvertFromDb(advertId);
            return View(editableAdvert);
        }

        [HttpPost]
        public ActionResult EditAdvert(Advert advert)
        {
            if(!ModelState.IsValid)
            {
                View(advert);
            }
            advertDb.Entry(advert).State = System.Data.Entity.EntityState.Modified;
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}