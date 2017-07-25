using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        MyDatabaseEntities3 db = new MyDatabaseEntities3();

        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addbook()
        {
            return View();
        }

        public ActionResult Addbookconfirm(Book b)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(b);
                db.SaveChanges();
                return RedirectToAction("showbook");
            }
            return View("addbook");
        }


        public ActionResult updatebook(int id)
        {
            Book p = db.Books.Find(id);
            return View(p);
        }
        public ActionResult updatebookconfirm(int id)
        {
            Book p = db.Books.Find(id);
            String Name = Request["t1"];
            String Author = Request["t2"];
            String Edition = Request["t3"];
            String Price = Request["t4"];
            String Stock = Request["t5"];
            String Discount = Request["t6"];


            p.bname = Name;
            p.author = Author;
            p.edition = Edition;
            p.price = Price;
            p.stock = Stock;
            p.discount = Discount;
            

            db.SaveChanges();

            return RedirectToAction("showbook");
        }


        public ActionResult deletebook(int id)
        {
            Book p = db.Books.Find(id);
            db.Books.Remove(p);
            db.SaveChanges();

            return RedirectToAction("showbook");
        }

        public ActionResult showbook()
        {
            return View(db.Books.ToList());
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your details page.";

            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Your cart page.";

            return View();
        }

        public ActionResult MyAccount()
        {
            ViewBag.Message = "Your account page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your registreration page.";

            return View();
        }

        public ActionResult Specials()
        {
            ViewBag.Message = "Your special page.";

            return View();
        }
    }
}